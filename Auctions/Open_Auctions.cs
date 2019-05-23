using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Open_Auctions : Form
    {
        private int product_code;

        public Open_Auctions()
        {
            InitializeComponent();
        }

        public Open_Auctions(int product_code)
        {
            InitializeComponent();
            this.product_code = product_code;
        }

        private void Open_Auctions_Load(object sender, System.EventArgs e)
        {
            auctionID_bttn.Checked = true;
            OpenAuctionLV.Items.Clear();
            populateListView();
            populateBuyerBox();
        }

        private void bidButton_Click(object sender, System.EventArgs e)
        {

            if (OpenAuctionLV.SelectedItems.Count == 1)
            {
                ListViewItem item = OpenAuctionLV.SelectedItems[0];

                int auctionID = Convert.ToInt32(item.SubItems[0].Text);
                int productCode = Convert.ToInt32(item.SubItems[1].Text);

                if (buyerBox.Text != "")
                {
                    if (buyerBox.Text != getSeller(productCode))
                    {
                        String username_Buyer = buyerBox.Text;
                        Bid f = new Bid(auctionID, productCode, username_Buyer);
                        f.Show();
                    }

                    else
                    {
                        MessageBox.Show("You cannot place a bid on a product that you are selling.", "Error alert",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else 
                {
                    MessageBox.Show("You need to select a buyer to place a bid.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You need to select an auction to place a bid.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private String getSeller(int code)
        {

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();

                SqlCommand cm1 = new SqlCommand("SELECT userName_Seller FROM " +
                        "ecommerce.PRODUCT WHERE Code = @Code", con);
                cm1.Parameters.Add("@Code", SqlDbType.Int).Value = code;
                SqlDataReader rd1 = cm1.ExecuteReader();
                rd1.Read();
                return rd1["userName_Seller"].ToString();

      
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return "";
            }
            finally
            {
                con.Close();
            }
        }

        private String getDisplayOrder()
        {
            if (high_bid_bttn.Checked)
            {
                return "ORDER BY Min_Valid_Bid DESC";
            }

            else if (low_bid_bttn.Checked)
            {
                return "ORDER BY Min_Valid_Bid";
            }

            else if (finishDate_bttn.Checked)
            {
                return "ORDER BY FinishDate";
            }

            else if (product_code_bttn.Checked)
            {
                return "ORDER BY Product_Code";
            }
            else
            {
                return "ORDER BY auctionID"; 
            }
        }

        private void auctionID_bttn_CheckedChanged(object sender, EventArgs e)
        {
            OpenAuctionLV.Items.Clear();
            populateListView();
        }

        private void product_code_bttn_CheckedChanged(object sender, EventArgs e)
        {
            OpenAuctionLV.Items.Clear();
            populateListView();
        }

        private void high_bid_bttn_CheckedChanged(object sender, EventArgs e)
        {
            OpenAuctionLV.Items.Clear();
            populateListView();
        }

        private void low_bid_bttn_CheckedChanged(object sender, EventArgs e)
        {
            OpenAuctionLV.Items.Clear();
            populateListView();
        }

        private void finishDate_bttn_CheckedChanged(object sender, EventArgs e)
        {
            OpenAuctionLV.Items.Clear();
            populateListView();
        }

        private void populateBuyerBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm1 = new SqlCommand("SELECT userName FROM ecommerce.REGULAR_USER", con);

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {

                    buyerBox.Items.Add(rd1["userName"].ToString());
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

                String query = "SELECT mvb.auctionID, Product_Code, Product_Name, " +
                               "userName_Winner, Min_Valid_Bid, FinishDate, Seller " +
                               "FROM ecommerce.VIEW_MIN_VALID_BID AS mvb " +
                               "JOIN ecommerce.VIEW_AUCTION_DETAILS AS ad " +
                               "ON mvb.auctionID = ad.auctionID " +
                               "LEFT OUTER JOIN ecommerce.VIEW_WINNING_BID AS wb " +
                               "ON ad.auctionID = wb.auction_ID " +
                               "WHERE Product_Code LIKE @Product_Code " + order;

                SqlCommand cm1 = new SqlCommand(query, con);

                cm1.Parameters.Add("@Product_Code", SqlDbType.VarChar).Value = pcode;

                SqlDataReader rd1 = cm1.ExecuteReader();

                while (rd1.Read())
                {
                    ListViewItem item = new ListViewItem(rd1["auctionID"].ToString());
                    item.SubItems.Add(rd1["Product_Code"].ToString());
                    item.SubItems.Add(rd1["Product_Name"].ToString());
                    item.SubItems.Add(rd1["userName_Winner"].ToString());
                    item.SubItems.Add(rd1["Min_Valid_Bid"].ToString());
                    item.SubItems.Add(rd1["FinishDate"].ToString());
                    item.SubItems.Add(rd1["Seller"].ToString());

                    OpenAuctionLV.Items.Add(item);
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

        private void product_info_bttn_Click(object sender, EventArgs e)
        {
            if (OpenAuctionLV.SelectedItems.Count == 1)
            {
                ListViewItem item = OpenAuctionLV.SelectedItems[0];

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
            OpenAuctionLV.Items.Clear();
            populateListView();
            this.Refresh();
        }
    }
}
