using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class DebitHistory : Form
    {
        public DebitHistory(int accountID)
        {
            InitializeComponent();
            accIDlabel.Text = accountID.ToString();
        }

        private void DebitHistory_Load(object sender, EventArgs e)
        {
            DebitHistlistView.Items.Clear();
            populateListView();
            generateTotalDebits();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.DEBIT WHERE accountID = @accountID", con);

                    cm1.Parameters.Add("@accountID", SqlDbType.Int).Value = Convert.ToInt32(accIDlabel.Text);

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["debitID"].ToString());
                        item.SubItems.Add(rd1["amount"].ToString());
                        item.SubItems.Add(rd1["IBAN"].ToString());
                        item.SubItems.Add(rd1["date"].ToString());

                        DebitHistlistView.Items.Add(item);


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

        private void generateTotalDebits()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT SUM(amount) FROM ecommerce.DEBIT WHERE accountID = @accountID", con);

                    cm1.Parameters.Add("@accountID", SqlDbType.Int).Value = Convert.ToInt32(accIDlabel.Text);

                    decimal sum_debits = (decimal)cm1.ExecuteScalar();

                    totaldeb.Text = sum_debits.ToString();
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
