using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class RU_Stats : Form
    {
        public RU_Stats()
        {
            InitializeComponent();
        }

        private void RU_Stats_Load(object sender, EventArgs e)
        {
            ru_stats_LV.Items.Clear();
            executeCountQueries();
            populateListView();
        }

        private void executeCountQueries()
        {
            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                // Average No Sells Per User
                SqlCommand cm1 = new SqlCommand("select count(*) / cast((select count(*) from ecommerce.regular_user) as decimal)" +
                    " as 'avg sells per user' " +
                    "from ecommerce.product as pr " +
                    "where pr.[status] = 'Sold'", con);

                decimal avg_sells = (decimal)cm1.ExecuteScalar();

                avgSells.Text = avg_sells.ToString("F");

                // Average No Bids Per User
                SqlCommand cm2 = new SqlCommand("select count(*) / cast((select count(*) from ecommerce.regular_user) as decimal) " +
                    " as 'avg bids per user' " +
                    "from ecommerce.bid", con);

                decimal avg_bids = (decimal)cm2.ExecuteScalar();

                avgBids.Text = avg_bids.ToString("F");

                // Average Seller Rating
                SqlCommand cm3 = new SqlCommand("select avg(cast(avgRating as decimal)) " +
                    "from ecommerce.VIEW_SELLER_RATING", con);

                decimal avg_rating = (decimal)cm3.ExecuteScalar();

                avgRating.Text = avg_rating.ToString("F");

                // % of users that made a bid
                SqlCommand cm4 = new SqlCommand("select count(distinct bid.userName_Buyer) / cast((select count(*) from ecommerce.regular_user) as decimal) " +
                    "as '% of users that made a bid' from ecommerce.bid as bid", con);

                decimal per_bids = (decimal)cm4.ExecuteScalar();

                per_bids_lbl.Text = per_bids.ToString("F");

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

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                String cmd = "select u.userName As username, " +
                    "(select avgRating from ecommerce.VIEW_SELLER_RATING where userName = u.userName) as 'Seller_Rating', " +
                    "(select count(*) from ecommerce.product where userName_Seller = u.userName and [status] = 'Sold') as 'total sold', " +
                    "(select count(*) from ecommerce.view_winning_bid where userName_Winner = u.userName) as 'total won', " +
                    "(select count(*) from ecommerce.bid where userName_buyer = u.username) as 'total bids', " +
                    "(select count(*) from ecommerce.view_winning_bid where userName_Winner = u.userName) / cast((select count(*) from ecommerce.product where [status] = 'Sold') as decimal) as '% auctions won' " +
                    "from ecommerce.regular_user as u " + getDisplayOrder();

                SqlCommand cm1 = new SqlCommand(cmd, con);

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["username"].ToString());
                    item.SubItems.Add(rd1["Seller_Rating"].ToString());
                    item.SubItems.Add(rd1["total sold"].ToString());
                    item.SubItems.Add(rd1["total won"].ToString());
                    item.SubItems.Add(rd1["total bids"].ToString());

                    decimal percentage_auctions_won = (decimal)rd1["% auctions won"];
                    item.SubItems.Add(percentage_auctions_won.ToString("F"));

                    ru_stats_LV.Items.Add(item);


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

        private String getDisplayOrder()
        {
            if (sellerRating_bttn.Checked)
            {
                return "ORDER BY 'Seller_Rating' DESC";
            }

            else if (totalSells_bttn.Checked)
            {
                return "ORDER BY 'total sold' DESC";
            }

            else if (totalBuys_bttn.Checked)
            {
                return "ORDER BY 'total won' DESC";
            }

            else if (totalBids_bttn.Checked)
            {
                return "ORDER BY 'total bids' DESC";
            }
            else if (perAuction_bttn.Checked)
            {
                return "ORDER BY '% auctions won' DESC";
            }
            else
            {
                return "ORDER BY username";
            }
        }

        private void sellerRating_bttn_CheckedChanged(object sender, EventArgs e)
        {
            ru_stats_LV.Items.Clear(); ;
            populateListView();
        }

        private void totalSells_bttn_CheckedChanged(object sender, EventArgs e)
        {
            ru_stats_LV.Items.Clear(); ;
            populateListView();
        }

        private void totalBuys_bttn_CheckedChanged(object sender, EventArgs e)
        {
            ru_stats_LV.Items.Clear(); ;
            populateListView();
        }

        private void totalBids_bttn_CheckedChanged(object sender, EventArgs e)
        {
            ru_stats_LV.Items.Clear(); ;
            populateListView();
        }

        private void perAuction_bttn_CheckedChanged(object sender, EventArgs e)
        {
            ru_stats_LV.Items.Clear(); ;
            populateListView();
        }
    }
}
