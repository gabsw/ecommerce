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
    public partial class Fill_Official_Arrival_Date : Form
    {
        private int shippingCode;

        public Fill_Official_Arrival_Date(int shippingCode)
        {
            InitializeComponent();
            this.shippingCode = shippingCode;
        }

        private void Fill_Official_Arrival_Date_Load(object sender, EventArgs e)
        {
            shippingCode_lbl.Text = shippingCode.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            arrival_date_dtp.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            DateTime official_arrival_date;
           
            try
            {
                official_arrival_date = Convert.ToDateTime(arrival_date_dtp.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The date has formatting issues.");
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("ecommerce.sp_Update_Official_Arrival_Date", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@code", shippingCode);
                cmd.Parameters.AddWithValue("@officialArrivalDate", official_arrival_date);
      
                cmd.ExecuteNonQuery();

                MessageBox.Show("You have ordered a new shipping!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            this.Close();
        }
    }
}
