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
    public partial class Completed_Reviews : Form
    {
        public Completed_Reviews()
        {
            InitializeComponent();
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
            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void Reviews_Load(object sender, EventArgs e)
        {
            sellerBox.Items.Clear();
            buyerBox.Items.Clear();
            purchaseBox.Items.Clear();
            reviewsLV.Items.Clear();
            populateSellerBox();
            populateBuyerBox();
            populateAllPurchaseBox();
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
            populateListView();
            this.Refresh();
        }

        private void populateSellerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Seller_Username FROM ecommerce.VIEW_COMPLETED_REVIEWS", con);

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
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Buyer_Username FROM ecommerce.VIEW_COMPLETED_REVIEWS", con);

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

        
        private void populateAllPurchaseBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT Purchase FROM ecommerce.VIEW_COMPLETED_REVIEWS", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    purchaseBox.Items.Add(rd1["Purchase"].ToString());
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

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.VIEW_COMPLETED_REVIEWS " +
                    "WHERE Seller_Username LIKE @Seller " +
                    "AND Buyer_Username LIKE @Buyer " +
                    "AND Purchase LIKE @purchaseID", con);

                cm1.Parameters.AddWithValue("@Seller", usernameSeller);
                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@purchaseID", purchaseID_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["reviewID"].ToString());
                    item.SubItems.Add(rd1["Purchase"].ToString());
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

        private void OpenReview_Click(object sender, EventArgs e)
        {
            if (reviewsLV.SelectedItems.Count == 1)
            {
                ListViewItem item = reviewsLV.SelectedItems[0];

                String reviewID = item.SubItems[0].Text;
                String purchaseID = item.SubItems[1].Text;
                String productCode = item.SubItems[2].Text;
                String buyer = item.SubItems[3].Text;
                String seller = item.SubItems[4].Text;
                String rating = item.SubItems[5].Text;
                String date = item.SubItems[6].Text;
                String comment = item.SubItems[7].Text;

                ReadReview f = new ReadReview(reviewID, purchaseID, buyer, seller,
                    productCode, rating, comment, date);
                f.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a review to open.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            reviewsLV.Items.Clear();
            populateListView();
            this.Refresh();
        }
    }
}
