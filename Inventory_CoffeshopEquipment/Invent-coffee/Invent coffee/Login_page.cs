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
    public partial class Login_page : UserControl
    {
        private MainForm _mainform;
        private string connectiondb = "server=localhost;database=mydb;user=root;password=1922tqbfjotldsql;";
        public Login_page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
        }

        private void Password_txtBox_TextChanged(object sender, EventArgs e)
        {
            Password_txtBox.PasswordChar = '*';
        }

        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_checkBox.Checked)
            {
                Password_txtBox.PasswordChar = '\0';
            }
            else
            {
                Password_txtBox.PasswordChar = '*';
            }
        }

        private bool AuthenticateLogin(string username, string password)
        {
            using (MySqlConnection conn = new MySqlConnection(connectiondb))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void Username_txtBox_TextChanged(object sender, EventArgs e)
        {
            Username_txtBox.Text = Username_txtBox.Text.ToLower();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = Username_txtBox.Text;
            string password = Password_txtBox.Text;

            if (AuthenticateLogin(username, password))
            {
                MessageBox.Show("Login Successful.");
            }
            else
            {
                MessageBox.Show("Failed Login");
            }
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            _mainform.ShowRegistrationPage();
        }
    }
}
