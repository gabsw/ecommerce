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
    public partial class Pending_Purchase : Form
    {
        public Pending_Purchase()
        {
            InitializeComponent();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            sellerBox.Text = "";
            buyerBox.Text = "";
            auctionBox.Text = "";
            purchPendingLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            purchPendingLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (purchPendingLV.SelectedItems.Count == 1)
            {
                ListViewItem item = purchPendingLV.SelectedItems[0];

                int auctionID = Convert.ToInt32(item.SubItems[0].Text);

                Fill_Purchase f = new Fill_Purchase(auctionID);
                f.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a purchase to complete.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            purchPendingLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void Pending_Purchase_Load(object sender, EventArgs e)
        {
            sellerBox.Items.Clear();
            buyerBox.Items.Clear();
            auctionBox.Items.Clear();
            purchPendingLV.Items.Clear();
            populateSellerBox();
            populateBuyerBox();
            populateAuctionWithoutPurchasesBox();
            populateListView();
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

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.VIEW_PENDING_PURCHASES " +
                    "WHERE username_seller LIKE @Seller " +
                    "AND username_buyer LIKE @Buyer " +
                    "AND Auction_Without_Purchase LIKE @auctionID", con);


                cm1.Parameters.AddWithValue("@Seller", usernameSeller);
                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@auctionID", auctionID_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["Auction_Without_Purchase"].ToString());
                    item.SubItems.Add(rd1["ProductCode"].ToString());
                    item.SubItems.Add(rd1["username_buyer"].ToString());
                    item.SubItems.Add(rd1["username_seller"].ToString());

                    purchPendingLV.Items.Add(item);
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
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT username_buyer FROM ecommerce.VIEW_PENDING_PURCHASES", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    buyerBox.Items.Add(rd1["username_buyer"].ToString());
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
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT username_seller FROM ecommerce.VIEW_PENDING_PURCHASES", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    sellerBox.Items.Add(rd1["username_seller"].ToString());
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

        private void populateAuctionWithoutPurchasesBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT Auction_Without_Purchase FROM ecommerce.VIEW_PENDING_PURCHASES", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    auctionBox.Items.Add(rd1["Auction_Without_Purchase"].ToString());
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

        private void sellerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchPendingLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void buyerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchPendingLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void auctionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            purchPendingLV.Items.Clear();
            populateListView();
            this.Refresh();
        }
    }
}
