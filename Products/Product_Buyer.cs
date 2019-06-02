using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Product_Buyer : Form
    {
        private bool searchButtonWasClicked = false;

        public Product_Buyer()
        {
            InitializeComponent();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            String Username_Buyer = buyerBox.Text;
            String Category_Name = categoryBox.Text;

            if (Category_Name == "")
            {
                Category_Name = "%";
            }

            String search_keywords = "";

            if (searchButtonWasClicked)
            {
                search_keywords = searchBox.Text;
            }

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT * " +
                    "FROM ecommerce.UDF_SEARCH_PRODUCT_BUYER (@Keywords, @Cat_Name, @Username_Buyer) ", con);
                cm1.Parameters.AddWithValue("@Username_Buyer", Username_Buyer);
                cm1.Parameters.AddWithValue("@Cat_Name", Category_Name);
                cm1.Parameters.AddWithValue("@Keywords", search_keywords);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["Code"].ToString());
                    item.SubItems.Add(rd1["Product_Name"].ToString());
                    item.SubItems.Add(rd1["Category_Name"].ToString());
                    item.SubItems.Add(rd1["Description"].ToString());

                    String seller_username = rd1["username_Seller"].ToString();
                    item.SubItems.Add(seller_username);

                    String seller_rating = rd1["avgRating"].ToString();

                    if (sellerHasReviews(seller_username))
                    {
                        item.SubItems.Add(seller_rating);
                    }

                    else
                    {
                        item.SubItems.Add("Not Rated");
                    }

                    ProdBuyerLV.Items.Add(item);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                searchButtonWasClicked = false;
                con.Close();
            }
        }

        private void Product_Buyer_Load(object sender, EventArgs e)
        {
            ProdBuyerLV.Items.Clear();
            populateListView();
            populateCategoryBox();
            populateBuyerBox();
        }

        private void populateCategoryBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm2 = new SqlCommand("SELECT Name FROM ecommerce.PRODUCT_CATEGORY", con);

                SqlDataReader rd2 = cm2.ExecuteReader();

                while (rd2.Read())
                {

                    categoryBox.Items.Add(rd2["Name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }
        }

        private void allCategories_CheckedChanged(object sender, EventArgs e)
        {
            if (allCategories.Checked)
            {
                categoryBox.Text = "";
                ProdBuyerLV.Items.Clear();
                populateListView();
                this.Refresh();
            }
        }

        private void categoryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (categoryBox.SelectedIndex > -1)
            {
                allCategories.Checked = false;
                ProdBuyerLV.Items.Clear();
                populateListView();
                this.Refresh();
            }

        }

        private void populateBuyerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT userName FROM ecommerce.REGULAR_USER", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {

                    buyerBox.Items.Add(rd1["userName"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }
        }

        private void buyerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdBuyerLV.Items.Clear();
            populateListView();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            buyerBox.Text = "";
            categoryBox.Text = "";
            searchBox.Text = "";
            ProdBuyerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchButtonWasClicked = true;
            ProdBuyerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void auctionButton_Click(object sender, EventArgs e)
        {
            if (ProdBuyerLV.SelectedItems.Count == 1)
            {
                ListViewItem item = ProdBuyerLV.SelectedItems[0];

                int productCode = Convert.ToInt32(item.SubItems[0].Text);

                Open_Auctions f = new Open_Auctions(productCode);
                f.Show();
            }

            else
            {
                MessageBox.Show("You need to select a product to access its auction.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void descriptionBttn_Click(object sender, EventArgs e)
        {
            if (ProdBuyerLV.SelectedItems.Count == 1)
            {
                ListViewItem item = ProdBuyerLV.SelectedItems[0];

                String productCode = item.SubItems[0].Text;
                String productName = item.SubItems[1].Text;
                String description = item.SubItems[3].Text;

                ReadFullDescription f = new ReadFullDescription(productCode, productName, description);
                f.Show();

            }
            else
            {
                MessageBox.Show("You need to choose a product to read its description.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool sellerHasReviews(String username)
        {
            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT COUNT(*) " +
                    "FROM ecommerce.VIEW_SELLER_RATING " +
                    "WHERE userName = @userName", con);

                cm1.Parameters.Add("@userName", SqlDbType.VarChar).Value = username;

                int qty_reviews = (int)cm1.ExecuteScalar();

                if (qty_reviews == 0)
                {

                    return false;
                }

                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
        }
}
