using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invent_coffee.Resources;
using MySql.Data.MySqlClient;

namespace Invent_coffee.CRUD
{
    public partial class AddProduct_page : UserControl
    {
        private MainForm _mainform;
        private connSql conn = new connSql();
        private string savedImagePath = "";
        private string sourcePath = "";

        public AddProduct_page(MainForm mainForm)
        {
            InitializeComponent();
            _mainform = mainForm;
            ProductImage_label.Visible = false;
        }

        public void SaveProductToDatabase(TextBox productName, TextBox productDesc, TextBox productPrice, TextBox productStock)
        {
            try
            {
                using MySqlConnection connection = conn.connectSql();
                connection.Open();
                Console.WriteLine("Connecting to database...");

                string query = "INSERT INTO products(Name,Description,Price, Stock, ImagePath) VALUES (@product_name,@product_desc, @product_price, @product_stock, @product_img);";

                using MySqlCommand cmd = connection.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.AddWithValue("@product_name", productName.Text);
                cmd.Parameters.AddWithValue("@product_desc", productDesc.Text);
                cmd.Parameters.AddWithValue("@product_price", decimal.Parse(productPrice.Text));
                cmd.Parameters.AddWithValue("@product_stock", int.Parse(productStock.Text));
                cmd.Parameters.AddWithValue("@product_img", savedImagePath);

                int rowsAffected = cmd.ExecuteNonQuery();
                Console.WriteLine(rowsAffected > 0 ? "Product added successfully!" : "Failed to add product.");

                File.Copy(sourcePath, savedImagePath, true);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }
        }

        private void ProductSaveBtn_Click(object sender, EventArgs e)
        {
            SaveProductToDatabase(ProductName_textBox, ProductDescription_textBox, ProductPrice_textBox, ProductStock_textBox);
            _mainform.ShowInventoryPage();
        }

        private void AddImageBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
                Title = "Select Product Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sourcePath = openFileDialog.FileName; // Get selected image path
                string imageName = Path.GetFileName(sourcePath); // Extract file name

                string projectFolder = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;

                // Define the target folder where images will be stored
                string targetFolder = Path.Combine(projectFolder, "Images");

                // Create directory if it doesn't exist
                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                // Define the new file path
                savedImagePath = Path.Combine(targetFolder, imageName);

                ProductImage_label.Text = imageName;
                ProductImage_label.Visible = true;
            }
        }

        private void ProductCancelBtn_Click(object sender, EventArgs e)
        {
            _mainform.ShowInventoryPage();
        }
    }
}
