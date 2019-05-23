using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ecommerce
{
    public partial class UpdateProduct : Form
    {
        private int code;
        public UpdateProduct(int code, String product_name, String category_name, String description)
        {
            InitializeComponent();

            sellerLabel.Text = getSeller(code);
            NameBox.Text = product_name;
            DescriptionBox.Text = description;
            categoryBox.Text = category_name;
            this.code = code;
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

        private void submitButton_Click(object sender, EventArgs e)
        {
            String name = NameBox.Text;
            String description = DescriptionBox.Text;
            String categoryStr = categoryBox.Text;
            String username_Seller = sellerLabel.Text;
            int categoryCode = Convert.ToInt32(getCategoryCode(categoryStr));


            // Form validation
            if (!FormValidation.validateProduct(name, description, categoryStr))
            {
                return;
            }


            SqlConnection con = DbConnectionFactory.newConnection();
            try
            {
                con.Open();

                SqlCommand cmd3 = new SqlCommand("ecommerce.sp_Update_Product", con);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@Code", code);
                cmd3.Parameters.AddWithValue("@Name", name);
                cmd3.Parameters.AddWithValue("@Description", description);
                cmd3.Parameters.AddWithValue("@CategoryCode", categoryCode);
                cmd3.ExecuteNonQuery();


                MessageBox.Show("You have updated a product!", "Successful Operation", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            categoryBox.Items.Clear();
            populateCategoryBox();
        }

        private String getSeller(int code)
        {
            SqlConnection con = DbConnectionFactory.newConnection();

            try
            {
                con.Open();
                if (con.State == ConnectionState.Open)
                {
                    SqlCommand cm1 = new SqlCommand("SELECT userName_Seller FROM ecommerce.PRODUCT WHERE Code = @Code", con);
                    cm1.Parameters.Add("@Code", SqlDbType.Int).Value = code;
                    SqlDataReader rd1 = cm1.ExecuteReader();
                    rd1.Read();
                    return rd1["userName_Seller"].ToString();

                }
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
