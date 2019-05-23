using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class CreditHistory : Form
    {
        public CreditHistory(int accountID)
        {
            InitializeComponent();
            accID_label.Text = accountID.ToString();
        }

        private void CreditHistory_Load(object sender, EventArgs e)
        {
            CreditlistView.Items.Clear();
            populateListView();
            generateTotalCredits();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.CREDIT WHERE accountID = @accountID", con);

                cm1.Parameters.Add("@accountID", SqlDbType.Int).Value = Convert.ToInt32(accID_label.Text);

                SqlDataReader rd1 = cm1.ExecuteReader();


                   while (rd1.Read())
                       {
                            ListViewItem item = new ListViewItem(rd1["creditID"].ToString());
                            item.SubItems.Add(rd1["amount"].ToString());
                            item.SubItems.Add(rd1["paymentCode"].ToString());
                            item.SubItems.Add(rd1["date"].ToString());

                            CreditlistView.Items.Add(item);
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

        private void generateTotalCredits()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT SUM(amount) FROM ecommerce.CREDIT WHERE accountID = @accountID", con);

                    cm1.Parameters.Add("@accountID", SqlDbType.Int).Value = Convert.ToInt32(accID_label.Text);

                    decimal sum_credits = (decimal)cm1.ExecuteScalar();

                    totalcred.Text = sum_credits.ToString();
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
