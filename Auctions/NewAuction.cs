using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class NewAuction : Form
    {
        private int code;
        private string username_Seller;

        public NewAuction(int code, string username_Seller)
        {
            InitializeComponent();
            this.code = code;
            this.username_Seller = username_Seller;
            product_code_label.Text = code.ToString();
            seller_label.Text = username_Seller;
        }

        private void cancelButton_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void clear_text()
        {
            bidBox.Text = "";
            beginning_dtp.Text = "";
            finish_dtp.Text = "";
        }

        private void clearButton_Click(object sender, System.EventArgs e)
        {
            clear_text();
        }

        private void submitButton_Click(object sender, System.EventArgs e)
        {
            decimal minBidAmount;

            try
            {
                minBidAmount = Convert.ToDecimal(bidBox.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The bid amount must be a number.");
                return;
            }

            DateTime begDate;
            try
            {
                begDate = Convert.ToDateTime(beginning_dtp.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The beginning date must comply with the format below.");
                return;
            }

            DateTime finishDate;
            try
            {
                finishDate = Convert.ToDateTime(finish_dtp.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The finish date must comply with the format below.");
                return;
            }

            if (!FormValidation.validateAuction(minBidAmount, begDate, finishDate))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("ecommerce.sp_Create_Auction", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductCode", code);
                cmd.Parameters.AddWithValue("@BeginningDate", begDate);
                cmd.Parameters.AddWithValue("@FinishDate", finishDate);
                cmd.Parameters.AddWithValue("@MinimumBid", minBidAmount);
                cmd.ExecuteNonQuery();

                MessageBox.Show("You have created a new auction!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
