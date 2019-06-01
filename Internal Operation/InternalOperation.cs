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
            populateListView();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void RefreshButton_Click(object sender, EventArgs e)
         {
            InternalOperationLV.Items.Clear();
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
                    float total = 0F;
                    
                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["operationID"].ToString());
                        item.SubItems.Add(rd1["commission"].ToString());
                        item.SubItems.Add(rd1["collectedVAT"].ToString());
                        item.SubItems.Add(rd1["date"].ToString());
                        item.SubItems.Add(rd1["paymentCode"].ToString());

                        total += float.Parse(rd1["collectedVAT"].ToString());

                        InternalOperationLV.Items.Add(item);

                    }
                    labelTotalRows.Text = InternalOperationLV.Items.Count.ToString();
                    labelTotalVAT.Text = total.ToString();
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
