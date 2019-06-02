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
    public partial class AddNewReview : Form
    {
        private String buyer;
        private String seller;
        private String purchaseID;

        public AddNewReview(String purchaseID, String buyer, String seller)
        {
            InitializeComponent();
            this.buyer = buyer;
            this.purchaseID = purchaseID;
            this.seller = seller;
            buyer_label.Text = buyer;
            purchase_label.Text = purchaseID.ToString();
            seller_label.Text = seller;
        }

        private void clear_text()
        {
            ratingBox.Text = "";
            CommentBox.Text = "";
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
            int rating;
            try
            {
                rating = Convert.ToInt32(ratingBox.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("Rating must be a number.");
                return;
            }

            if (!FormValidation.validateReview(rating, CommentBox.Text))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                SqlCommand cm2 = new SqlCommand("ecommerce.sp_Create_Review", con);
                cm2.CommandType = CommandType.StoredProcedure;
                cm2.Parameters.AddWithValue("@purchaseID", purchaseID);
                cm2.Parameters.AddWithValue("@Comment", CommentBox.Text);
                cm2.Parameters.AddWithValue("@Rating", rating);
                cm2.ExecuteNonQuery();

                MessageBox.Show("You have added a new review!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

