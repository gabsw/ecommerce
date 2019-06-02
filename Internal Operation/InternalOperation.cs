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
    public partial class InternalOperation : Form
    {
        public InternalOperation()
        {
            InitializeComponent();
        }
        private void InternalOperation_Load(object sender, EventArgs e)
        {
            InternalOperationLV.Items.Clear();
            commission_lbl.Text = getTotalCommission().ToString("F"); 
            labelTotalVAT.Text = getCollectedVAT().ToString("F");
            populateListView();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void RefreshButton_Click(object sender, EventArgs e)
         {
            InternalOperationLV.Items.Clear();
            getCollectedVAT();
            getTotalCommission();
            populateListView();
            this.Refresh();
         }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.INTERNAL_OPERATION", con);

                    SqlDataReader rd1 = cm1.ExecuteReader();
                    
                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["operationID"].ToString());
                        item.SubItems.Add(rd1["commission"].ToString());
                        item.SubItems.Add(rd1["collectedVAT"].ToString());
                        item.SubItems.Add(rd1["paymentCode"].ToString());
                        item.SubItems.Add(rd1["date"].ToString());

                        InternalOperationLV.Items.Add(item);

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

        private decimal getCollectedVAT()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT SUM(collectedVAT) FROM ecommerce.INTERNAL_OPERATION", con);
                return (decimal)cm1.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return -9999999;
            }
            finally
            {
                con.Close();
            }
        }

        private decimal getTotalCommission()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT SUM(commission) FROM ecommerce.INTERNAL_OPERATION", con);
                return (decimal)cm1.ExecuteScalar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return -9999999;
            }
            finally
            {
                con.Close();
            }
        }


    }
}
