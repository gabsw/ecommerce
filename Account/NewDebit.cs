using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class NewDebit : Form
    {

        private int accountID;
        private decimal balance;

        public NewDebit(int accountID, decimal balance)
        {
            InitializeComponent();

            accIDlabel.Text = accountID.ToString();
            currentBalancelbl.Text = balance.ToString();
            this.accountID = accountID;
            this.balance = balance;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clear_text()
        {
            debitBox.Text = "";
            ibanBox.Text = "";
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            decimal debitAmount;
            try
            {
                debitAmount = Convert.ToDecimal(debitBox.Text);
            }
            catch (Exception ex)
            {
                FormValidation.showError("The debit amount must be a number.");
                return;
            }

            String iban = ibanBox.Text;

            if (!FormValidation.validateDebit(debitAmount, iban))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
                return;
            }

            try
            {
                SqlCommand cmd3 = new SqlCommand("ecommerce.sp_Create_Debit", con);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@debitAmount", debitAmount);
                cmd3.Parameters.AddWithValue("@IBAN", iban);
                cmd3.Parameters.AddWithValue("@accountID", accountID);
                cmd3.ExecuteNonQuery();

                MessageBox.Show("You have performed a new debit!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Failed to make a new debit:\r\n" + ex.Message, "Failed Operation", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            clear_text();
            this.Close();
        }
    }


}


