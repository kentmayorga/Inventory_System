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
using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography;


namespace Invent_coffee
{
    public partial class Shop_Page : UserControl
    {
        private MainForm _mainForm;
        private string connectiondb = "server=localhost;database=mydb;user=root;password=Cold988@@;";
        private static int productID = 0;
        private static string ImagePath = "";
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

        //private void CreateProductButton(int productId, string name, decimal price, string imagePath)
        //{
        //    Panel panel = new Panel();
        //    panel.Size = new Size(150, 200);
        //    panel.BorderStyle = BorderStyle.Fixed3D;
        //    panel.Padding = new Padding(5, 5, 5, 5);

        //    PictureBox pictureBox = new PictureBox();
        //    pictureBox.BorderStyle = BorderStyle.FixedSingle;
        //    pictureBox.Size = new Size(140, 140);
        //    pictureBox.Location = new Point(5, 5);
        //    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

        //    if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
        //    {
        //        pictureBox.Image = Image.FromFile(imagePath);
        //    }
        //    else
        //    {
        //        pictureBox.Image = Image.FromFile(@"C:\Users\HP\Source\Repos\Inventory_System\Inventory_CoffeshopEquipment\Invent-coffee\Invent coffee\Resources\pngtree-coffee-logo-design-image_82183.jpg");
        //    }

        //    Button productButton = new Button();
        //    productButton.Text = $"{name}\n${price}";
        //    productButton.Tag = productId;
        //    productButton.Width = 140;
        //    productButton.Height = 50;
        //    productButton.Location = new Point(5, 140);
        //    productButton.TextAlign = ContentAlignment.MiddleCenter;
        //    productButton.Click += ProductButton_Click;

        //    panel.Controls.Add(pictureBox);
        //    panel.Controls.Add(productButton);

        //    tableLayoutPanel1.Controls.Add(panel);
        //}

        private void ProductButton_Click(object sender, EventArgs e)
        {
            //Button clickedButton = sender as Button;
            //int productId = (int)clickedButton.Tag;


        }

        //private void AddToCart(int userId, int productId, int quantity)
        //{
        //    try
        //    {
        //        using (MySqlConnection conn = new MySqlConnection(connectiondb))
        //        {
        //            string query = "INSERT INTO cart (UserID, ProductID, Quantity) " +
        //                           "VALUES (@UserID, @ProductID, @Quantity) " +
        //                           "ON DUPLICATE KEY UPDATE Quantity = Quantity + @Quantity";

        //            using (MySqlCommand cmd = new MySqlCommand(query, conn))
        //            {
        //                cmd.Parameters.AddWithValue("@UserID", userId);
        //                cmd.Parameters.AddWithValue("@ProductID", productId);
        //                cmd.Parameters.AddWithValue("@Quantity", quantity);

        //                conn.Open();
        //                cmd.ExecuteNonQuery();
        //                conn.Close();

        //                MessageBox.Show("Product added to cart!");
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error adding to cart: " + ex.Message);
        //    }
        //}

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

                using (MySqlConnection connection = new MySqlConnection(connectiondb))
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
                dataGridView1.RowTemplate.Height = 80;
                
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

               

                //if (row.Cells["productImage"].Value != null)
                //{
                //    productImage. = (Image)row.Cells["ProductImage"].Value;
                //}
            }
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            try
            {
                var productQuantity = ProductQuantity.Text;

                DataTable getProduct = new DataTable();
                using (MySqlConnection conn = new MySqlConnection(connectiondb))
                {
                    conn.Open();
                    string query = "SELECT * FROM cart WHERE product_id = @product_id AND user_id = @user_id";
                    using (MySqlCommand cmd = conn.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@product_id", productID);
                        cmd.Parameters.AddWithValue("@user_id", AppSession.id);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(getProduct);
                    }
                    conn.Close();
                }

                if (getProduct.Rows.Count > 0)
                {
                    DataTable updateCart = new DataTable();
                    using (MySqlConnection conn = new MySqlConnection(connectiondb))
                    {
                        conn.Open();
                        string query = "UPDATE cart SET quantity = (quantity + @quantity) WHERE product_id = @product_id AND user_id = @user_id; " +
                                       "UPDATE products SET sold = (sold + @quantity) WHERE ProductID = @product_id; " +
                                       "SELECT 'Product has been added to cart.' AS message, 0 AS error;";
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@product_id", productID);
                            cmd.Parameters.AddWithValue("@user_id", AppSession.id);
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(productQuantity));

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            adapter.Fill(updateCart);
                        }
                        conn.Close();
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
                    using (MySqlConnection conn = new MySqlConnection(connectiondb))
                    {
                        conn.Open();
                        string query = "INSERT INTO cart (product_id, user_id, quantity) " +
                                       "VALUES (@product_id, @user_id, @quantity); " +
                                       "UPDATE products SET sold = (sold + @quantity) WHERE ProductID = @product_id; " +
                                       "SELECT 'Product has been added to cart.' AS message, 0 AS error;";
                        using (MySqlCommand cmd = conn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@product_id", productID);
                            cmd.Parameters.AddWithValue("@user_id", AppSession.id);
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(productQuantity));

                            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                            adapter.Fill(result);
                        }
                        conn.Close();
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
            _mainForm.ShowLoginPage();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Shop_Page_Load(object sender, EventArgs e)
        {

        }
    }
}
