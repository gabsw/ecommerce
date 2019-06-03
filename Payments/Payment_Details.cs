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
    public partial class Payment_Details : Form
    {
        private int paymentCode;

        public Payment_Details(int paymentCode)
        {
            InitializeComponent();
            this.paymentCode = paymentCode;
        }

        private void Payment_Details_Load(object sender, EventArgs e)
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM " +
                        "ecommerce.VIEW_COMPLETED_PAYMENTS WHERE payment_code = @payment_code", con);
                cm1.Parameters.Add("@payment_code", SqlDbType.Int).Value = paymentCode;
                SqlDataReader rd1 = cm1.ExecuteReader();



                while (rd1.Read())
                {
                    labelPurchase.Text = rd1["purchaseID"].ToString();
                    labelUsername.Text = rd1["Buyer_Username"].ToString();
                    name_lbl.Text = rd1["Buyer_Name"].ToString();
                    labelAmount.Text = rd1["Amount"].ToString();
                    no_lbl.Text = rd1["CC_Number"].ToString();
                    cvc_lbl.Text = rd1["CC_CVC"].ToString();
                    expiry_lbl.Text = rd1["CC_Expiry_Date"].ToString();
                    billing_lbl.Text = rd1["Buyer_Address"].ToString();
                    label_date.Text = rd1["Payment_Date"].ToString();
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
