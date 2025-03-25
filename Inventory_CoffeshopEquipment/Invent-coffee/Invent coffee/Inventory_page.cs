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
using System.Data.Common;

namespace Invent_coffee;

public partial class Inventory_page : UserControl
{
    private connSql conn = new connSql();
    private MainForm _mainform;
    public Inventory_page(MainForm mainform)
    {
        InitializeComponent();
        _mainform = mainform;
        displayData();
    }

    //Displays the inventory in table
    public void displayData()
    {
        try
        {
            using MySqlConnection connection = conn.connectSql();
            connection.Open();
            Console.WriteLine("Connecting to database...");

            string query = "SELECT ProductID,Name, Price, Stock, sold FROM products;";

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            Inventory_DataGridView.DataSource = dt;

            Inventory_DataGridView.AllowUserToAddRows = false;
            Inventory_DataGridView.Columns["ProductID"].Visible = false;

            if (Inventory_DataGridView.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };

                Inventory_DataGridView.Columns.Add(editColumn);
            }

            if (Inventory_DataGridView.Columns["Remove"] == null)
            {
                DataGridViewButtonColumn deleteColumn = new DataGridViewButtonColumn
                {
                    Name = "Remove",
                    HeaderText = "Remove",
                    Text = "Remove",
                    UseColumnTextForButtonValue = true,
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                };

                Inventory_DataGridView.Columns.Add(deleteColumn);
            }
            connection.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error connecting to database: " + ex.Message);
        }

    }

    private void Inventory_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            int idno = Convert.ToInt32(Inventory_DataGridView.Rows[e.RowIndex].Cells["ProductID"].Value);

            if (Inventory_DataGridView.Columns[e.ColumnIndex].Name == "Edit")
            {
                _mainform.ShowEditProductPage(idno);
            }
            else if (Inventory_DataGridView.Columns[e.ColumnIndex].Name == "Remove")
            {
                deleteData(idno);
            }
        }
    }

    public void deleteData(int id)
    {
        DialogResult result = MessageBox.Show("Do you want to delete this product?", "Confirm Delete", MessageBoxButtons.YesNo);

        if (result == DialogResult.Yes)
        {
            try
            {
                using MySqlConnection connecion = conn.connectSql();

                connecion.Open();

                string img_path = "";
                string imgQuery = "SELECT ImagePath FROM products WHERE ProductID = @idno";

                using MySqlCommand imgCmd = new MySqlCommand(imgQuery, connecion);

                imgCmd.Parameters.AddWithValue("@idno", id);
                object resultPath = imgCmd.ExecuteScalar();

                if (resultPath != null)
                {
                    img_path = resultPath.ToString();
                }

                if (!string.IsNullOrEmpty(img_path) && File.Exists(img_path))
                {
                    try
                    {
                        File.Delete(img_path);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting image file: " + ex.Message);
                        return; // Stop if image deletion fails
                    }
                }

                string delQuery = "DELETE FROM products WHERE ProductID = @idno";

                using MySqlCommand cmd = new MySqlCommand(delQuery, connecion);

                cmd.Parameters.AddWithValue("@idno", id);
                cmd.ExecuteNonQuery();

                connecion.Close();

                displayData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting product: " + ex.Message);
            }

        }
    }

    private void AddProductBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowAddProductPage();
    }

    private void BackBtn_Click(object sender, EventArgs e)
    {
        _mainform.ShowAdminPage();
    }
}
