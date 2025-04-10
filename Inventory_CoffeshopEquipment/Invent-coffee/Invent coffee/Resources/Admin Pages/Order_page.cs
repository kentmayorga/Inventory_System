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

namespace Invent_coffee.Resources.Admin_Pages
{
    public partial class Order_page : UserControl
    {
        private connSql conn = new connSql();
        private MainForm _mainform;
        private ContextMenuStrip filterMenu;
        private string selectedFilter = "All";
        public Order_page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
            InitializeFilterButton();
            displayData();
        }

        public void displayData()
        {
            try
            {
                using MySqlConnection connection = conn.connectSql();
                connection.Open();
                Console.WriteLine("Connecting to database...");

                string query = "SELECT id, username FROM users"; //change query to orders

                // Modify query based on the selected filter
                switch (selectedFilter)
                {
                    case "Ascending":
                        query += " ORDER BY username ASC"; //note: change to name after the order table is updated
                        break;
                    case "Decending":
                        query += " ORDER BY username DESC";
                        break;

                }

                // Apply search filter
                if (!string.IsNullOrWhiteSpace(SearchBar_textBox.Text))
                {
                    query += $" WHERE usename LIKE '%{SearchBar_textBox.Text}%'";//note: redo this, make it able to accept any index in the table
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                OrderInfo_dataGridView.DataSource = dt;
                OrderInfo_dataGridView.AllowUserToAddRows = false;
                OrderInfo_dataGridView.Columns["id"].Visible = false; //change the id value to match the table
                OrderInfo_dataGridView.RowHeadersVisible = false;
                OrderInfo_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                OrderInfo_dataGridView.ColumnHeadersVisible = false;


                if (OrderInfo_dataGridView.Columns["Action"] == null)
                {
                    DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn
                    {
                        Name = "Action",
                        HeaderText = "Status",
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                        FlatStyle = FlatStyle.Flat
                    };

                    statusColumn.Items.AddRange("Pending", "In Progress", "Complete");

                    OrderInfo_dataGridView.Columns.Add(statusColumn);
                }


                connection.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error connecting to database: " + ex.Message);
            }


        }

        private void Filter_Click(object? sender, EventArgs e)
        {
            selectedFilter = ((ToolStripMenuItem)sender).Text;
            SearchBar_textBox.Text = "";
            displayData();
        }

        private void InitializeFilterButton()
        {
            // Create the dropdown menu
            filterMenu = new ContextMenuStrip();
            filterMenu.Items.Add("All", null, Filter_Click);
            filterMenu.Items.Add("Latest Order", null, Filter_Click);
            filterMenu.Items.Add("Newest Order", null, Filter_Click);
            filterMenu.Items.Add("Pending", null, Filter_Click);
            filterMenu.Items.Add("In Progress", null, Filter_Click);
            filterMenu.Items.Add("Complete", null, Filter_Click);
        }

        private void FilterBtn_Click(object sender, EventArgs e)
        {
            filterMenu.Show((Control)sender, new Point(0, ((Control)sender).Height));
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            _mainform.ShowAdminPage();
        }

    }
}
