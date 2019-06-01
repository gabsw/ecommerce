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
    public partial class Pending_Reviews : Form
    {
        public Pending_Reviews()
        {
            InitializeComponent();
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

        private void addButton_Click_1(object sender, EventArgs e)
        {
            if (reviewsLV.SelectedItems.Count == 1)
            {
                ListViewItem item = reviewsLV.SelectedItems[0];

                String purchase_ID = item.SubItems[0].Text;
                String buyer_username = item.SubItems[2].Text;
                String seller_username = item.SubItems[3].Text;

                AddNewReview f1 = new AddNewReview(purchase_ID, buyer_username, seller_username);
                f1.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a purchase to review.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void clear_button_Click_1(object sender, EventArgs e)
        {
            sellerBox.Text = "";
            buyerBox.Text = "";
            purchaseBox.Text = "";
            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click_1(object sender, EventArgs e)
        {
            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
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
                    "AND Purchase_Completed LIKE @purchaseID " +
                    "AND Purchase_Associated_Review IS NULL", con);


                cm1.Parameters.AddWithValue("@Seller", usernameSeller);
                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@purchaseID", purchaseID_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["Purchase_Completed"].ToString());
                    item.SubItems.Add(rd1["Product_Code"].ToString());
                    item.SubItems.Add(rd1["Buyer_Username"].ToString());
                    item.SubItems.Add(rd1["Seller_Username"].ToString());

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

        private void populateBuyerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Buyer_Username FROM ecommerce.VIEW_REVIEW_DETAILS " +
                    "WHERE Purchase_Associated_Review IS NULL", con);

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

        private void populateSellerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Seller_Username FROM ecommerce.VIEW_REVIEW_DETAILS " +
                    "WHERE Purchase_Associated_Review IS NULL", con);

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

        private void Pending_Reviews_Load(object sender, EventArgs e)
        {
            sellerBox.Items.Clear();
            buyerBox.Items.Clear();
            purchaseBox.Items.Clear();
            reviewsLV.Items.Clear();
            populateSellerBox();
            populateBuyerBox();
            populatePurchaseWithoutReviewsBox();
            populateListView();
        }
    }
}
