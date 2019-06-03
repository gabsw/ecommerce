using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class RU_Profiles : Form
    {
        public RU_Profiles()
        {
            InitializeComponent();
        }

        // Display "Add New" Form
        private void button1_Click(object sender, EventArgs e)
        {
            AddNewRUser f1 = new AddNewRUser();
            f1.Show();

            listViewRU.Items.Clear();
            populateListView();
            this.Refresh();
        }

        // Display "Update" Form
        private void button2_Click(object sender, EventArgs e)
        {
            if (listViewRU.SelectedItems.Count == 1)
            {
                ListViewItem item = listViewRU.SelectedItems[0];

                String username = item.SubItems[0].Text;
                String name = item.SubItems[1].Text;
                String email = item.SubItems[2].Text;
                String password = "";
                String confirm_pw = "";
                String TIN = item.SubItems[3].Text;
                String fullAddress = item.SubItems[4].Text;

                UpdateRUser f2 = new UpdateRUser(username, name, email, password, confirm_pw, TIN,
                    fullAddress);
                f2.Show();
            }
            else
            {
                MessageBox.Show("You need to choose an user from the list to update.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Fill listview with data from the tables User and Regular_User
        private void RU_Profiles_Load_1(object sender, EventArgs e)
        {
            listViewRU.Items.Clear();
            populateListView();
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.[USER] AS us JOIN ecommerce.REGULAR_USER AS ru ON us.userName = ru.userName ORDER BY us.userName", con);

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["userName"].ToString());
                        item.SubItems.Add(rd1["Name"].ToString());
                        item.SubItems.Add(rd1["Email"].ToString());
                        item.SubItems.Add(rd1["TIN"].ToString());
                        item.SubItems.Add(rd1["Address"].ToString());

                        listViewRU.Items.Add(item);


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



        private void button3_Click(object sender, EventArgs e)
        {
            listViewRU.Items.Clear();
            populateListView();
            this.Refresh();
        }
    }
}