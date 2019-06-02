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
    public partial class Fill_Purchase : Form
    {
        private int auctionID;
        private decimal VAT_Record;
        private bool hasExpressDelivery;
        private String Buyer_Name_Record;
        private String Buyer_TIN_Record;
        private String Seller_Name_Record;
        private String Seller_TIN_Record;
        private decimal finalPrice;
        private decimal bidAmount;

        public Fill_Purchase(int auctionID)
        {
            InitializeComponent();
            this.auctionID = auctionID;
        }

        private void Fill_Purchase_Load(object sender, EventArgs e)
        {
            auction_lbl.Text = auctionID.ToString();

            priceVAT.Text = getVAT_Amount(auctionID).ToString();

            expressBttn.Checked = false;
            regularBttn.Checked = true;

            finalPrice = getFinalPrice(auctionID, false);

            finalprice_lbl.Text = finalPrice.ToString();

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM " +
                        "ecommerce.VIEW_PENDING_PURCHASES WHERE Auction_Without_Purchase = @auctionID", con);
                cm1.Parameters.Add("@auctionID", SqlDbType.Int).Value = auctionID;
                SqlDataReader rd1 = cm1.ExecuteReader();



                while (rd1.Read())
                {
                    name_lbl.Text = rd1["ProductName"].ToString();
                    code_lbl.Text = rd1["ProductCode"].ToString();
             
               
                    buyer_user_lbl.Text = rd1["username_buyer"].ToString();
                    seller_user_lbl.Text = rd1["username_seller"].ToString();

                    VAT_Record = (decimal)rd1["VAT_Product"];
                    vat_lbl.Text = VAT_Record.ToString();

                    bidAmount = (decimal)rd1["Final_Amount"];
                    bid_lbl.Text = bidAmount.ToString();

                    Buyer_Name_Record = rd1["Name_buyer"].ToString();
                    buyerNameTxtBox.Text = Buyer_Name_Record;

                    Buyer_TIN_Record = rd1["TIN_buyer"].ToString();
                    buyerTINTxtBox.Text = Buyer_TIN_Record;

                    Seller_Name_Record = rd1["Name_Seller"].ToString();
                    sellerNameTxtBox.Text = Seller_Name_Record;

                    Seller_TIN_Record = rd1["TIN_Seller"].ToString();
                    sellerTINTxtBox.Text = Seller_TIN_Record;
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clearText();
        }

        private void clearText()
        {
            buyerNameTxtBox.Text = "";
            buyerTINTxtBox.Text = "";
            sellerNameTxtBox.Text = "";
            sellerTINTxtBox.Text = "";
            expressBttn.Checked = false;
            regularBttn.Checked = true;
            finalprice_lbl.Text = getFinalPrice(auctionID, false).ToString();


        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Buyer_Name_Record = buyerNameTxtBox.Text;
            Seller_Name_Record = sellerNameTxtBox.Text;
            Buyer_TIN_Record = buyerTINTxtBox.Text;
            Seller_TIN_Record = sellerTINTxtBox.Text;

            hasExpressDelivery = expressBttn.Checked ? true : false;

            finalPrice = getFinalPrice(auctionID, hasExpressDelivery);


            if (!FormValidation.validatePurchase(finalPrice, VAT_Record, hasExpressDelivery,
                auctionID, Buyer_Name_Record, Buyer_TIN_Record, Seller_Name_Record, Seller_TIN_Record))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                SqlCommand cmd1 = new SqlCommand("ecommerce.sp_Create_Purchase", con);

                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.AddWithValue("@amount", finalPrice);
                cmd1.Parameters.AddWithValue("@VAT_Record", VAT_Record);
                cmd1.Parameters.AddWithValue("@hasExpressDelivery", hasExpressDelivery);
                cmd1.Parameters.AddWithValue("@auctionID", auctionID);
                cmd1.Parameters.AddWithValue("@Buyer_Name_Record", Buyer_Name_Record);
                cmd1.Parameters.AddWithValue("@Buyer_TIN_Record", Buyer_TIN_Record);
                cmd1.Parameters.AddWithValue("@Seller_Name_Record", Seller_Name_Record);
                cmd1.Parameters.AddWithValue("@Seller_TIN_Record", Seller_Name_Record);


                cmd1.ExecuteNonQuery();

                MessageBox.Show("You have made a new purchase!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            clearText();
            this.Close();
        }

        private decimal getVAT_Amount(int auctionID)
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT " +
                    "ecommerce.UDF_CALC_VAT_AMOUNT (@auctionID) ", con);
                cm1.Parameters.AddWithValue("@auctionID", auctionID);

                return (decimal) cm1.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return -9999;
            }
            finally
            {
                con.Close();
            }
        }

        private decimal getFinalPrice(int auctionID, bool hasExpressDelivery)
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT " +
                    "ecommerce.UDF_CALC_PURCHASE_AMOUNT (@auctionID, @HAS_EXPRESS_DELIVERY) ", con);
                cm1.Parameters.AddWithValue("@auctionID", auctionID);
                cm1.Parameters.AddWithValue("@HAS_EXPRESS_DELIVERY", hasExpressDelivery);

                return (decimal)cm1.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return -9999;
            }
            finally
            {
                con.Close();
            }
        }

        private void expressBttn_CheckedChanged(object sender, EventArgs e)
        {
            hasExpressDelivery = expressBttn.Checked ? true : false;
            finalPrice = getFinalPrice(auctionID, hasExpressDelivery);
            finalprice_lbl.Text = finalPrice.ToString();
            this.Refresh();
        
        }

        private void regularBttn_CheckedChanged(object sender, EventArgs e)
        {
            hasExpressDelivery = regularBttn.Checked ? false : true;
            finalPrice = getFinalPrice(auctionID, hasExpressDelivery);
            finalprice_lbl.Text = finalPrice.ToString();
            this.Refresh();
        }
    }
}
