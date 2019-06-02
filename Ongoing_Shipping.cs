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
    public partial class Ongoing_Shipping : Form
    {
        public Ongoing_Shipping()
        {
            InitializeComponent();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            sellerBox.Text = "";
            buyerBox.Text = "";
            purchaseBox.Text = "";
            deliveryBox.Text = "";
            shippingONLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            shippingONLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void Ongoing_Shipping_Load(object sender, EventArgs e)
        {
            sellerBox.Items.Clear();
            buyerBox.Items.Clear();
            purchaseBox.Items.Clear();
            deliveryBox.Items.Clear();
            shippingONLV.Items.Clear();
            populateSellerBox();
            populateBuyerBox();
            populateDeliveryBox();
            populatePurchaseBox();
            populateListView();
        }

        private void sellerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shippingONLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void buyerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shippingONLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void purchaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shippingONLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void deliveryBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            shippingONLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populateSellerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Seller_Username FROM ecommerce.VIEW_ONGOING_SHIPPING", con);

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
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Buyer_Username FROM ecommerce.VIEW_ONGOING_SHIPPING", con);

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
                SqlCommand cm1 = new SqlCommand("SELECT purchaseID FROM ecommerce.VIEW_ONGOING_SHIPPING", con);

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

        private void populateDeliveryBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Delivery_Company_Name FROM ecommerce.VIEW_ONGOING_SHIPPING", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    deliveryBox.Items.Add(rd1["Delivery_Company_Name"].ToString());
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
            String delivery_company = deliveryBox.Text;

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

            if (delivery_company == "")
            {
                delivery_company = "%";
            }

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.VIEW_ONGOING_SHIPPING " +
                    "WHERE Seller_Username LIKE @Seller " +
                    "AND Buyer_Username LIKE @Buyer " +
                    "AND Delivery_Company_Name LIKE @Delivery " +
                    "AND purchaseID LIKE @purchaseID", con);

                cm1.Parameters.AddWithValue("@Seller", usernameSeller);
                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@Delivery", delivery_company);
                cm1.Parameters.AddWithValue("@purchaseID", purchaseID_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["Shipping_Code"].ToString());
                    item.SubItems.Add(rd1["purchaseID"].ToString());
                    item.SubItems.Add(rd1["Buyer_Username"].ToString());
                    item.SubItems.Add(rd1["Seller_Username"].ToString());
                    item.SubItems.Add(rd1["Delivery_Company_Name"].ToString());
                    item.SubItems.Add(rd1["Estimated_Arrival_Date"].ToString());

                    shippingONLV.Items.Add(item);
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

        private void readButton_Click(object sender, EventArgs e)
        {
            if (shippingONLV.SelectedItems.Count == 1)
            {
                ListViewItem item = shippingONLV.SelectedItems[0];

                int shippingCode = Convert.ToInt32(item.SubItems[0].Text);

                Read_Shipping_Details f = new Read_Shipping_Details(shippingCode);
                f.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a shipping to open.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            shippingONLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (shippingONLV.SelectedItems.Count == 1)
            {
                ListViewItem item = shippingONLV.SelectedItems[0];

                int shippingCode = Convert.ToInt32(item.SubItems[0].Text);

                Fill_Official_Arrival_Date f = new Fill_Official_Arrival_Date(shippingCode);
                f.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a shipping to complete.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            shippingONLV.Items.Clear();
            populateListView();
            this.Refresh();
        }
    }
    
    
}
