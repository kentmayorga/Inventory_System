using System;
using System.Data;
using System.Windows.Forms;
using Invent_coffee.Resources;
using MySql.Data.MySqlClient;

namespace Invent_coffee
{
    public partial class Registration_page : UserControl
    {
        private MainForm _mainform;
        private connSql conn = new connSql();   //this is an SQL connection. The file is in Resources

        public Registration_page(MainForm mainform)
        {
            InitializeComponent();
            _mainform = mainform;
            ErrorLabelSignUp.Visible = false;
        }


        private void SignUpPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            SignUpPassword_textBox.PasswordChar = '*';
        }
        private void SignUpCPassword_textBox_TextChanged(object sender, EventArgs e)
        {
            SignUpCPassword_textBox.PasswordChar = '*';
        }
        private void SignUpShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            char passwordChar = SignUpShowPassword_checkBox.Checked ? '\0' : '*';
            SignUpPassword_textBox.PasswordChar = passwordChar;
            SignUpCPassword_textBox.PasswordChar = passwordChar;
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            string username = SignUpUsername_textBox.Text.Trim();
            string password = SignUpPassword_textBox.Text;
            string confirmPassword = SignUpCPassword_textBox.Text;

            if (string.IsNullOrWhiteSpace(username))
            {
                ErrorProviderSigninUsername.SetError(SignUpUsername_textBox, "This field cannot be empty!");
            }
            else
            {
                ErrorProviderSigninUsername.SetError(SignUpUsername_textBox, "");
            }

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ErrorLabelSignUp.Text = ("Username and password cannot be empty!");
                ErrorLabelSignUp.Visible = true;
                return;
            }
            else
            {

                if (password != confirmPassword)
                {
                    ErrorLabelSignUp.Text = ("Passwords do not match!");
                    ErrorLabelSignUp.Visible = true;
                    return;
                }
                else {
                    ErrorLabelSignUp.Visible = false;
                }
            }

            using (MySqlConnection connection = conn.connectSql())
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO users (username, password) VALUES (@username, md5(@password))";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
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
                    connection.Close();
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unexpected Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SignIn_Btn_Click(object sender, EventArgs e)
        {
            _mainform.ShowLoginPage();
        }
    }
}
