﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class MainMenu : Form
    {
        private const int AUCTION_EXPIRE_DELAY = 1000;

        public MainMenu()
        {
            InitializeComponent();

            ThreadStart childref = new ThreadStart(closeAuctions);
            Thread childThread = new Thread(childref);
            childThread.Start();
        }

        private static void closeAuctions()
        {
            while (true)
            {
                SqlConnection con = DbConnectionFactory.newConnection();

                try
                {
                    con.Open();
                    if (con.State == ConnectionState.Open)
                    {
                        SqlCommand cm1 = new SqlCommand("ecommerce.sp_Close_All_Expired_Auctions", con);
                        cm1.CommandType = CommandType.StoredProcedure;
                        cm1.ExecuteNonQuery();
                        //Console.WriteLine("Executing ecommerce.sp_Close_All_Expired_Auctions");
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

                Thread.Sleep(AUCTION_EXPIRE_DELAY);
            }
        }

        // Display new form Regular User Profiles
        private void profilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            RU_Profiles f = new RU_Profiles();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Accounts
        private void profilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Account f = new Account();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Admin Profiles
        private void profilesToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Admin_Profiles f = new Admin_Profiles();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Prod_Category
        private void productCategoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Prod_Category f = new Prod_Category();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Delivery_Companies
        private void deliveryCompaniesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Delivery_Comp f = new Delivery_Comp();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Product_Buyer
        private void buyerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Product_Buyer f = new Product_Buyer();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Product_Seller
        private void sellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Product_Seller f = new Product_Seller();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Closed_Auctions
        private void closedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Closed_Auctions f = new Closed_Auctions();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Open_Auctions
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Open_Auctions f = new Open_Auctions();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Stats for Delivery Companies
        private void deliveryCompaniesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Delivery_Stats f = new Delivery_Stats();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Stats for Product Categories
        private void productCategoriesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Cat_Stats f = new Cat_Stats();

            f.MdiParent = this;
            f.Show();
        }

        // Display new form Stats for Regular Users
        private void regularUsersToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            RU_Stats f = new RU_Stats();

            f.MdiParent = this;
            f.Show();
        }


        private void InternalOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            InternalOperation f = new InternalOperation();

            f.MdiParent = this;
            f.Show();
        }

        private void PaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Payments f = new Payments();

            f.MdiParent = this;
            f.Show();
        }

        private void completedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Completed_Reviews f = new Completed_Reviews();

            f.MdiParent = this;
            f.Show();
        }

        private void pendingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;

            Pending_Reviews f = new Pending_Reviews();

            f.MdiParent = this;
            f.Show();
        }
    }
}
