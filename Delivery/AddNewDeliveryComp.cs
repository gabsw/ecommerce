using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class AddNewDeliveryComp : Form
    {
        public AddNewDeliveryComp()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_text()
        {
            NameBox.Text = "";
            PhoneBox.Text = "";
            AddressBox.Text = "";
            NoButton.Checked = false;
            YesButton.Checked = false;

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String name = NameBox.Text;
            String phone = PhoneBox.Text;
            String address = AddressBox.Text;
            Boolean hasExpressDelivery;

            if (YesButton.Checked)
            {
                hasExpressDelivery = true;
            }
            else if (NoButton.Checked)
            {
                hasExpressDelivery = false;
            }
            else
            {
                FormValidation.showError("You have to check if the company provides express delivery.");
                return;
            }


            if (!FormValidation.validateDeliveryCompany(name, phone, address, hasExpressDelivery))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                // Check if name already exists
                SqlCommand cm1 = new SqlCommand("SELECT COUNT(*) " +
                    "FROM ecommerce.DELIVERY_COMPANY " +
                    "WHERE name = @name", con);

                cm1.Parameters.Add("@name", SqlDbType.VarChar).Value = name;

                int qty_name = (int)cm1.ExecuteScalar();

                if (qty_name != 0)
                {
                    FormValidation.showError("This company has already been registered.");
                    return;
                }

                SqlCommand cm2 = new SqlCommand("ecommerce.sp_CreateDeliveryCompany", con);
                cm2.CommandType = CommandType.StoredProcedure;
                cm2.Parameters.AddWithValue("@name", name);
                cm2.Parameters.AddWithValue("@contactNumber", phone);
                cm2.Parameters.AddWithValue("@address", address);
                cm2.Parameters.AddWithValue("@hasExpressDelivery ", hasExpressDelivery);
                cm2.ExecuteNonQuery();

                MessageBox.Show("You have added a new delivery company!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
