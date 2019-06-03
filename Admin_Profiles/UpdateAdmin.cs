using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class UpdateAdmin : Form
    {
        public UpdateAdmin(String username, String name, String email, String password,
            String confirm_pw)
        {
            InitializeComponent();
            labelUser.Text = username;
            fullNameBox.Text = name;
            emailBox.Text = email;
            passwordBox.Text = password;
            confPWBox.Text = confirm_pw;
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
            fullNameBox.Text = "";
            emailBox.Text = "";
            passwordBox.Text = "";
            confPWBox.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String userName = labelUser.Text;
            String name = fullNameBox.Text;
            String email = emailBox.Text;
            String password = passwordBox.Text;
            String password_confirmation = confPWBox.Text;


            // Form validation
            if (!FormValidation.validateAdmin(userName, name, email, password, password_confirmation, true))
            {
                return;
            }


            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                // Check if e-mail already exists
                SqlCommand cm1 = new SqlCommand("SELECT COUNT(*)" +
                "FROM ecommerce.[USER]" +
                "WHERE Email = @Email AND userName != @userName", con);

                cm1.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;
                cm1.Parameters.Add("@userName", SqlDbType.VarChar).Value = labelUser.Text;

                int qty_email = (int)cm1.ExecuteScalar();

                if (qty_email != 0)
                {
                    FormValidation.showError("The e-mail you have chosen is already in use.");
                    return;
                }

                SqlCommand cmd3 = new SqlCommand("ecommerce.sp_Update_Admin", con);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@userName", userName);
                cmd3.Parameters.AddWithValue("@Name", name);
                cmd3.Parameters.AddWithValue("@Email", email);
                cmd3.Parameters.AddWithValue("@Password", password);
                cmd3.ExecuteNonQuery();


                MessageBox.Show("You have updated an admin!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
