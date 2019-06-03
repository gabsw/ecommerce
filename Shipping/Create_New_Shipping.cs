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
        private bool hasExpressDelivery;

        public Create_New_Shipping(int purchaseID, bool hasExpressDelivery)
        {
            InitializeComponent();
            this.purchaseID = purchaseID;
            this.hasExpressDelivery = hasExpressDelivery;
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
            estimated_date_lbl.Text = "";
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
                estimatedArrivalDate = get_Estimated_Arrival_Date(dispatchDate, hasExpressDelivery);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The dispatch date must comply with the format below.");
                return;
            }


            if (!FormValidation.validateShipping(purchaseID, delivery_company, seller_address, buyer_address,
                dispatchDate, estimatedArrivalDate))
                {
                    return;
                }

                SqlConnection con = DbConnectionFactory.newConnection();
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("ecommerce.sp_Create_Shipping", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@deliveryCompany", delivery_company);
                    cmd.Parameters.AddWithValue("@dispatchDate", dispatchDate);
                    cmd.Parameters.AddWithValue("@estimatedArrivalDate", estimatedArrivalDate);
                    cmd.Parameters.AddWithValue("@purchaseID", purchaseID);
                    cmd.Parameters.AddWithValue("@dispatch_address", seller_address);
                    cmd.Parameters.AddWithValue("@delivery_address", buyer_address);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("You have ordered a new shipping!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Create_New_Shipping_Load(object sender, EventArgs e)
        {
            populateDeliveryBox();
            populateFormDetails();
        }

        private void populateFormDetails()
        {
            estimated_date_lbl.Text = "";

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM " +
                        "ecommerce.VIEW_PENDING_SHIPPING WHERE purchaseID = @purchaseID", con);
                cm1.Parameters.Add("@purchaseID", SqlDbType.Int).Value = purchaseID;
                SqlDataReader rd1 = cm1.ExecuteReader();



                while (rd1.Read())
                {
                    buyer_user_lbl.Text = rd1["Buyer_username"].ToString();
                    buyer_name_lbl.Text = rd1["Buyer_Name"].ToString();
                    buyerAdBox.Text = rd1["Buyer_Address"].ToString();
                    sellerAdBox.Text = rd1["Seller_Address"].ToString();
                    seller_user_lbl.Text = rd1["Seller_username"].ToString();
                    seller_name_lbl.Text = rd1["Seller_Name"].ToString();

                    bool hasExpressDelivery = (bool)rd1["hasExpressDelivery"];

                    if (hasExpressDelivery)
                    {
                        type_delivery_lbl.Text = "Express";
                    }
                    else
                    {
                        type_delivery_lbl.Text = "Regular";
                    }
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

        private void populateDeliveryBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT name FROM ecommerce.DELIVERY_COMPANY" +
                    " WHERE hasExpressDelivery = @hasExpressDelivery", con);
                cm1.Parameters.Add("@hasExpressDelivery", SqlDbType.Bit).Value = hasExpressDelivery;

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    deliveryBox.Items.Add(rd1["name"].ToString());
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

        

        private void dispatch_date_dtp_ValueChanged(object sender, EventArgs e)
        {
            DateTime dispatchDate = Convert.ToDateTime(dispatch_date_dtp.Text);
            estimated_date_lbl.Text = get_Estimated_Arrival_Date(dispatchDate, hasExpressDelivery).ToLongDateString();
        }

        private DateTime get_Estimated_Arrival_Date(DateTime dispatch_date, bool hasExpressDelivery)
        {
            try
            {
                dispatch_date = Convert.ToDateTime(dispatch_date_dtp.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The dispatch date has formatting issues.");

            }

            if (hasExpressDelivery)
            {
                return dispatch_date.AddDays(2.0);
            }

            else
            {
                return dispatch_date.AddDays(7.0);
            }
        }
    }
}
