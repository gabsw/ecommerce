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
    public partial class Create_New_Shipping : Form
    {
        private int purchaseID;

        public Create_New_Shipping(int purchaseID)
        {
            InitializeComponent();
            this.purchaseID = purchaseID;
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
            buyerAdBox.Text = "";
            sellerAdBox.Text = "";
            deliveryBox.Text = "";
            dispatch_date_dtp.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
          
            String delivery_company = deliveryBox.Text;
            String seller_address = sellerAdBox.Text;
            String buyer_address = buyerAdBox.Text;

            DateTime dispatchDate;
            DateTime estimatedArrivalDate;
            try
            {
                dispatchDate = Convert.ToDateTime(dispatch_date_dtp.Text);
                estimatedArrivalDate = dispatchDate.AddDays(7.0);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The dispatch date must comply with the format below.");
                return;
            }


            if (!FormValidation.validateShipping(purchaseID, delivery_company, seller_address, buyer_address,
                dispatchDate))
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
