using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.ACCOUNT", con);

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["accountID"].ToString());
                        item.SubItems.Add(rd1["userName"].ToString());
                        item.SubItems.Add(rd1["balance"].ToString());

                        AcclistView.Items.Add(item);


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

        private void Account_Load(object sender, EventArgs e)
        {
            AcclistView.Items.Clear();
            populateListView();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            AcclistView.Items.Clear();
            populateListView();
            this.Refresh();
        }

        // Display "New Debit" Form
        private void debitButton_Click(object sender, EventArgs e)
        {
            if (AcclistView.SelectedItems.Count == 1)
            {
                ListViewItem item = AcclistView.SelectedItems[0];

                int accountID = Convert.ToInt32(item.SubItems[0].Text);
                decimal balance = Convert.ToDecimal(item.SubItems[2].Text);

                NewDebit f1 = new NewDebit(accountID, balance);

                f1.Show();
            }

            else
            {
                MessageBox.Show("You need to choose an account from the list.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Display "DebitHistory" Form
        private void debButton_Click(object sender, EventArgs e)
        {
            String cm_str = "SELECT * FROM ecommerce.DEBIT WHERE accountID = @accountID";

            if (AcclistView.SelectedItems.Count == 1)
            {
                ListViewItem item = AcclistView.SelectedItems[0];
                int accountID = Convert.ToInt32(item.SubItems[0].Text);

                if (!AccountHasOperations(cm_str, accountID))
                {
                    MessageBox.Show("This account has no debits.", "Debit History", MessageBoxButtons.OK);

                }

                else
                {
                    DebitHistory f2 = new DebitHistory(accountID);
                    f2.Show();
                }

            }

            else
            {
                MessageBox.Show("You need to choose an account from the list.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Display "CreditHistory" Form
        private void credButton_Click(object sender, EventArgs e)
        {
            String cm_str = "SELECT * FROM ecommerce.CREDIT WHERE accountID = @accountID";


           if (AcclistView.SelectedItems.Count == 1)
            {
                ListViewItem item = AcclistView.SelectedItems[0];
                int accountID = Convert.ToInt32(item.SubItems[0].Text);

                if (!AccountHasOperations(cm_str, accountID))
                {
                    MessageBox.Show("This account has no credits.", "Credit History", MessageBoxButtons.OK);

                }

                else {
                    CreditHistory f3 = new CreditHistory(accountID);
                    f3.Show();
                }

            }

            else
            {
                MessageBox.Show("You need to choose an account from the list.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool AccountHasOperations(String command, int accountID)
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand(command, con);

                    cm1.Parameters.Add("@accountID", SqlDbType.Int).Value = accountID;

                    SqlDataReader rd1 = cm1.ExecuteReader();

                    if (rd1.HasRows)
                    {

                        return true;
                    }

                    return false;
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return false;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
