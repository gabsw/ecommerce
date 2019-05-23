using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class AddNewProduct : Form
    {
        public AddNewProduct()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear_text();
        }

        private void clear_text()
        {
            NameBox.Text = "";
            DescriptionBox.Text = "";
            categoryBox.Text = "";
            userBox.Text = "";
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            String name = NameBox.Text;
            String description = DescriptionBox.Text;
            String categoryStr = categoryBox.Text;
            String username_Seller = userBox.Text;
            int categoryCode = Convert.ToInt32(getCategoryCode(categoryStr));

            if (!FormValidation.validateProduct(name, description, categoryStr))
            {
                return;
            }

            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                SqlCommand cm2 = new SqlCommand("ecommerce.sp_Create_Product", con);
                cm2.CommandType = CommandType.StoredProcedure;
                cm2.Parameters.AddWithValue("@Name", name);
                cm2.Parameters.AddWithValue("@Description", description);
                cm2.Parameters.AddWithValue("@CategoryCode", categoryCode);
                cm2.Parameters.AddWithValue("@userName_Seller", username_Seller);
                cm2.ExecuteNonQuery();

                MessageBox.Show("You have added a new product!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FAILED TO OPEN CONNECTION TO DATABASE DUE TO THE FOLLOWING ERROR \r\n" + ex.Message, "Connection Test", MessageBoxButtons.OK);
            }
            finally
            {
                con.Close();
            }

            clear_text();
            this.Close();
        }

        private void AddNewProduct_Load(object sender, EventArgs e)
        {
            categoryBox.Items.Clear();
            userBox.Items.Clear();
            populateCategoryBox();
            populateUserBox();
        }

        private void populateCategoryBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm2 = new SqlCommand("SELECT Name FROM ecommerce.PRODUCT_CATEGORY", con);

                SqlDataReader rd2 = cm2.ExecuteReader();

                while (rd2.Read())
                {

                    categoryBox.Items.Add(rd2["Name"].ToString());
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

        private void populateUserBox()
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                SqlCommand cm2 = new SqlCommand("SELECT userName FROM ecommerce.REGULAR_USER", con);

                SqlDataReader rd2 = cm2.ExecuteReader();

                while (rd2.Read())
                {

                    userBox.Items.Add(rd2["userName"].ToString());
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

        private String getCategoryCode(String category_str)
        {

            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT Code FROM ecommerce.PRODUCT_CATEGORY " +
                        "WHERE Name = @Name", con);
                    cm1.Parameters.Add("@Name", SqlDbType.VarChar).Value = category_str;
                    SqlDataReader rd1 = cm1.ExecuteReader();
                    rd1.Read();
                    return rd1["Code"].ToString();

                }
                FormValidation.showError("Category cannot be empty.");
                return "";
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
    }
}
