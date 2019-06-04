using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class UpdateCat : Form
    {
        private int code;
        public UpdateCat(int code, String name, decimal vat)
        {
            InitializeComponent();
            name_label.Text = name;
            VATBox.Text = vat.ToString();
            this.code = code;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        private void clear_text()
        {
            VATBox.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            decimal vat;
            try
            {
                vat = Convert.ToDecimal(VATBox.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("VAT must be a decimal.");
                return;
            }


            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                if (vat < 0)
                {
                    FormValidation.showError("VAT must be a positive decimal.");
                    return;
                }
                
                SqlCommand cm2 = new SqlCommand("ecommerce.sp_Update_Product_Category", con);
                cm2.CommandType = CommandType.StoredProcedure;
                cm2.Parameters.AddWithValue("@Code", code);
                cm2.Parameters.AddWithValue("@VAT", vat);
                cm2.ExecuteNonQuery();


                MessageBox.Show("You have updated a category!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
