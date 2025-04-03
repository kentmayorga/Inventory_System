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
    public partial class Login_page : UserControl
    {
        private MainForm _mainform;
        private string connectiondb = "server=localhost;database=mydb;user=root;password=Cold988@@;";
        public Login_page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
            ErrorMessageLabel.Visible = false;
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
        private void Username_txtBox_TextChanged(object sender, EventArgs e)
        {
            //Username_txtBox.Text = Username_txtBox.Text.ToUpper();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = Username_txtBox.Text;
            string formattedUsername = char.ToUpper(username[0]) + username.Substring(1).ToLower();
            string password = Password_txtBox.Text;

            errorProviderUsername.SetError(Username_txtBox, string.IsNullOrWhiteSpace(username) ? "This field cannot be empty!" : "");

            DataTable result = new DataTable();
            using (MySqlConnection conn = new MySqlConnection(connectiondb))
            {
                conn.Open();
                string query = "SELECT * FROM users WHERE username = @username AND password = md5(@password)";
                using (MySqlCommand cmd =  conn.CreateCommand())
                {
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    adapter.Fill(result);
                }
                conn.Close();
            }

            if (result.Rows.Count > 0)
            {
                AppSession.id = Convert.ToInt32(result.Rows[0]["id"]);
                AppSession.username = result.Rows[0]["username"].ToString();
                AppSession.role = result.Rows[0]["role"].ToString();
                ErrorMessageLabel.Visible = false;
                MessageBox.Show("Login Successful.");
            }
            else
            {
                ErrorMessageLabel.Text = ("Failed Login, Try Again.");
                ErrorMessageLabel.Visible = true;
                return;
            }

            _mainform.ShowHomePage();
        }

        private void RegistrationBtn_Click(object sender, EventArgs e)
        {
            _mainform.ShowRegistrationPage();
        }
    }
}
