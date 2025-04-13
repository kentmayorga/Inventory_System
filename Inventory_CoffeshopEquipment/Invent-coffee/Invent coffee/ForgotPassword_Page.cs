using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Invent_coffee.Resources;
using MySql.Data.MySqlClient;

namespace Invent_coffee
{
    public partial class ForgotPassword_Page : UserControl
    {
        private MainForm _mainform;
        private connSql conn = new connSql();
        public ForgotPassword_Page(MainForm mainForm)
        {
            InitializeComponent();
            _mainform = mainForm;
        }

        public void ResetPassword(string username, string newPassword)
        {
            using (MySqlConnection connection = conn.connectSql())
            {
                try
                {
                    connection.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                    MySqlCommand checkCmd = new MySqlCommand(checkUserQuery, connection);
                    checkCmd.Parameters.AddWithValue("@username", username);

                    int userExists = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (userExists > 0)
                    {
                        string updatePasswordQuery = "UPDATE users SET password = MD5(@newPassword) WHERE username = @username";
                        MySqlCommand updateCmd = new MySqlCommand(updatePasswordQuery, connection);
                        updateCmd.Parameters.AddWithValue("@newPassword", newPassword);
                        updateCmd.Parameters.AddWithValue("@username", username);

                        updateCmd.ExecuteNonQuery();

                        MessageBox.Show("Password successfully reset.");
                    }
                    else
                    {
                        MessageBox.Show("User not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void continuebtn_Click(object sender, EventArgs e)
        {
            string? username = Username.Text;
            string? password = NewPassword.Text;
            string? newpassword = ConNewPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Username cannot be empty!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Space cannot be empty!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrEmpty(newpassword))
            {
                MessageBox.Show("Space cannot be empty!", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(password != newpassword) 
            {
                MessageBox.Show("Failed login. Please try again.", "Failed Entry", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                ResetPassword(username, password);
                _mainform.ShowLoginPage();
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            _mainform.ShowLoginPage();
        }

        private void ShowPassword_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword_checkBox.Checked)
            {
                NewPassword.PasswordChar = '\0';
                ConNewPassword.PasswordChar = '\0';
            }
            else
            {
                NewPassword.PasswordChar = '*';
                ConNewPassword.PasswordChar = '*';
            }
        }

        private void NewPassword_TextChanged(object sender, EventArgs e)
        {
            NewPassword.PasswordChar = '*';
        }

        private void ConNewPassword_TextChanged(object sender, EventArgs e)
        {
            ConNewPassword.PasswordChar = '*';
        }
    }
}
