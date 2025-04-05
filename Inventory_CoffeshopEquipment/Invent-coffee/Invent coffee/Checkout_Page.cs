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

namespace Invent_coffee
{
    public partial class Checkout_Page : UserControl
    {
        private connSql conn = new connSql();
        private MainForm _mainform;
        public Checkout_Page(MainForm mainform)
        {
            InitializeComponent();
            GetProducts();
            _mainform = mainform;
        }
        private void DisplayAllDataInLabel()
        {
            string allNames = "";

            foreach (DataGridViewRow row in dataGridViewcheckout.Rows)
            {
                if (!row.IsNewRow)
                {
                    allNames += row.Cells["Name"].Value?.ToString() + Environment.NewLine;
                }
            }

            checkoutlabel.Text = allNames;
        }
        private void DisplayTotal()
        {
            decimal totalPrice = 0;

            string query = @"SELECT SUM(p.Price * c.quantity) AS TotalPrice FROM cart c INNER JOIN products p ON p.ProductID = c.product_id WHERE c.user_id = @user_id";

            using (MySqlConnection connection = conn.connectSql())
            {
                connection.Open();
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@user_id", AppSession.id);

                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        totalPrice = Convert.ToDecimal(result);
                    }
                }
                connection.Close();
            }

            labelTotal.Text = $"Total: ₱{totalPrice:F2}";

        }
        private void GetProducts()
        {
            try
            {
                DataTable result = new DataTable();
                using (MySqlConnection connection = conn.connectSql())
                {
                    connection.Open();
                    string query = "SELECT c.product_id, p.Name, p.Description, p.Price, c.quantity, c.added_at FROM cart c INNER JOIN products p ON p.ProductID = c.product_id  WHERE c.user_id = @user_id;";
                    using (MySqlCommand cmd = connection.CreateCommand())
                    {
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@user_id", AppSession.id);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        adapter.Fill(result);
                        dataGridViewcheckout.DataSource = result;
                        DisplayAllDataInLabel();
                        DisplayTotal();
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
        }

        private void Cart_Click(object sender, EventArgs e)
        {
            _mainform.ShowCartPage();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            AppSession.id = 0;
            AppSession.username = "";
            AppSession.role = "";
            _mainform.ShowLoginPage();
        }
    }
}
