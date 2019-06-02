using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Product_Seller : Form
    {
        private bool searchButtonWasClicked = false;
        private int productCode;

        public Product_Seller()
        {
            InitializeComponent();
        }

        public Product_Seller(int productCode)
        {
            InitializeComponent();
            this.productCode = productCode;
        }

        private void addNewButton_Click(object sender, EventArgs e)
        {
            AddNewProduct f1 = new AddNewProduct();
            f1.Show();

            ProdSellerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (ProdSellerLV.SelectedItems.Count == 1)
            {
                ListViewItem item = ProdSellerLV.SelectedItems[0];

                int code = Convert.ToInt32(item.SubItems[0].Text);
                String product_name = item.SubItems[1].Text;
                String category_name = item.SubItems[2].Text;
                String description = item.SubItems[3].Text;
                
                if (getStatus(code) == "Available")
                {
                    UpdateProduct f2 = new UpdateProduct(code, product_name, category_name, description);
                    f2.Show();
                }

                else
                {
                    MessageBox.Show("You need to choose an available product to update.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You need to choose a product to update.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            productCode = 0;
            ProdSellerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            String usernameSeller = sellerBox.Text;
            String status = getCheckedButton();
            String search_keywords = "";
            String code = "%";

            if (searchButtonWasClicked)
            {
                search_keywords = searchBox.Text;
            }

            if (usernameSeller == "")
            {
                usernameSeller = "%";
            }

            if (status == "All")
            {
                status = "%";
            }

            if (productCode > 0)
            {
                code = productCode.ToString();
            }

            if (!FormValidation.validateSearch(search_keywords))
            {
                return;
            }

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * " +
                    "FROM ecommerce.UDF_SEARCH_PRODUCT_SELLER (@Keywords, @Status, @usernameSeller, @Code)", con);  

                cm1.Parameters.AddWithValue("@Keywords", search_keywords);
                cm1.Parameters.AddWithValue("@Status", status);
                cm1.Parameters.AddWithValue("@usernameSeller", usernameSeller);
                cm1.Parameters.AddWithValue("@Code", code);

                SqlDataReader rd1 = cm1.ExecuteReader();
               

                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["Code"].ToString());
                    item.SubItems.Add(rd1["Product_Name"].ToString());

                    String seller_username = rd1["username_Seller"].ToString();
                    item.SubItems.Add(seller_username);

                    String seller_rating = rd1["rating_Seller"].ToString();

                    if (sellerHasReviews(seller_username))
                    {
                        item.SubItems.Add(seller_rating);
                    }

                    else
                    {
                        item.SubItems.Add("Not Rated");
                    }

                    item.SubItems.Add(rd1["Status"].ToString()); 
                    item.SubItems.Add(rd1["Category_Name"].ToString());
                    item.SubItems.Add(rd1["Description"].ToString());

                    ProdSellerLV.Items.Add(item);
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


        private void Product_Seller_Load(object sender, EventArgs e)
        {
            sellerBox.Items.Clear();
            ProdSellerLV.Items.Clear();
            populateComboBox();
            allButton.Checked = true;
            populateListView();
        }

        private void auctionButton_CheckedChanged(object sender, EventArgs e)
        {
            searchBox.Text = "";
            ProdSellerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void availableButton_CheckedChanged(object sender, EventArgs e)
        {
            searchBox.Text = "";
            ProdSellerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void soldButton_CheckedChanged(object sender, EventArgs e)
        {
            searchBox.Text = "";
            ProdSellerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private String getCheckedButton()
        {
            if (auctionButton.Checked)
            {
                return "Auction";
            }

            else if (availableButton.Checked)
            {
                return "Available";
            }

            else if (soldButton.Checked)
            {
                return "Sold";
            }

            else
            {
                return "All";
            }
        }

        private void sellerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProdSellerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populateComboBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                    SqlCommand cm1 = new SqlCommand("SELECT DISTINCT username_Seller FROM ecommerce.VIEW_PRODUCT_DETAILS", con);

                    SqlDataReader rd1 = cm1.ExecuteReader();

                    while (rd1.Read())
                    {
                        sellerBox.Items.Add(rd1["username_Seller"].ToString());
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

        private String getStatus(int code)
        {

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT Status FROM ecommerce.PRODUCT WHERE Code = @Code", con);
                cm1.Parameters.Add("@Code", SqlDbType.Int).Value = code;
                SqlDataReader rd1 = cm1.ExecuteReader();
                rd1.Read();
                return rd1["Status"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return "";
            }
            finally
            {
                con.Close();
            }
        }

        private String getSeller(int code)
        {

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT userName_Seller FROM " +
                        "ecommerce.PRODUCT WHERE Code = @Code", con);
                cm1.Parameters.Add("@Code", SqlDbType.Int).Value = code;
                SqlDataReader rd1 = cm1.ExecuteReader();
                rd1.Read();
                return rd1["userName_Seller"].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return "";
            }
            finally
            {
                con.Close();
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            if (ProdSellerLV.SelectedItems.Count == 1)
            {
                ListViewItem item = ProdSellerLV.SelectedItems[0];

                int code = Convert.ToInt32(item.SubItems[0].Text);
                String usernameSeller = getSeller(code);

                if (getStatus(code) == "Available")
                {
                    NewAuction f = new NewAuction(code, usernameSeller);
                    f.Show();
                }

                else
                {
                    MessageBox.Show("You need to choose an available product to sell.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You need to choose a product to sell.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            sellerBox.Text = "";
            searchBox.Text = "";
            allButton.Checked = true;
            ProdSellerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            searchButtonWasClicked = true;
            ProdSellerLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void auctionbttn_Click(object sender, EventArgs e)
        {
            if (ProdSellerLV.SelectedItems.Count == 1)
            {
                ListViewItem item = ProdSellerLV.SelectedItems[0];

                int productCode = Convert.ToInt32(item.SubItems[0].Text);


                if (getStatus(productCode) == "Auction")
                {
                    Open_Auctions f = new Open_Auctions(productCode);
                    f.Show();
                }

                else if (getStatus(productCode) == "Sold")
                {
                    Closed_Auctions f = new Closed_Auctions(productCode);
                    f.Show();
                }


                else if (hasAuctionHistory(productCode))
                {
                    Closed_Auctions f = new Closed_Auctions(productCode);
                    f.Show();
                }

                else
                {
                    MessageBox.Show("This product does not have an auction history.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("You need to select a product to access its auction.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool hasAuctionHistory(int product_code_bids)
        {
            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                // Check if auction already exists
                SqlCommand cm1 = new SqlCommand("SELECT COUNT(*) " +
                    "FROM ecommerce.AUCTION " +
                    "WHERE ProductCode = @ProductCode", con);

                cm1.Parameters.Add("@ProductCode", SqlDbType.Int).Value = product_code_bids;

                int qty_auctions = (int)cm1.ExecuteScalar();

                if (qty_auctions == 0)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProdSellerLV.SelectedItems.Count == 1)
            {
                ListViewItem item = ProdSellerLV.SelectedItems[0];

                String productCode = item.SubItems[0].Text;
                String productName = item.SubItems[1].Text;
                String description = item.SubItems[6].Text;

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
