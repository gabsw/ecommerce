using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Prod_Category : Form
    {
        public Prod_Category()
        {
            InitializeComponent();
        }

        private void Prod_Category_Load(object sender, EventArgs e)
        {
            Cat_ListView.Items.Clear();
            populateListView();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            AddNewCat f1 = new AddNewCat();
            f1.Show();

            Cat_ListView.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            Cat_ListView.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (Cat_ListView.SelectedItems.Count == 1)
            {
                ListViewItem item = Cat_ListView.SelectedItems[0];

                int code = Convert.ToInt32(item.SubItems[0].Text);
                String name = item.SubItems[1].Text;
                int vat = Convert.ToInt32(item.SubItems[2].Text);

                UpdateCat f2 = new UpdateCat(code, name, vat);
                f2.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a category from the list to update.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void populateListView()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.PRODUCT_CATEGORY", con);

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["Code"].ToString());
                        item.SubItems.Add(rd1["Name"].ToString());
                        item.SubItems.Add(rd1["VAT"].ToString());

                        Cat_ListView.Items.Add(item);

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
