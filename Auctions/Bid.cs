using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Bid : Form
    {
        private int auctionID;
        private int productCode;
        private string username_Buyer;

        public Bid(int auctionID, int productCode, string username_Buyer)
        {
            InitializeComponent();
            this.auctionID = auctionID;
            this.productCode = productCode;
            this.username_Buyer = username_Buyer;

            auction_label.Text = auctionID.ToString();
            product_code_label.Text = productCode.ToString();
            buyer_label.Text = username_Buyer;
            min_bid_label.Text = getMinValidBid(auctionID).ToString();
        }

        public decimal getMinValidBid(int auctionID)
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                String query = "SELECT Min_Valid_Bid " +
                               "FROM ecommerce.VIEW_MIN_VALID_BID " +
                               "WHERE auctionID = @auctionID";

                SqlCommand cm1 = new SqlCommand(query, con);

                cm1.Parameters.Add("@auctionID", SqlDbType.Int).Value = auctionID;
                SqlDataReader rd1 = cm1.ExecuteReader();
                rd1.Read();
                return Convert.ToDecimal(rd1["Min_Valid_Bid"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return -1;
            }
            finally
            {
                con.Close();
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            bidBox.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            decimal bidAmount;
            try
            {
                bidAmount = Convert.ToDecimal(bidBox.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The bid amount must be a number.");
                return;
            }

            if (!FormValidation.validateBid(bidAmount))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                // Check if bid is greater or equal to minimum valid bid 

                if (bidAmount < getMinValidBid(auctionID))
                {
                    FormValidation.showError("The amount must equal or greater than the minimum valid bid.");
                    return;
                }

                SqlCommand cmd1 = new SqlCommand("ecommerce.sp_Create_Bid", con);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@auctionID", auctionID);
                cmd1.Parameters.AddWithValue("@Amount", bidAmount);
                cmd1.Parameters.AddWithValue("@userName_Buyer", username_Buyer);
                cmd1.ExecuteNonQuery();

                MessageBox.Show("You have placed a new bid!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            bidBox.Text = "";
            this.Close();
        }
    }
}
