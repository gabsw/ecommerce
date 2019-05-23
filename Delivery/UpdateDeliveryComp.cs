using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class UpdateDeliveryComp : Form
    {
        public UpdateDeliveryComp(String name, String phone, String address, Boolean expressDelivery)
        {
            InitializeComponent();
            nameLabel.Text = name;
            PhoneBox.Text = phone;
            AddressBox.Text = address;

            if (expressDelivery)
            {
                YesButton.Checked = true;
            }

            else
            {
                NoButton.Checked = true;
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_text()
        {
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
            String name = nameLabel.Text;
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

                SqlCommand cmd1 = new SqlCommand("ecommerce.sp_Update_DeliveryCompany", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@contactNumber", phone);
                cmd1.Parameters.AddWithValue("@address", address);
                cmd1.Parameters.AddWithValue("@hasExpressDelivery", hasExpressDelivery);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("You have updated a delivery company!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
