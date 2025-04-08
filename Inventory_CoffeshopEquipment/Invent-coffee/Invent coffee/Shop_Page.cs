using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using MySqlX.XDevAPI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Invent_coffee.Resources;
using MySqlX.XDevAPI.Common;

namespace Invent_coffee
{
    public partial class Shop_Page : UserControl
    {
        private MainForm _mainForm;
        private connSql conn = new connSql(); //this is an SQL connection. The file is in Resources
        private static int productID = 0;

        public Shop_Page(MainForm mainform)
        {
            InitializeComponent();
            _mainForm = mainform;
            GetProducts();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            _mainForm.ShowHomePage();
        }
        private void GetProducts()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Image", typeof(Image));
                dt.Columns.Add("ProductID", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Description", typeof(string));
                dt.Columns.Add("Price", typeof(decimal));
                dt.Columns.Add("Available", typeof(int));

                using (MySqlConnection connection = conn.connectSql())
                {
                    connection.Open();
                    string query = "SELECT ProductID, Name, Description, Price, (Stock - sold) AS Available, ImagePath FROM products;";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string imagePath = reader["ImagePath"].ToString();
                            Image img = File.Exists(imagePath) ? Image.FromFile(imagePath) : null;

                            dt.Rows.Add(
                                img,
                                Convert.ToInt32(reader["ProductID"]),
                                reader["Name"].ToString(),
                                reader["Description"].ToString(),
                                Convert.ToDecimal(reader["Price"]),
                                Convert.ToInt32(reader["Available"])
                            );
                        }
                    }
                    connection.Close();
                }

                dataGridView1.Columns.Clear();

                DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
                imgCol.Name = "Image";
                imgCol.HeaderText = "Image";
                imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                imgCol.DataPropertyName = "Image";

                dataGridView1.Columns.Add(imgCol);

                dataGridView1.DataSource = dt;
                dataGridView1.RowTemplate.Height = 80; // Adjust height for better image display
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            _mainForm.ShowCartPage();
        }

        private void HomeButton_Click_1(object sender, EventArgs e)
        {
            _mainForm.ShowHomePage();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                ProductName.Text = "Name: " + row.Cells["Name"].Value.ToString();
                ProductDescription.Text = "Description: " + row.Cells["Description"].Value.ToString();
                ProductPrice.Text = "Price: " + row.Cells["Price"].Value.ToString();
                Image img = (Image)dataGridView1.Rows[e.RowIndex].Cells["Image"].Value;
                pictureBox1.Image = img;

                productID = Convert.ToInt32(row.Cells["ProductID"].Value);
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                var productQuantity = ProductQuantity.Text;

                DataTable getProduct = new DataTable();
                using (MySqlConnection connection = conn.connectSql())
                {
                    connection.Open();
                    string query = "SELECT * FROM cart WHERE product_id = @product_id AND user_id = @user_id";
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@product_id", productID);
                        cmd.Parameters.AddWithValue("@user_id", AppSession.id);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(getProduct);
                    }
                    connection.Close();
                }

                if (getProduct.Rows.Count > 0)
                {
                    DataTable updateCart = new DataTable();
                    using (MySqlConnection connection = conn.connectSql())
                    {
                        connection.Open();
                        string query = "UPDATE cart SET quantity = (quantity + @quantity) WHERE product_id = @product_id AND user_id = @user_id; " +
                                       "UPDATE products SET sold = (sold + @quantity) WHERE ProductID = @product_id; " +
                                       "SELECT 'Product has been added to cart.' AS message, 0 AS error;";
                        using (MySqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@product_id", productID);
                            cmd.Parameters.AddWithValue("@user_id", AppSession.id);
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(productQuantity));

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            adapter.Fill(updateCart);
                        }
                        connection.Close();
                    }

                    if (updateCart.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(updateCart.Rows[0]["error"]) == 0)
                        {
                            GetProducts();
                            MessageBox.Show(updateCart.Rows[0]["message"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Unable to process add to cart at the moment.");
                        }
                    }
                }
                else
                {
                    DataTable result = new DataTable();
                    using (MySqlConnection connection = conn.connectSql())
                    {
                        connection.Open();
                        string query = "INSERT INTO cart (product_id, user_id, quantity) " +
                                       "VALUES (@product_id, @user_id, @quantity); " +
                                       "UPDATE products SET sold = (sold + @quantity) WHERE ProductID = @product_id; " +
                                       "SELECT 'Product has been added to cart.' AS message, 0 AS error;";
                        using (MySqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@product_id", productID);
                            cmd.Parameters.AddWithValue("@user_id", AppSession.id);
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(productQuantity));

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            adapter.Fill(result);
                        }
                        connection.Close();
                    }

                    if (result.Rows.Count > 0)
                    {
                        if (Convert.ToInt32(result.Rows[0]["error"]) == 0)
                        {
                            GetProducts();
                            MessageBox.Show(result.Rows[0]["message"].ToString());
                        }
                        else
                        {
                            MessageBox.Show("Unable to process add to cart at the moment.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to process add to cart at the moment.");
                throw;
            }
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            AppSession.id = 0;
            AppSession.username = "";
            AppSession.role = "";
            _mainForm.ShowLoginPage();
        }

        private void Shop_Page_Load(object sender, EventArgs e)
        {

        }

        private void ProductDescription_Click(object sender, EventArgs e)
        {
    
        }
    }
}
