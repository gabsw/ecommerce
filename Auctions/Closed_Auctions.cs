using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Closed_Auctions : Form
    {
        int product_code;
        public Closed_Auctions()
        {
            InitializeComponent();
        }

        public Closed_Auctions(int product_code)
        {
            InitializeComponent();
            this.product_code = product_code;
        }

        private void bidHistory_Click(object sender, System.EventArgs e)
        {
            if (ClosedAuctionLV.SelectedItems.Count == 1)
            {
                ListViewItem item = ClosedAuctionLV.SelectedItems[0];

                int auctionID = Convert.ToInt32(item.SubItems[0].Text);

                BidHistory f = new BidHistory(auctionID);
                f.Show();
            }

            else
            {
                MessageBox.Show("You need to select an auction to view its bid history.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String getDisplayOrder()
        {
            if (high_bid_bttn.Checked)
            {
                return "ORDER BY winningAmount DESC";
            }

            else if (low_bid_bttn.Checked)
            {
                return "ORDER BY winningAmount";
            }

            else
            {
                return "ORDER BY auctionID";
            }
        }

        private void auctionID_bttn_CheckedChanged(object sender, EventArgs e)
        {
            ClosedAuctionLV.Items.Clear();
            populateListView();
        }

        private void high_bid_bttn_CheckedChanged(object sender, EventArgs e)
        {
            ClosedAuctionLV.Items.Clear();
            populateListView();
        }

        private void low_bid_bttn_CheckedChanged(object sender, EventArgs e)
        {
            ClosedAuctionLV.Items.Clear();
            populateListView();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            String order = getDisplayOrder();

            String pcode = "%";

            if (product_code > 0)
            {
                pcode = product_code.ToString();
            }

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT auctionID, Product_Code, userName_Winner, " +
                                                "winningAmount, BeginningDate, FinishDate " +
                                                "FROM ecommerce.VIEW_AUCTION_DETAILS AS AD " +
                                                "JOIN ecommerce.VIEW_WINNING_BID AS WN " +
                                                "ON AD.auctionID = WN.auction_ID " +
                                                "WHERE Status = 0 " +
                                                "AND Product_Code LIKE @Product_Code " +
                                                order, con);
                cm1.Parameters.Add("@Product_Code", SqlDbType.VarChar).Value = pcode;

                SqlDataReader rd1 = cm1.ExecuteReader();


                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["auctionID"].ToString());
                    item.SubItems.Add(rd1["Product_Code"].ToString());
                    item.SubItems.Add(rd1["userName_Winner"].ToString());
                    item.SubItems.Add(rd1["winningAmount"].ToString());
                    item.SubItems.Add(rd1["BeginningDate"].ToString());
                    item.SubItems.Add(rd1["FinishDate"].ToString());

                    ClosedAuctionLV.Items.Add(item);
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

        private void Closed_Auctions_Load(object sender, EventArgs e)
        {
            auctionID_bttn.Checked = true;
            ClosedAuctionLV.Items.Clear();
            populateListView();
        }

        private void product_info_bttn_Click(object sender, EventArgs e)
        {
            if (ClosedAuctionLV.SelectedItems.Count == 1)
            {
                ListViewItem item = ClosedAuctionLV.SelectedItems[0];

                int productCode = Convert.ToInt32(item.SubItems[1].Text);

                Product_Seller f = new Product_Seller(productCode);
                f.Show();
            }

            else
            {
                MessageBox.Show("You need to select an auction to view its product info.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            product_code = 0;
            ClosedAuctionLV.Items.Clear();
            populateListView();
            this.Refresh();
        }
    }
}
