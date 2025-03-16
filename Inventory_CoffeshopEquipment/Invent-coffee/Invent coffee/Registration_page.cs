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
    public partial class Registration_page : UserControl
    {
        private MainForm _mainform;
        private string connectiondb = "server=localhost;database=mydb;user=root;password=1922tqbfjotldsql;";
        public Registration_page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            string username = SignUpUsername_textBox.Text.Trim();
            string password = SignUpPassword_textBox.Text;
            string confirmPassword = SignUpCPassword_textBox.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Username and password cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection conn = new MySqlConnection(connectiondb))
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }

                try
                {
                    conn.Open();
                    string query = "INSERT INTO users (username, password) VALUES (@username, @password)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        int result = cmd.ExecuteNonQuery();

                        if (result > 0)
                        {
                            MessageBox.Show("User Registered Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            _mainform.ShowLoginPage();
                        }
                        else
                        {
                            MessageBox.Show("Failed to register user.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open)
                    {
                        conn.Close();
                    }
                }
            }
        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            _mainform.ShowLoginPage();
        }
    }
}
