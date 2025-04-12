namespace Invent_coffee
{
    partial class ForgotPassword_Page
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword_Page));
            confirm_usr = new Label();
            Username = new TextBox();
            newpass = new Label();
            ConNewPassword = new TextBox();
            confirmnewpass = new Label();
            NewPassword = new TextBox();
            continuebtn = new Button();
            backbtn = new Button();
            ShowPassword_checkBox = new CheckBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // confirm_usr
            // 
            confirm_usr.AutoSize = true;
            confirm_usr.BackColor = Color.Transparent;
            confirm_usr.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_usr.Location = new Point(307, 155);
            confirm_usr.Name = "confirm_usr";
            confirm_usr.Size = new Size(182, 19);
            confirm_usr.TabIndex = 0;
            confirm_usr.Text = "CONFIRM USERNAME";
            // 
            // Username
            // 
            Username.Location = new Point(310, 184);
            Username.Name = "Username";
            Username.Size = new Size(166, 23);
            Username.TabIndex = 1;
            // 
            // newpass
            // 
            newpass.AutoSize = true;
            newpass.BackColor = Color.Transparent;
            newpass.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newpass.Location = new Point(307, 217);
            newpass.Name = "newpass";
            newpass.Size = new Size(138, 19);
            newpass.TabIndex = 2;
            newpass.Text = "NEW PASSWORD";
            // 
            // ConNewPassword
            // 
            ConNewPassword.Location = new Point(310, 303);
            ConNewPassword.Name = "ConNewPassword";
            ConNewPassword.Size = new Size(166, 23);
            ConNewPassword.TabIndex = 3;
            ConNewPassword.TextChanged += ConNewPassword_TextChanged;
            // 
            // confirmnewpass
            // 
            confirmnewpass.AutoSize = true;
            confirmnewpass.BackColor = Color.Transparent;
            confirmnewpass.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirmnewpass.Location = new Point(307, 278);
            confirmnewpass.Name = "confirmnewpass";
            confirmnewpass.Size = new Size(220, 19);
            confirmnewpass.TabIndex = 4;
            confirmnewpass.Text = "CONFIRM NEW PASSWORD";
            // 
            // NewPassword
            // 
            NewPassword.Location = new Point(310, 245);
            NewPassword.Name = "NewPassword";
            NewPassword.Size = new Size(166, 23);
            NewPassword.TabIndex = 5;
            NewPassword.TextChanged += NewPassword_TextChanged;
            // 
            // continuebtn
            // 
            continuebtn.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continuebtn.Location = new Point(310, 364);
            continuebtn.Name = "continuebtn";
            continuebtn.Size = new Size(79, 29);
            continuebtn.TabIndex = 6;
            continuebtn.Text = "CONTINUE";
            continuebtn.TextAlign = ContentAlignment.TopCenter;
            continuebtn.UseVisualStyleBackColor = true;
            continuebtn.Click += continuebtn_Click;
            // 
            // backbtn
            // 
            backbtn.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            backbtn.Location = new Point(413, 363);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(53, 29);
            backbtn.TabIndex = 7;
            backbtn.Text = "BACK";
            backbtn.TextAlign = ContentAlignment.TopCenter;
            backbtn.UseVisualStyleBackColor = true;
            backbtn.Click += backbtn_Click;
            // 
            // ShowPassword_checkBox
            // 
            ShowPassword_checkBox.AutoSize = true;
            ShowPassword_checkBox.BackColor = Color.Transparent;
            ShowPassword_checkBox.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPassword_checkBox.Location = new Point(310, 334);
            ShowPassword_checkBox.Margin = new Padding(3, 2, 3, 2);
            ShowPassword_checkBox.Name = "ShowPassword_checkBox";
            ShowPassword_checkBox.Size = new Size(130, 23);
            ShowPassword_checkBox.TabIndex = 13;
            ShowPassword_checkBox.Text = "Show Password";
            ShowPassword_checkBox.UseVisualStyleBackColor = false;
            ShowPassword_checkBox.CheckedChanged += ShowPassword_checkBox_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.Location = new Point(340, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // ForgotPassword_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(pictureBox1);
            Controls.Add(ShowPassword_checkBox);
            Controls.Add(backbtn);
            Controls.Add(continuebtn);
            Controls.Add(NewPassword);
            Controls.Add(confirmnewpass);
            Controls.Add(ConNewPassword);
            Controls.Add(newpass);
            Controls.Add(Username);
            Controls.Add(confirm_usr);
            Name = "ForgotPassword_Page";
            Size = new Size(788, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label confirm_usr;
        private TextBox Username;
        private Label newpass;
        private TextBox ConNewPassword;
        private Label confirmnewpass;
        private TextBox NewPassword;
        private Button continuebtn;
        private Button backbtn;
        private CheckBox ShowPassword_checkBox;
        private PictureBox pictureBox1;
    }
}
