using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Admin_Profiles : Form
    {
        public Admin_Profiles()
        {
            InitializeComponent();
        }

        private void Admin_Profiles_Load(object sender, EventArgs e)
        {
            AdminListView.Items.Clear();
            populateListView();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddNewAdmin f1 = new AddNewAdmin();
            f1.Show();

            AdminListView.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (AdminListView.SelectedItems.Count == 1)
            {
                ListViewItem item = AdminListView.SelectedItems[0];

                String username = item.SubItems[0].Text;
                String name = item.SubItems[1].Text;
                String email = item.SubItems[2].Text;
                String password = item.SubItems[3].Text;
                String confirm_pw = password;

                UpdateAdmin f2 = new UpdateAdmin(username, name, email, password, confirm_pw);
                f2.Show();
            }
            else
            {
                MessageBox.Show("You need to choose an administrator from the list to update.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            AdminListView.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.[USER] AS us JOIN ecommerce.ADMIN AS ad ON us.userName = ad.userName ORDER BY us.userName", con);

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["userName"].ToString());
                        item.SubItems.Add(rd1["Name"].ToString());
                        item.SubItems.Add(rd1["Email"].ToString());
                        item.SubItems.Add(rd1["Password"].ToString());

                        AdminListView.Items.Add(item);

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
    }
}
