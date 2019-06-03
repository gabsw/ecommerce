using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Cat_Stats : Form
    {
        public Cat_Stats()
        {
            InitializeComponent();
        }

        private void Cat_Stats_Load(object sender, System.EventArgs e)
        {
            cat_stats_lv.Items.Clear();
            executeCountQueries();
            populateListView();
        }

        private void executeCountQueries()
        {
            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                // Average No Sells Per Category
                SqlCommand cm1 = new SqlCommand("select count(*) / cast((select count(*) from ecommerce.product_category)" +
                    " as decimal) as 'Avg Sells Per Category' " +
                    "from ecommerce.PRODUCT pr " +
                    "where pr.[status] = 'Sold'", con);

                decimal avg_sells = (decimal)cm1.ExecuteScalar();

                avgSells.Text = avg_sells.ToString("F");

                // Average No Bids Per Category
                SqlCommand cm2 = new SqlCommand("select count(*) / cast((select count(*) from ecommerce.product_category)" +
                    " as decimal) as 'Avg Bids Per Category' " +
                    "from ecommerce.auction as au " +
                    "inner join ecommerce.product as pr on au.ProductCode = pr.Code " +
                    "inner join ecommerce.bid as bid on bid.auctionID = au.auctionID " +
                    "where pr.[status] = 'Sold'", con);

                decimal avg_bids = (decimal)cm2.ExecuteScalar();

                avgBids.Text = avg_bids.ToString("F");

                // Average No Auctions Per Category
                SqlCommand cm3 = new SqlCommand("select count(*) / cast((select count(*) from ecommerce.product_category)" +
                    " as decimal) as 'Avg Auctions Per Category' " +
                    "from ecommerce.auction", con);

                decimal avg_auctions = (decimal)cm3.ExecuteScalar();

                avgAuctions.Text = avg_auctions.ToString("F");

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

                String cmd = "select prc.Code As Code, prc.[name] As Name, max(bid.amount) as 'max sell', " +
                    "sum(bid.amount) as 'total sell', count(*) as 'total products sold', " +
                    "count(*) / cast((select count(*) from ecommerce.product where [status] = 'Sold') as decimal) as '% Sells', " +
                    "(select count(*) from ecommerce.bid as tBid join ecommerce.AUCTION tAu on tAu.auctionID = tBid.auctionID " +
                    "join ecommerce.PRODUCT tPr on tAu.ProductCode = tPr.Code where tPr.CategoryCode = prc.Code) / cast((select count(*) from ecommerce.bid) as decimal) as '% Bids' " +
                    "from ecommerce.product_category as prc join ecommerce.PRODUCT as pr on prc.Code = pr.CategoryCode " +
                    "join ecommerce.AUCTION as au on au.ProductCode = pr.Code " +
                    "join ecommerce.BID as bid on au.WinningBid = bid.bidID " +
                    "where pr.[status] = 'Sold' " +
                    "group by prc.Code, prc.Name " + getDisplayOrder();
       
                    SqlCommand cm1 = new SqlCommand(cmd, con);

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["Code"].ToString());
                        item.SubItems.Add(rd1["Name"].ToString());
                        item.SubItems.Add(rd1["max sell"].ToString());
                        item.SubItems.Add(rd1["total sell"].ToString());
                        item.SubItems.Add(rd1["total products sold"].ToString());

                        decimal percentage_sells = (decimal) rd1["% Sells"];
                        item.SubItems.Add(percentage_sells.ToString("F"));

                        decimal percentage_bids = (decimal)rd1["% Bids"];
                        item.SubItems.Add(percentage_bids.ToString("F"));

                        cat_stats_lv.Items.Add(item);


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
            if (highestSell_bttn.Checked)
            {
                return "ORDER BY 'max sell' DESC";
            }

            else if (totalSells_bttn.Checked)
            {
                return "ORDER BY 'total sell' DESC";
            }

            else if (PerSells_bttn.Checked)
            {
                return "ORDER BY '% Sells' DESC";
            }

            else if (PerBids_bttn.Checked)
            {
                return "ORDER BY '% Bids' DESC";
            }
            else
            {
                return "ORDER BY Code";
            }
        }

        private void code_bttn_CheckedChanged(object sender, EventArgs e)
        {
            cat_stats_lv.Items.Clear();;
            populateListView();
        }

        private void highestSell_bttn_CheckedChanged(object sender, EventArgs e)
        {
            cat_stats_lv.Items.Clear(); ;
            populateListView();
        }

        private void totalSells_bttn_CheckedChanged(object sender, EventArgs e)
        {
            cat_stats_lv.Items.Clear(); ;
            populateListView();
        }

        private void PerSells_bttn_CheckedChanged(object sender, EventArgs e)
        {
            cat_stats_lv.Items.Clear(); ;
            populateListView();
        }

        private void PerBids_bttn_CheckedChanged(object sender, EventArgs e)
        {
            cat_stats_lv.Items.Clear(); ;
            populateListView();
        }
    }
}
