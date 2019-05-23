using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class BidHistory : Form
    {
        private int auctionID;

        public BidHistory(int auctionID)
        {
            InitializeComponent();
            this.auctionID = auctionID;
            auctionID_label.Text = auctionID.ToString();

        }

        private void BidHistory_Load(object sender, System.EventArgs e)
        {
            BidLV.Items.Clear();
            populateListView();
            generateTotalBids();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.BID WHERE auctionID = @auctionID", con);

                    cm1.Parameters.Add("@auctionID", SqlDbType.Int).Value = auctionID;

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["bidID"].ToString());
                        item.SubItems.Add(rd1["Amount"].ToString());
                        item.SubItems.Add(rd1["userName_Buyer"].ToString());
                        item.SubItems.Add(rd1["Date"].ToString());

                        BidLV.Items.Add(item);
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

        private void generateTotalBids()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
               con.Open();

               SqlCommand cm1 = new SqlCommand("SELECT COUNT(*) FROM ecommerce.BID WHERE auctionID = @auctionID", con);

                cm1.Parameters.Add("@auctionID", SqlDbType.Int).Value = auctionID;

                int count_bids = (int)cm1.ExecuteScalar();

                totalbids_label.Text = count_bids.ToString();
                
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
