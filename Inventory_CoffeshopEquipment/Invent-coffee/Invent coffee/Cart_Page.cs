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
using Invent_coffee.Resources;

namespace Invent_coffee
{
    public partial class Cart_Page : UserControl
    {
        private connSql conn = new connSql();   //this is an SQL connection. The file is in Resources
        private MainForm _mainform;
        private static int productID = 0;

        public Cart_Page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
            GetProducts();

        }

        private void GetProducts()
        {
            try
            {
                DataTable result = new DataTable();
                using (MySqlConnection connection = conn.connectSql())
                {
                    connection.Open();
                    string query = "SELECT c.product_id, p.Name, p.Description, p.Price, c.quantity, c.added_at FROM cart c INNER JOIN products p ON p.ProductID = c.product_id  WHERE c.user_id = @user_id; ";
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@user_id", AppSession.id);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(result);
                        dataGridViewCart.DataSource = result;
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void dataGridViewCart_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewCart.Rows[e.RowIndex];
                ProductQuantity.Text = row.Cells["quantity"].Value.ToString();
                QuantityLabel.Text = "Quantity for: " + row.Cells["Name"].Value.ToString();
                productID = Convert.ToInt32(row.Cells["product_id"].Value);
            }
        }

        private void UpdateQuantityButton_Click(object sender, EventArgs e)
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
                var currentQuantity = Convert.ToInt32(getProduct.Rows[0]["quantity"]);
                DataTable updateCart = new DataTable();
                if (Convert.ToInt32(productQuantity) > currentQuantity)
                {
                    using (MySqlConnection connection = conn.connectSql())
                    {
                        connection.Open();
                        string query = "UPDATE cart SET quantity = @quantity WHERE product_id = @product_id AND user_id = @user_id; " +
                                        "UPDATE products SET sold = (sold + @additional_quantity) WHERE ProductID = @product_id; " +
                                        "SELECT 'Product quantity has been updated.' AS message, 0 AS error;";
                        using (MySqlCommand cmd = connection.CreateCommand())
                        {
                            cmd.CommandType = CommandType.Text;
                            cmd.CommandText = query;
                            cmd.Parameters.AddWithValue("@product_id", productID);
                            cmd.Parameters.AddWithValue("@user_id", AppSession.id);
                            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(productQuantity));
                            cmd.Parameters.AddWithValue("@additional_quantity", Convert.ToInt32(productQuantity) - currentQuantity);

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
                            MessageBox.Show("Unable to process update of quantity at the moment.");
                        }
                    }
                }
                else
                {
                    using (MySqlConnection connection = conn.connectSql())
                    {
                        connection.Open();
                        string query = "UPDATE cart SET quantity = (quantity - @quantity) WHERE product_id = @product_id AND user_id = @user_id; " +
                                        "UPDATE products SET sold = (sold - @quantity) WHERE ProductID = @product_id; " +
                                        "SELECT 'Product quantity has been updated.' AS message, 0 AS error;";
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
                            MessageBox.Show("Unable to process update of quantity at the moment.");
                        }
                    }
                }
            }
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            _mainform.ShowHomePage();
        }
    }
}
