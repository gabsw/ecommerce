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
    public partial class Purchase_Details : Form
    {
        private int purchaseID;
        public Purchase_Details(int purchaseID)
        {
            InitializeComponent();
            this.purchaseID = purchaseID;
        }

        private void Purchase_Details_Load(object sender, EventArgs e)
        {
            
            String delivery = "";

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM " +
                        "ecommerce.VIEW_COMPLETED_PURCHASES WHERE purchaseID = @purchaseID", con);
                cm1.Parameters.Add("@purchaseID", SqlDbType.Int).Value = purchaseID;
                SqlDataReader rd1 = cm1.ExecuteReader();



                while (rd1.Read())
                {
                    price_lbl.Text = rd1["Purchase_Final_Price"].ToString();
                    date_lbl.Text = rd1["Purchase_Date"].ToString();
                    name_lbl.Text = rd1["Product_Name"].ToString();
                    code_lbl.Text = rd1["Product_Code"].ToString();
                    vat_lbl.Text = rd1["VAT_Record"].ToString();
                    bid_lbl.Text = rd1["winningAmount"].ToString();
                    auction_lbl.Text = rd1["auctionID"].ToString();
                    buyer_user_lbl.Text = rd1["Buyer_Username"].ToString();
                    buyer_name_lbl.Text = rd1["Buyer_Name_Record"].ToString();
                    buyer_tin_lbl.Text = rd1["Buyer_TIN_Record"].ToString();
                    seller_user_lbl.Text = rd1["Seller_Username"].ToString();
                    seller_name_lbl.Text = rd1["Seller_Name_Record"].ToString();
                    seller_tin_lbl.Text = rd1["Seller_TIN_Record"].ToString();

                    bool hasExpressDelivery = (bool)rd1["expressDelivery"];

                    delivery = hasExpressDelivery ? "Yes - 15€" : "No";

                    delivery_lbl.Text = delivery;
                    purchID_lbl.Text = purchaseID.ToString();
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

    }
}
