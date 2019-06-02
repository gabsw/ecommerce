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
    public partial class Shipping : Form
    {
        public Shipping()
        {
            InitializeComponent();
        }

        private void Shipping_Load(object sender, EventArgs e)
        {
            ShippingLV.Items.Clear();
            populateListView();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.SHIPPING", con);

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["code"].ToString());
                        item.SubItems.Add(rd1["deliveryCompany"].ToString());
                        item.SubItems.Add(rd1["dispatchDate"].ToString());
                        item.SubItems.Add(rd1["estimatedArrivalDate"].ToString());
                        item.SubItems.Add(rd1["officialArrivalDate"].ToString());
                        item.SubItems.Add(rd1["purchaseID"].ToString());
                        item.SubItems.Add(rd1["reference"].ToString());
                        item.SubItems.Add(rd1["dispatch_address"].ToString());
                        item.SubItems.Add(rd1["delivery_address"].ToString());

                        ShippingLV.Items.Add(item);

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

        private void CloseButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
