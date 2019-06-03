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
    public partial class Pending_Payment : Form
    {
        public Pending_Payment()
        {
            InitializeComponent();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            buyerBox.Text = "";
            purchaseBox.Text = "";
            payPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            payPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void Pending_Payment_Load(object sender, EventArgs e)
        {
            buyerBox.Items.Clear();
            purchaseBox.Items.Clear();
            payPendLV.Items.Clear();
            populateBuyerBox();
            populatePurchaseBox();
            populateListView();
        }

        private void buyerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            payPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void purchaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            payPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populateBuyerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Buyer_Username FROM ecommerce.VIEW_PENDING_PAYMENTS", con);

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
                SqlCommand cm1 = new SqlCommand("SELECT purchaseID FROM ecommerce.VIEW_PENDING_PAYMENTS", con);

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

            String usernameBuyer = buyerBox.Text;
            String purchaseID_str = purchaseBox.Text;

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

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.VIEW_PENDING_PAYMENTS " +
                    "WHERE Buyer_Username LIKE @Buyer " +
                    "AND purchaseID LIKE @purchaseID", con);

                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@purchaseID", purchaseID_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["purchaseID"].ToString());
                    item.SubItems.Add(rd1["Buyer_Username"].ToString());
                    item.SubItems.Add(rd1["Amount"].ToString());
                    item.SubItems.Add(rd1["Purchase_Date"].ToString());

                    payPendLV.Items.Add(item);
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

        private void payButton_Click(object sender, EventArgs e)
        {
            if (payPendLV.SelectedItems.Count == 1)
            {
                ListViewItem item = payPendLV.SelectedItems[0];

                int purchaseID = Convert.ToInt32(item.SubItems[0].Text);
                decimal amount = Convert.ToDecimal(item.SubItems[2].Text);

                Create_New_Payment f = new Create_New_Payment(purchaseID, amount);
                f.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a purchase to pay for.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            payPendLV.Items.Clear();
            populateListView();
            this.Refresh();
        }
    }
}
