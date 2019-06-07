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
    public partial class Create_New_Payment : Form
    {
        private int purchaseID;
        private decimal amount;

        public Create_New_Payment(int purchaseID, decimal amount)
        {
            InitializeComponent();
            this.purchaseID = purchaseID;
            this.amount = amount;
        }

        private void clear_text()
        {
            billingBox.Text = "";
            noBox.Text = "";
            cvcBox.Text = "";
            expiry_date_dtp.Text = "";
            billingBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        private void Create_New_Payment_Load(object sender, EventArgs e)
        {
            populateFormDetails();
        }

        private void populateFormDetails()
        {
            labelPurchase.Text = purchaseID.ToString();
            labelAmount.Text = amount.ToString("F");

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM " +
                        "ecommerce.VIEW_PENDING_PAYMENTS WHERE purchaseID = @purchaseID", con);
                cm1.Parameters.Add("@purchaseID", SqlDbType.Int).Value = purchaseID;
                SqlDataReader rd1 = cm1.ExecuteReader();



                while (rd1.Read())
                {
                    labelUsername.Text = rd1["Buyer_username"].ToString();
                    name_lbl.Text = rd1["Buyer_Name"].ToString();
                    billingBox.Text = rd1["Possible_Billing_Address"].ToString();
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            String cc_no = noBox.Text;
            String cc_cvc = cvcBox.Text;
            String billing_address = billingBox.Text;

            DateTime expiry_date;
            try
            {
                expiry_date = Convert.ToDateTime(expiry_date_dtp.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The expiry date has formatting issues.");
                return;
            }


            if (!FormValidation.validatePayment(purchaseID, amount, billing_address,
            cc_no, cc_cvc, expiry_date))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("ecommerce.sp_Create_Payment", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@billingAddress", billing_address);
                cmd.Parameters.AddWithValue("@creditCardCVC", cc_cvc);
                cmd.Parameters.AddWithValue("@amount", amount);
                cmd.Parameters.AddWithValue("@creditCardNo", cc_no);
                cmd.Parameters.AddWithValue("@creditCardExpiryDate", expiry_date);
                cmd.Parameters.AddWithValue("@purchaseID", purchaseID);
                cmd.ExecuteNonQuery();

             
                MessageBox.Show("You have made a new payment!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            clear_text();
            this.Close();
        }

        
    }
}
