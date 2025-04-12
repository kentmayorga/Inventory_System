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

namespace Invent_coffee.Resources.Admin_Pages.CRUD
{
    public partial class AddProduct_page : UserControl
    {
        private MainForm _mainform;
        private connSql conn = new connSql();
        private string savedImagePath = "";
        private string sourcePath = "";
        private int clickedSave;
        public AddProduct_page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
            ProductImage_label.Visible = false;
        }

        public void SaveProductToDatabase(TextBox productName, TextBox productDesc, TextBox productPrice, TextBox productStock)
        {
            try
            {
                using MySqlConnection connection = conn.connectSql();
                connection.Open();
                Console.WriteLine("Connecting to database...");

                //Check if the product already exists
                string checkQuery = "SELECT COUNT(*) FROM products WHERE Name = @product_name";
                using MySqlCommand checkCmd = new MySqlCommand(checkQuery, connection);
                checkCmd.Parameters.AddWithValue("@product_name", productName.Text);

                int productExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (productExists > 0)
                {
                    //Warn user and ask if they want to update or add new
                    DialogResult result = MessageBox.Show(
                        "Product already exists. Do you want to update the existing product?",
                        "Product Exists",
                        MessageBoxButtons.YesNoCancel,
                        MessageBoxIcon.Question
                    );

                    if (result == DialogResult.Yes)
                    {
                        // Update existing product
                        string updateQuery = "UPDATE products SET Description = @product_desc, Price = @product_price, Stock = @product_stock, ImagePath = @product_img WHERE Name = @product_name";
                        using MySqlCommand updateCmd = new MySqlCommand(updateQuery, connection);
                        updateCmd.Parameters.AddWithValue("@product_name", productName.Text);
                        updateCmd.Parameters.AddWithValue("@product_desc", productDesc.Text);
                        updateCmd.Parameters.AddWithValue("@product_price", decimal.Parse(productPrice.Text));
                        updateCmd.Parameters.AddWithValue("@product_stock", int.Parse(productStock.Text));
                        updateCmd.Parameters.AddWithValue("@product_img", savedImagePath);

                        int rowsUpdated = updateCmd.ExecuteNonQuery();
                        Console.WriteLine(rowsUpdated > 0 ? "Product updated successfully!" : "Failed to update product.");
                    }
                    else if (result == DialogResult.No)
                    {
                        // Insert as new with a modified name to avoid duplicate key
                        string newName = productName.Text + " (Copy)";
                        string insertQuery = "INSERT INTO products(Name,Description,Price, Stock, ImagePath) VALUES (@product_name,@product_desc, @product_price, @product_stock, @product_img);";
                        using MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                        insertCmd.Parameters.AddWithValue("@product_name", newName);
                        insertCmd.Parameters.AddWithValue("@product_desc", productDesc.Text);
                        insertCmd.Parameters.AddWithValue("@product_price", decimal.Parse(productPrice.Text));
                        insertCmd.Parameters.AddWithValue("@product_stock", int.Parse(productStock.Text));
                        insertCmd.Parameters.AddWithValue("@product_img", savedImagePath);

                        int rowsInserted = insertCmd.ExecuteNonQuery();
                        Console.WriteLine(rowsInserted > 0 ? "Product added as new!" : "Failed to add product.");
                    }
                    else
                    {
                        Console.WriteLine("User canceled the action.");
                        clickedSave = 0;
                    }
                }
                else
                {
                    // Step 3: Insert new product
                    string insertQuery = "INSERT INTO products(Name,Description,Price, Stock, ImagePath) VALUES (@product_name,@product_desc, @product_price, @product_stock, @product_img);";
                    using MySqlCommand insertCmd = new MySqlCommand(insertQuery, connection);
                    insertCmd.Parameters.AddWithValue("@product_name", productName.Text);
                    insertCmd.Parameters.AddWithValue("@product_desc", productDesc.Text);
                    insertCmd.Parameters.AddWithValue("@product_price", decimal.Parse(productPrice.Text));
                    insertCmd.Parameters.AddWithValue("@product_stock", int.Parse(productStock.Text));
                    insertCmd.Parameters.AddWithValue("@product_img", savedImagePath);

                    int rowsInserted = insertCmd.ExecuteNonQuery();
                    Console.WriteLine(rowsInserted > 0 ? "Product added successfully!" : "Failed to add product.");
                }

                // Save image file
                if (!string.IsNullOrEmpty(sourcePath) && !string.IsNullOrEmpty(savedImagePath))
                {
                    File.Copy(sourcePath, savedImagePath, true);
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }
        }

        private void ProductSaveBtn_Click(object sender, EventArgs e)
        {
            clickedSave = 1;
            SaveProductToDatabase(ProductName_textBox, ProductDescription_textBox, ProductPrice_textBox, ProductStock_textBox);
            if(clickedSave == 1){
                _mainform.ShowInventoryPage();
            }
            
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
