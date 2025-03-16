using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Invent_coffee;

public partial class MainForm : Form
{
    private string connectiondb = "server=localhost;database=mydb;user=root;password=1922tqbfjotldsql;";
    public MainForm()
    {
        InitializeComponent();
        TestDatabaseConnection();
        Login_Panel.BringToFront();//displays the Login_Panel when the application first start
    }

    //Check for the database connection
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

    /*
     *===============Login Panel==================
     */

    private void PasswordSignIn_txtBox_TextChanged(object sender, EventArgs e)
    {
        PasswordSignIn_txtBox.PasswordChar = '*';
    }
    private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
    {
        if (ShowPassword_checkBox.Checked)
        {
            PasswordSignIn_txtBox.PasswordChar = '\0';
        }
        else
        {
            PasswordSignIn_txtBox.PasswordChar = '*';
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

    private void UsernameSignIn_txtBox_TextChanged(object sender, EventArgs e)
    {
        UsernameSignIn_txtBox.Text = UsernameSignIn_txtBox.Text.ToLower();
    }

    private void LoginBtn_Click(object sender, EventArgs e)
    {
        string username = UsernameSignIn_txtBox.Text;
        string password = PasswordSignIn_txtBox.Text;

        if (AuthenticateLogin(username, password))
        {
            MessageBox.Show("Login Successful.");
        }
        else
        {
            MessageBox.Show("Failed Login");
        }
    }
    //Switch to the registration panel
    private void RegistrationBtn_Click(object sender, EventArgs e)
    {
        Registration_Panel.BringToFront();
    }
    /*
     *===============Registration Panel===============
     */
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

                        Form1 loginForm = new Form1();
                        loginForm.Show();
                        this.Close();
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
        Login_Panel.BringToFront();
    }
} 


