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
using Mysqlx.Resultset;
using Microsoft.VisualBasic.ApplicationServices;

namespace Invent_coffee.Resources.Admin_Pages
{
    public partial class Accounts_page : UserControl
    {
        private connSql conn = new connSql();
        private MainForm _mainform;
        private ContextMenuStrip filterMenu;
        private string selectedFilter = "All";
        public Accounts_page(MainForm mainform)
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

                string query = "SELECT id, username, role, status FROM users"; //SELECT id, lastname, firstname, usename, contact, address, role FROM users;

                // Modify query based on the selected filter
                switch (selectedFilter)
                {
                    case "Ascending":
                        query += " ORDER BY username ASC"; //note: change to name after the user table is updated
                        break;
                    case "Decending":
                        query += " ORDER BY username DESC";
                        break;

                }

                // Apply search filter
                if (!string.IsNullOrWhiteSpace(Searchbar_textbox.Text))
                {
                    query += $" WHERE usename LIKE '%{Searchbar_textbox.Text}%'";//note: redo this, make it able to accept any index in the table
                }

                MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
                DataTable dt = new DataTable();

                adapter.Fill(dt);

                InformationData_datagridview.DataSource = dt;
                InformationData_datagridview.AllowUserToAddRows = false;
                InformationData_datagridview.Columns["id"].Visible = false;
                InformationData_datagridview.RowHeadersVisible = false;
                InformationData_datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                InformationData_datagridview.ColumnHeadersVisible = false;


                if (InformationData_datagridview.Columns["Action"] == null)
                {
                    DataGridViewButtonColumn editColumn = new DataGridViewButtonColumn
                    {
                        Name = "Action",
                        HeaderText = "Status",
                        Text = "Action",
                        UseColumnTextForButtonValue = true,
                        AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    }; 

                    InformationData_datagridview.Columns.Add(editColumn);
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
            Searchbar_textbox.Text = "";
            displayData();
        }

        private void InitializeFilterButton()
        {
            // Create the dropdown menu
            filterMenu = new ContextMenuStrip();
            filterMenu.Items.Add("All", null, Filter_Click);
            filterMenu.Items.Add("Admin", null, Filter_Click);
            filterMenu.Items.Add("Users", null, Filter_Click);
            filterMenu.Items.Add("Ascending by Lastname", null, Filter_Click);
            filterMenu.Items.Add("Decending by Lastname", null, Filter_Click);
            filterMenu.Items.Add("Ascending by Firstname", null, Filter_Click);
            filterMenu.Items.Add("Decending by Firstname", null, Filter_Click);
            filterMenu.Items.Add("Ascending by Username", null, Filter_Click);
            filterMenu.Items.Add("Decending by Username", null, Filter_Click);

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            _mainform.ShowAdminPage();
        }

        private void Filter_btn_Click(object sender, EventArgs e)
        {
            filterMenu.Show((Control)sender, new Point(0, ((Control)sender).Height));
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            displayData();
        }

        private void AddAccountBtn_Click(object sender, EventArgs e)
        {
            _mainform.ShowAddAccountPage();
        }

        private void InformationData_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idno = Convert.ToInt32(InformationData_datagridview.Rows[e.RowIndex].Cells["id"].Value);
                string status = InformationData_datagridview.Rows[e.RowIndex].Cells["status"].Value.ToString();
                string newStatus = (status == "active") ? "inactive" : "active";

                try
                {
                    using MySqlConnection connection = conn.connectSql();
                    connection.Open();

                    string updateQuery = "UPDATE users SET status = @status WHERE id = @id";
                    using MySqlCommand cmd = new MySqlCommand(updateQuery, connection);
                    cmd.Parameters.AddWithValue("@status", newStatus);
                    cmd.Parameters.AddWithValue("@id", idno);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("User status updated successfully!", "Success", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating status: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
            displayData();
        }
    }
}
