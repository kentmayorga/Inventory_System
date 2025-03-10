using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Invent_coffee
{
    public partial class Form1 : Form
    {
        private string connectiondb = "server=localhost;database=mydb;user=root;password=1922tqbfjotldsql;";

        public Form1()
        {
            InitializeComponent();
            TestDatabaseConnection();
        }
        private void TestDatabaseConnection()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectiondb))
                {
                    conn.Open();
                    MessageBox.Show("Connected!");
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection failed: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void SignInPassword_TextChanged(object sender, EventArgs e)
        {
            SignInPassword.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                SignInPassword.PasswordChar = '\0';
            }
            else
            {
                SignInPassword.PasswordChar = '*';
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
        private void UsernameSignIn_TextChanged(object sender, EventArgs e)
        {
            UsernameSignIn.Text = UsernameSignIn.Text.ToLower();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = UsernameSignIn.Text;
            string password = SignInPassword.Text;

            if (AuthenticateLogin(username, password))
            {
                MessageBox.Show("Login Successful.");
            }
            else
            {
                MessageBox.Show("Failed Login");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regis_form register = new regis_form();
            register.Show();
            this.Hide();
        }
    }
}
