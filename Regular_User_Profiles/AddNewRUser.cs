using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class AddNewRUser : Form
    {
        public AddNewRUser()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_text()
        {
            userNameBox.Text = "";
            fullNameBox.Text = "";
            emailBox.Text = "";
            passwordBox.Text = "";
            confPWBox.Text = "";
            TINBox.Text = "";
            addressBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String userName = userNameBox.Text;
            String name = fullNameBox.Text;
            String email = emailBox.Text;
            String password = passwordBox.Text;
            String password_confirmation = confPWBox.Text;
            String tin = TINBox.Text;
            String fullAddress = addressBox.Text;


            if (!FormValidation.validateUser(userName, name, email, password, password_confirmation, tin, fullAddress, false))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                // Check if username already exists
                SqlCommand cm1 = new SqlCommand("SELECT COUNT(*)" +
                    "FROM ecommerce.[USER]" +
                    "WHERE userName = @username", con);

                cm1.Parameters.Add("@userName", SqlDbType.VarChar).Value = userName;

                int qty_username = (int)cm1.ExecuteScalar();

                if (qty_username != 0)
                {
                    FormValidation.showError("The username you have chosen is already taken.");
                    return;
                }


                // Check if e-mail already exists
                SqlCommand cm2 = new SqlCommand("SELECT COUNT(*) " +
                    "FROM ecommerce.[USER] " +
                    "WHERE Email = @Email", con);

                cm2.Parameters.Add("@Email", SqlDbType.VarChar).Value = email;

                int qty_email = (int)cm2.ExecuteScalar();

                if (qty_email != 0)
                {
                    FormValidation.showError("The e-mail you have chosen is already in use.");
                    return;
                }

                SqlCommand cmd3 = new SqlCommand("ecommerce.sp_Create_Regular_User_Account", con);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@userName", userName);
                cmd3.Parameters.AddWithValue("@Name", name);
                cmd3.Parameters.AddWithValue("@Email", email);
                cmd3.Parameters.AddWithValue("@Password", password);
                cmd3.Parameters.AddWithValue("@Address", fullAddress);
                cmd3.Parameters.AddWithValue("@TIN", tin);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("You have added a new user!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
