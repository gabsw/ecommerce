using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class Delivery_Comp : Form
    {
        public Delivery_Comp()
        {
            InitializeComponent();
        }

        private void AddNewButton_Click(object sender, EventArgs e)
        {
            AddNewDeliveryComp f1 = new AddNewDeliveryComp();
            f1.Show();

            DeliveryCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DeliveryCompLV.Items.Clear();
            populateListView();
            this.Refresh();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (DeliveryCompLV.SelectedItems.Count == 1)
            {
                ListViewItem item = DeliveryCompLV.SelectedItems[0];

                String name = item.SubItems[0].Text;
                String phone = item.SubItems[1].Text;
                String address = item.SubItems[2].Text;
                Boolean expressDelivery = Convert.ToBoolean(item.SubItems[3].Text);

                UpdateDeliveryComp f2 = new UpdateDeliveryComp(name, phone, address, expressDelivery);
                f2.Show();
            }
            else
            {
                MessageBox.Show("You need to choose a delivery company from the list to update.", "Error alert",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Delivery_Comp_Load(object sender, EventArgs e)
        {
            DeliveryCompLV.Items.Clear();
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
                    SqlCommand cm1 = new SqlCommand("SELECT * FROM ecommerce.DELIVERY_COMPANY", con);

                    SqlDataReader rd1 = cm1.ExecuteReader();


                    while (rd1.Read())
                    {
                        ListViewItem item = new ListViewItem(rd1["name"].ToString());
                        item.SubItems.Add(rd1["contactNumber"].ToString());
                        item.SubItems.Add(rd1["address"].ToString());
                        item.SubItems.Add(rd1["hasExpressDelivery"].ToString());

                        DeliveryCompLV.Items.Add(item);

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
