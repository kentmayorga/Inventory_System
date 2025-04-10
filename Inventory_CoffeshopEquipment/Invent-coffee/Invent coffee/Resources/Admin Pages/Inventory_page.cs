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
using System.DirectoryServices.ActiveDirectory;

namespace Invent_coffee;

public partial class Inventory_page : UserControl
{
    private connSql conn = new connSql();
    private MainForm _mainform;
    private ContextMenuStrip filterMenu;
    private string selectedFilter = "All";
    public Inventory_page(MainForm mainform)
    {
        InitializeComponent();
        InitializeFilterButton();
        _mainform = mainform;
        displayData();
    }

    private void InitializeFilterButton()
    {
        // Create the dropdown menu
        filterMenu = new ContextMenuStrip();
        filterMenu.Items.Add("All", null, Filter_Click); 
        filterMenu.Items.Add("Ascending", null, Filter_Click);
        filterMenu.Items.Add("Decending", null, Filter_Click);
        filterMenu.Items.Add("Highest Price", null, Filter_Click);
        filterMenu.Items.Add("Lowest Price", null, Filter_Click);
        filterMenu.Items.Add("Highest Sold", null, Filter_Click);
        filterMenu.Items.Add("Lowest Sold", null, Filter_Click);
        filterMenu.Items.Add("Highest Stock", null, Filter_Click);
        filterMenu.Items.Add("Lowest Stock", null, Filter_Click);
        filterMenu.Items.Add("Available Stock", null, Filter_Click);
        filterMenu.Items.Add("Out of Stock", null, Filter_Click);
    }

    private void Filter_Click(object? sender, EventArgs e)
    {
        selectedFilter = ((ToolStripMenuItem)sender).Text;
        Searchbar_textbox.Text = "";
        displayData(); // Refresh the table with the selected filter
    }

    //Displays the inventory in table
    public void displayData()
    {
        try
        {
            using MySqlConnection connection = conn.connectSql();
            connection.Open();
            Console.WriteLine("Connecting to database...");

            string query = "SELECT ProductID, Name, Price, Stock, Sold FROM products";

            // Modify query based on the selected filter
            switch (selectedFilter)
            {
                case "Ascending":
                    query += " ORDER BY name ASC";
                    break;
                case "Decending":
                    query += " ORDER BY name DESC";
                    break;
                case "Highest Price":
                    query += " ORDER BY Price DESC";
                    break;
                case "Lowest Price":
                    query += " ORDER BY Price ASC";
                    break;
                case "Highest Sold":
                    query += " ORDER BY Sold DESC";
                    break;
                case "Lowest Sold":
                    query += " ORDER BY Sold ASC";
                    break;
                case "Highest Stock":
                    query += " ORDER BY Sold DESC";
                    break;
                case "Lowest Stock":
                    query += " ORDER BY Sold ASC";
                    break;
                case "Available Stock":
                    query += " WHERE Stock > 0";
                    break;
                case "Out of Stock":
                    query += " WHERE Stock = 0";
                    break;
                
            }

            // Apply search filter
            if (!string.IsNullOrWhiteSpace(Searchbar_textbox.Text))
            {
                query += $" WHERE Name LIKE '%{Searchbar_textbox.Text}%'";
            }

            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable dt = new DataTable();

            adapter.Fill(dt);

            Inventory_DataGridView.DataSource = dt;
            Inventory_DataGridView.AllowUserToAddRows = false;
            Inventory_DataGridView.Columns["ProductID"].Visible = false;
            Inventory_DataGridView.RowHeadersVisible = false;
            Inventory_DataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Inventory_DataGridView.ColumnHeadersVisible = false;


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

    private void FilterBtn_Click(object sender, EventArgs e)
    {
        filterMenu.Show((Control)sender, new Point(0, ((Control)sender).Height));
    }

    private void SearchBtn_Click(object sender, EventArgs e)
    {
        displayData();
    }
}
