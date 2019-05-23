using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class AddNewCat : Form
    {
        public AddNewCat()
        {
            InitializeComponent();
        }

        private void clear_text()
        {
            NameBox.Text = "";
            VATBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int vat;
            try
            {
                vat = Convert.ToInt32(VATBox.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("VAT must be an integer.");
                return;
            }

            String name = NameBox.Text;


            if (!FormValidation.validateCategory(name, vat))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                // Check if name already exists
                SqlCommand cm1 = new SqlCommand("SELECT COUNT(*) " +
                    "FROM ecommerce.PRODUCT_CATEGORY " +
                    "WHERE Name = @Name", con);

                cm1.Parameters.Add("@Name", SqlDbType.VarChar).Value = name;

                int qty_name = (int)cm1.ExecuteScalar();

                if (qty_name != 0)
                {
                    FormValidation.showError("The name you have chosen is already taken.");
                    return;
                }

                SqlCommand cm2 = new SqlCommand("ecommerce.sp_CreateProductCategory", con);
                cm2.CommandType = CommandType.StoredProcedure;
                cm2.Parameters.AddWithValue("@Name", name);
                cm2.Parameters.AddWithValue("@VAT", vat);
                cm2.ExecuteNonQuery();

                MessageBox.Show("You have added a new category!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
