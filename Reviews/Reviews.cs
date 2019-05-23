using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Reviews : Form
    {
        public Reviews()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (purchase2Box.Text == "")
            {
                MessageBox.Show("You need to choose a purchase with a pending review.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                // PRECISO DE FAZER DEBUG DESTA PARTE
                int purchase_ID = Convert.ToInt32(purchase2Box.Text);

                String buyer_username = getBuyer(purchase_ID);
                String seller_username = getSeller(purchase_ID);

                AddNewReview f1 = new AddNewReview(purchase_ID, buyer_username, seller_username);
                f1.Show();
            }

            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            sellerBox.Text = "";
            buyerBox.Text = "";
            purchaseBox.Text = "";
            purchase2Box.Text = "";
            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void Reviews_Load(object sender, EventArgs e)
        {
            sellerBox.Items.Clear();
            buyerBox.Items.Clear();
            purchaseBox.Items.Clear();
            purchase2Box.Items.Clear();
            reviewsLV.Items.Clear();
            populateSellerBox();
            populateBuyerBox();
            populateAllPurchaseBox();
            populatePurchaseWithoutReviewsBox();
            populateListView();
        }

        private void sellerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void buyerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void purchaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            reviewsLV.Items.Clear();
            purchase2Box.Text = "";
            populateListView();
            this.Refresh();
        }

        private void populateSellerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Seller_Username FROM ecommerce.VIEW_REVIEW_DETAILS", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    sellerBox.Items.Add(rd1["Seller_Username"].ToString());
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

        private void populateBuyerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Buyer_Username FROM ecommerce.VIEW_REVIEW_DETAILS", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    buyerBox.Items.Add(rd1["Buyer_Username"].ToString());
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

        private void populatePurchaseWithoutReviewsBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT Purchase_Completed FROM ecommerce.VIEW_REVIEW_DETAILS " +
                    "WHERE Purchase_Associated_Review IS NULL", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    purchaseBox.Items.Add(rd1["Purchase_Completed"].ToString());
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

        private void populateAllPurchaseBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT Purchase_Completed FROM ecommerce.VIEW_REVIEW_DETAILS", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    purchaseBox.Items.Add(rd1["Purchase_Completed"].ToString());
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

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            String usernameSeller = sellerBox.Text;
            String usernameBuyer = buyerBox.Text;
            String purchaseID_str = purchaseBox.Text;

            if (usernameSeller == "")
            {
                usernameSeller = "%";
            }

            if (usernameBuyer == "")
            {
                usernameBuyer = "%";
            }

            if (purchaseID_str == "")
            {
                purchaseID_str = "%";
            }

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.VIEW_REVIEW_DETAILS " +
                    "WHERE Seller_Username LIKE @Seller " +
                    "AND Buyer_Username LIKE @Buyer " +
                    "AND Purchase_Associated_Review LIKE @purchaseID", con);

                cm1.Parameters.AddWithValue("@Seller", usernameSeller);
                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@purchaseID", purchaseID_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["reviewID"].ToString());
                    item.SubItems.Add(rd1["Purchase_Associated_Review"].ToString());
                    item.SubItems.Add(rd1["Product_Code"].ToString());
                    item.SubItems.Add(rd1["Buyer_Username"].ToString());
                    item.SubItems.Add(rd1["Seller_Username"].ToString());
                    item.SubItems.Add(rd1["Rating"].ToString());
                    item.SubItems.Add(rd1["Date"].ToString());
                    item.SubItems.Add(rd1["Comment"].ToString());

                    reviewsLV.Items.Add(item);
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

        private void purchase2_SelectedIndexChanged(object sender, EventArgs e)
        {
            reviewsLV.Items.Clear();
            sellerBox.Items.Clear();
            buyerBox.Items.Clear();
            purchaseBox.Items.Clear();

            int purchase_ID = Convert.ToInt32(purchase2Box.Text);

            purchaseBox.Text = "";
            buyerBox.Text = getBuyer(purchase_ID);
            sellerBox.Text = getSeller(purchase_ID);
            this.Refresh();
        }

        private String getSeller(int purchaseID)
        {

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT Seller_Username FROM " +
                        "ecommerce.VIEW_REVIEW_DETAILS WHERE Purchase_Completed = @purchaseID", con);
                cm1.Parameters.Add("@purchaseID", SqlDbType.Int).Value = purchaseID;
                SqlDataReader rd1 = cm1.ExecuteReader();
                rd1.Read();
                return rd1["Seller_Username"].ToString();

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

        private String getBuyer(int purchaseID)
        {

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT Buyer_Username FROM " +
                        "ecommerce.VIEW_REVIEW_DETAILS WHERE Purchase_Completed = @purchaseID", con);
                cm1.Parameters.Add("@purchaseID", SqlDbType.Int).Value = purchaseID;
                SqlDataReader rd1 = cm1.ExecuteReader();
                rd1.Read();
                return rd1["Buyer_Username"].ToString();

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
    }
}
