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

namespace Invent_coffee
{
    public partial class Shop_Page : UserControl
    {
        private MainForm _mainForm;
        private string connectiondb = "server=localhost;database=mydb;user=root;password=1922tqbfjotldsql;";

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

        private void CreateProductButton(int productId, string name, decimal price, string imagePath)
        {
            Panel panel = new Panel();
            panel.Size = new Size(150, 200);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Padding = new Padding(5, 5, 5, 5);

            PictureBox pictureBox = new PictureBox();
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Size = new Size(140, 140);
            pictureBox.Location = new Point(5, 5);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
            {
                pictureBox.Image = Image.FromFile(imagePath);
            }
            else
            {
                pictureBox.Image = Image.FromFile(@"C:\Users\HP\Source\Repos\Inventory_System\Inventory_CoffeshopEquipment\Invent-coffee\Invent coffee\Resources\pngtree-coffee-logo-design-image_82183.jpg");
            }

            Button productButton = new Button();
            productButton.Text = $"{name}\n${price}";
            productButton.Tag = productId;
            productButton.Width = 140;
            productButton.Height = 50;
            productButton.Location = new Point(5, 140);
            productButton.TextAlign = ContentAlignment.MiddleCenter;
            productButton.Click += ProductButton_Click;

            panel.Controls.Add(pictureBox);
            panel.Controls.Add(productButton);

            tableLayoutPanel1.Controls.Add(panel);
        }



        private void ProductButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int productId = (int)clickedButton.Tag;

            MessageBox.Show($"Added Product ID: {productId} to cart");
        }
        private void GetProducts()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectiondb))
                {
                    conn.Open();
                    string query = "SELECT ProductID, Name, Price, ImagePath FROM products;";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int productId = reader.GetInt32("ProductID");
                                string name = reader.GetString("Name");
                                decimal price = reader.GetDecimal("Price");
                                string imagePath = reader.IsDBNull(reader.GetOrdinal("ImagePath")) ? "" : reader.GetString("ImagePath");

                                CreateProductButton(productId, name, price, imagePath);
                            }
                        }
                    }
                }
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
    }
}
