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
    public partial class Pending_Shipping : Form
    {
        public Pending_Shipping()
        {
            InitializeComponent();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            sellerBox.Text = "";
            buyerBox.Text = "";
            purchaseBox.Text = "";
            shipPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            shipPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void Pending_Shipping_Load(object sender, EventArgs e)
        {
            sellerBox.Items.Clear();
            buyerBox.Items.Clear();
            purchaseBox.Items.Clear();
            shipPendLV.Items.Clear();
            populateSellerBox();
            populateBuyerBox();
            populatePurchaseBox();
            populateListView();
        }

        private void sellerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shipPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void buyerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shipPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void purchaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shipPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populateSellerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Seller_Username FROM ecommerce.VIEW_PENDING_SHIPPING", con);

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
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Buyer_Username FROM ecommerce.VIEW_PENDING_SHIPPING", con);

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


        private void populatePurchaseBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT purchaseID FROM ecommerce.VIEW_PENDING_SHIPPING", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    purchaseBox.Items.Add(rd1["purchaseID"].ToString());
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

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.VIEW_PENDING_SHIPPING " +
                    "WHERE Seller_Username LIKE @Seller " +
                    "AND Buyer_Username LIKE @Buyer " +
                    "AND purchaseID LIKE @purchaseID", con);

                cm1.Parameters.AddWithValue("@Seller", usernameSeller);
                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@purchaseID", purchaseID_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["purchaseID"].ToString());
                    item.SubItems.Add(rd1["Buyer_Username"].ToString());
                    item.SubItems.Add(rd1["Seller_Username"].ToString());

                    shipPendLV.Items.Add(item);
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

        private void completeButton_Click(object sender, EventArgs e)
        {
            if (shipPendLV.SelectedItems.Count == 1)
            {
                ListViewItem item = shipPendLV.SelectedItems[0];

                int purchaseID = Convert.ToInt32(item.SubItems[0].Text);

                bool hasExpressDelivery = getDeliveryType(purchaseID);

                Create_New_Shipping f = new Create_New_Shipping(purchaseID, hasExpressDelivery);
                f.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a shipping to fill.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            shipPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private bool getDeliveryType(int purchaseID)
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT hasExpressDelivery " +
                    "FROM ecommerce.VIEW_PENDING_SHIPPING " +
                    "WHERE purchaseID = @purchaseID", con);
                cm1.Parameters.Add("@purchaseID", SqlDbType.Int).Value = purchaseID;

                SqlDataReader rd1 = cm1.ExecuteReader();
                rd1.Read();

                return (bool)rd1["hasExpressDelivery"];

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
