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
    public partial class Completed_Payment : Form
    {
        public Completed_Payment()
        {
            InitializeComponent();
        }

        private void Completed_Payment_Load(object sender, EventArgs e)
        {
            buyerBox.Items.Clear();
            purchaseBox.Items.Clear();
            payBox.Items.Clear();
            payCompLV.Items.Clear();
            populateBuyerBox();
            populatePurchaseWithPayBox();
            populatePayBox();
            populateListView();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            if (payCompLV.SelectedItems.Count == 1)
            {
                ListViewItem item = payCompLV.SelectedItems[0];

                int paymentCode = Convert.ToInt32(item.SubItems[0].Text);

                Payment_Details f = new Payment_Details(paymentCode);
                f.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a payment to open.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            payCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            buyerBox.Text = "";
            purchaseBox.Text = "";
            payCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            payCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void buyerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            payCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void purchaseBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            payCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            String usernameBuyer = buyerBox.Text;
            String purchaseID_str = purchaseBox.Text;
            String paymentCode_str = payBox.Text;

            if (usernameBuyer == "")
            {
                usernameBuyer = "%";
            }

            if (purchaseID_str == "")
            {
                purchaseID_str = "%";
            }

            if (paymentCode_str == "")
            {
                paymentCode_str = "%";
            }

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.VIEW_COMPLETED_PAYMENTS " +
                    "WHERE Buyer_Username LIKE @Buyer " +
                    "AND payment_code LIKE @payment_code " +
                    "AND purchaseID LIKE @purchaseID", con);

                cm1.Parameters.AddWithValue("@Buyer", usernameBuyer);
                cm1.Parameters.AddWithValue("@purchaseID", purchaseID_str);
                cm1.Parameters.AddWithValue("@payment_code", paymentCode_str);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["payment_code"].ToString());
                    item.SubItems.Add(rd1["purchaseID"].ToString());
                    item.SubItems.Add(rd1["Buyer_Username"].ToString());
                    item.SubItems.Add(rd1["Amount"].ToString());
                    item.SubItems.Add(rd1["Payment_Date"].ToString());

                    payCompLV.Items.Add(item);
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
                SqlCommand cm1 = new SqlCommand("SELECT DISTINCT Buyer_Username FROM ecommerce.VIEW_COMPLETED_PAYMENTS", con);

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

        private void populatePurchaseWithPayBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT purchaseID FROM ecommerce.VIEW_COMPLETED_PAYMENTS", con);

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

        private void payBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            payCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populatePayBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT payment_code FROM ecommerce.VIEW_COMPLETED_PAYMENTS", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    payBox.Items.Add(rd1["payment_code"].ToString());
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
