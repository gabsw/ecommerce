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
    public partial class Completed_Purchase : Form
    {
        public Completed_Purchase()
        {
            InitializeComponent();
        }

        private void Completed_Purchase_Load(object sender, EventArgs e)
        {
            sellerBox.Items.Clear();
            buyerBox.Items.Clear();
            auctionBox.Items.Clear();
            purchCompLV.Items.Clear();
            populateSellerBox();
            populateBuyerBox();
            populateAuctionWithPurchasesBox();
            populateListView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (purchCompLV.SelectedItems.Count == 1)
            {
                ListViewItem item = purchCompLV.SelectedItems[0];

                int purchaseID = Convert.ToInt32(item.SubItems[0].Text);

                Purchase_Details f = new Purchase_Details(purchaseID);
                f.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a purchase to open.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            purchCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            sellerBox.Text = "";
            buyerBox.Text = "";
            auctionBox.Text = "";
            purchCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            purchCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void sellerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void buyerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void auctionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            String usernameSeller = sellerBox.Text;
            String usernameBuyer = buyerBox.Text;
            String auctionID_str = auctionBox.Text;

            if (usernameSeller == "")
            {
                usernameSeller = "%";
            }

            if (usernameBuyer == "")
            {
                usernameBuyer = "%";
            }

            if (auctionID_str == "")
            {
                auctionID_str = "%";
            }

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.VIEW_COMPLETED_PURCHASES " +
                    "WHERE Seller_Username LIKE @Seller " +
                    "AND Buyer_Username LIKE @Buyer " +
                    "AND auctionID LIKE @auctionID", con);


                cm1.Parameters.AddWithValue("@Seller", usernameSeller);
                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@auctionID", auctionID_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["auctionID"].ToString());
                    item.SubItems.Add(rd1["Product_Code"].ToString());
                    item.SubItems.Add(rd1["Buyer_Username"].ToString());
                    item.SubItems.Add(rd1["Seller_Username"].ToString());
                    item.SubItems.Add(rd1["Purchase_Final_Price"].ToString());

                    purchCompLV.Items.Add(item);
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
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Buyer_Username FROM ecommerce.VIEW_COMPLETED_PURCHASES", con);

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
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Seller_Username FROM ecommerce.VIEW_COMPLETED_PURCHASES", con);

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

        private void populateAuctionWithPurchasesBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT auctionID FROM ecommerce.VIEW_COMPLETED_PURCHASES", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    auctionBox.Items.Add(rd1["auctionID"].ToString());
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

    }
}
