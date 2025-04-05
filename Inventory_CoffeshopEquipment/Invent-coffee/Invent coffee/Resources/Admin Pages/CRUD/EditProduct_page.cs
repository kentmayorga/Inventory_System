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
    public partial class EditProduct_page : UserControl
    {
        private MainForm _mainform;
        private connSql conn = new connSql();
        private int idno;
        public EditProduct_page(MainForm mainform, int id)
        {
            InitializeComponent();
            _mainform = mainform;
            idno = id;
            loadData();
        }

        private void loadData()
        {
            using MySqlConnection connection = conn.connectSql();
            connection.Open();

            string query = "SELECT * FROM products WHERE ProductID = @idno;";

            using MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@idno", idno);

            using MySqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                ProductName_textBox.Text = reader["Name"].ToString();
                ProductDesc_textBox.Text = reader["Description"].ToString();
                ProductPrice_textBox.Text = reader["Price"].ToString();
                ProductStock_textBox.Text = reader["Stock"].ToString();
            }
            connection.Close();
        }

        public void updateProduct(int productId, TextBox prodName, TextBox prodDesc, TextBox prodPrice, TextBox prodStock)
        {
            try
            {
                using MySqlConnection connection = conn.connectSql();
                connection.Open();

                string query = "UPDATE products SET Name = @prodName, Description = @prodDesc, Price = @prodPrice, Stock = @prodStock WHERE ProductID = @idno;";

                using MySqlCommand cmd = new MySqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@prodName", prodName.Text);
                cmd.Parameters.AddWithValue("@prodDesc", prodDesc.Text);
                cmd.Parameters.AddWithValue("@prodPrice", decimal.Parse(prodPrice.Text));
                cmd.Parameters.AddWithValue("@prodStock", int.Parse(prodStock.Text));
                cmd.Parameters.AddWithValue("@idno", productId);
                cmd.ExecuteNonQuery();

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating product: " + ex.Message);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updateProduct(idno, ProductName_textBox, ProductDesc_textBox, ProductPrice_textBox, ProductStock_textBox);
            _mainform.ShowInventoryPage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _mainform.ShowInventoryPage();
        }
    }
}
