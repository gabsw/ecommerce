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
    public partial class Read_Shipping_Details : Form
    {
        private int shippingCode;
        private String previousForm;

        public Read_Shipping_Details(int shippingCode, String previousForm)
        {
            InitializeComponent();
            this.shippingCode = shippingCode;
            this.previousForm = previousForm;
        }

        private void Read_Shipping_Details_Load(object sender, EventArgs e)
        {
            if (previousForm.Equals("Completed"))
            {
                loadCompletedInfo();
            }

            else
            {
                loadOngoingInfo();
            }
        }

        private void loadCompletedInfo()
        {
            String delivery_type = "";

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM " +
                        "ecommerce.VIEW_COMPLETED_SHIPPING WHERE Shipping_Code = @Shipping_Code", con);
                cm1.Parameters.Add("@Shipping_Code", SqlDbType.Int).Value = shippingCode;
                SqlDataReader rd1 = cm1.ExecuteReader();



                while (rd1.Read())
                {
                    purchID_lbl.Text = rd1["purchaseID"].ToString();
                    company_lbl.Text = rd1["Delivery_Company_Name"].ToString();
                    dispatch_lbl.Text = rd1["Dispatch_Date"].ToString();
                    estimated_lbl.Text = rd1["Estimated_Arrival_Date"].ToString();
                    official_lbl.Text = rd1["Official_Arrival_Date"].ToString();
                    buyer_user_lbl.Text = rd1["Buyer_username"].ToString();
                    buyer_name_lbl.Text = rd1["Buyer_Name"].ToString();
                    buyer_address_lbl.Text = rd1["Delivery_Address"].ToString();
                    seller_user_lbl.Text = rd1["Seller_username"].ToString();
                    seller_name_lbl.Text = rd1["Seller_Name"].ToString();
                    seller_address_lbl.Text = rd1["Dispatch_Address"].ToString();

                    bool hasExpressDelivery = (bool)rd1["hasExpressDelivery"];

                    delivery_type = hasExpressDelivery ? "Express" : "Regular";

                    delivery_lbl.Text = delivery_type;
                    code_lbl.Text = shippingCode.ToString();

                    status_lbl.Text = "Successfully Completed";
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

        private void loadOngoingInfo()
        {
            String delivery_type = "";

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM " +
                        "ecommerce.VIEW_ONGOING_SHIPPING WHERE Shipping_Code = @Shipping_Code", con);
                cm1.Parameters.Add("@Shipping_Code", SqlDbType.Int).Value = shippingCode;
                SqlDataReader rd1 = cm1.ExecuteReader();



                while (rd1.Read())
                {
                    purchID_lbl.Text = rd1["purchaseID"].ToString();
                    company_lbl.Text = rd1["Delivery_Company_Name"].ToString();
                    dispatch_lbl.Text = rd1["Dispatch_Date"].ToString();
                    estimated_lbl.Text = rd1["Estimated_Arrival_Date"].ToString();
                    official_lbl.Text = "None";
                    buyer_user_lbl.Text = rd1["Buyer_username"].ToString();
                    buyer_name_lbl.Text = rd1["Buyer_Name"].ToString();
                    buyer_address_lbl.Text = rd1["Delivery_Address"].ToString();
                    seller_user_lbl.Text = rd1["Seller_username"].ToString();
                    seller_name_lbl.Text = rd1["Seller_Name"].ToString();
                    seller_address_lbl.Text = rd1["Dispatch_Address"].ToString();

                    bool hasExpressDelivery = (bool)rd1["hasExpressDelivery"];

                    delivery_type = hasExpressDelivery ? "Express" : "Regular";

                    delivery_lbl.Text = delivery_type;
                    code_lbl.Text = shippingCode.ToString();

                    status_lbl.Text = "Order on its way";
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

        private void company_bttn_Click(object sender, EventArgs e)
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT name FROM " +
                        "ecommerce.DELIVERY_COMPANY JOIN ecommerce.SHIPPING " +
                        "ON ecommerce.DELIVERY_COMPANY.name = ecommerce.SHIPPING.deliveryCompany " +
                        "WHERE ecommerce.SHIPPING.Code = @Shipping_Code", con);
                cm1.Parameters.Add("@Shipping_Code", SqlDbType.Int).Value = shippingCode;
                SqlDataReader rd1 = cm1.ExecuteReader();

                rd1.Read();
                String delivery_company_name = rd1["name"].ToString();

                Delivery_Comp f = new Delivery_Comp(delivery_company_name);
                f.Show();


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
