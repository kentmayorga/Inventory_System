namespace Invent_coffee
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            UsernameSignIn_txtBox = new TextBox();
            Login_Panel = new Panel();
            SignUpLabel = new Label();
            RegistrationBtn = new Button();
            ShowPassword_checkBox = new CheckBox();
            LoginBtn = new Button();
            BrandName_Label = new Label();
            BrandPicBox = new PictureBox();
            Password_Label = new Label();
            Username_Label = new Label();
            PasswordSignIn_txtBox = new TextBox();
            Registration_Panel = new Panel();
            SignUpCPassword_Label = new Label();
            SignUpCPassword_textBox = new TextBox();
            label1 = new Label();
            SignIn_Btn = new Button();
            SignUpShowPassword_checkBox = new CheckBox();
            SignUp_Btn = new Button();
            SignUpPage_Label = new Label();
            pictureBox1 = new PictureBox();
            SignUpPassword_Label = new Label();
            SignUpUsername_Label = new Label();
            SignUpPassword_textBox = new TextBox();
            SignUpUsername_textBox = new TextBox();
            Login_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)BrandPicBox).BeginInit();
            Registration_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // UsernameSignIn_txtBox
            // 
            UsernameSignIn_txtBox.Location = new Point(287, 246);
            UsernameSignIn_txtBox.Name = "UsernameSignIn_txtBox";
            UsernameSignIn_txtBox.Size = new Size(282, 27);
            UsernameSignIn_txtBox.TabIndex = 0;
            UsernameSignIn_txtBox.TextChanged += UsernameSignIn_txtBox_TextChanged;
            // 
            // Login_Panel
            // 
            Login_Panel.Anchor = AnchorStyles.None;
            Login_Panel.BackColor = Color.FromArgb(111, 78, 55);
            Login_Panel.Controls.Add(SignUpLabel);
            Login_Panel.Controls.Add(RegistrationBtn);
            Login_Panel.Controls.Add(ShowPassword_checkBox);
            Login_Panel.Controls.Add(LoginBtn);
            Login_Panel.Controls.Add(BrandName_Label);
            Login_Panel.Controls.Add(BrandPicBox);
            Login_Panel.Controls.Add(Password_Label);
            Login_Panel.Controls.Add(Username_Label);
            Login_Panel.Controls.Add(PasswordSignIn_txtBox);
            Login_Panel.Controls.Add(UsernameSignIn_txtBox);
            Login_Panel.Location = new Point(1, 2);
            Login_Panel.Name = "Login_Panel";
            Login_Panel.Size = new Size(885, 553);
            Login_Panel.TabIndex = 1;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpLabel.Location = new Point(677, 12);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(107, 20);
            SignUpLabel.TabIndex = 9;
            SignUpLabel.Text = "No Account?";
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.BackColor = Color.FromArgb(111, 78, 55);
            RegistrationBtn.FlatAppearance.BorderSize = 0;
            RegistrationBtn.FlatStyle = FlatStyle.Flat;
            RegistrationBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrationBtn.ForeColor = Color.Transparent;
            RegistrationBtn.Location = new Point(790, 7);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(81, 31);
            RegistrationBtn.TabIndex = 8;
            RegistrationBtn.Text = "SIGN UP";
            RegistrationBtn.UseVisualStyleBackColor = false;
            RegistrationBtn.Click += RegistrationBtn_Click;
            // 
            // ShowPassword_checkBox
            // 
            ShowPassword_checkBox.AutoSize = true;
            ShowPassword_checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPassword_checkBox.Location = new Point(296, 342);
            ShowPassword_checkBox.Name = "ShowPassword_checkBox";
            ShowPassword_checkBox.Size = new Size(180, 32);
            ShowPassword_checkBox.TabIndex = 7;
            ShowPassword_checkBox.Text = "Show Password";
            ShowPassword_checkBox.UseVisualStyleBackColor = true;
            ShowPassword_checkBox.CheckedChanged += ShowPassword_checkBox_CheckedChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(181, 101, 29);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(354, 395);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(145, 43);
            LoginBtn.TabIndex = 6;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // BrandName_Label
            // 
            BrandName_Label.AutoSize = true;
            BrandName_Label.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BrandName_Label.Location = new Point(260, 153);
            BrandName_Label.Name = "BrandName_Label";
            BrandName_Label.Size = new Size(357, 37);
            BrandName_Label.TabIndex = 5;
            BrandName_Label.Text = "Coffee Shop Equipment";
            // 
            // BrandPicBox
            // 
            BrandPicBox.Image = Properties.Resources.cup_15002205;
            BrandPicBox.Location = new Point(354, 31);
            BrandPicBox.Name = "BrandPicBox";
            BrandPicBox.Size = new Size(138, 119);
            BrandPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            BrandPicBox.TabIndex = 4;
            BrandPicBox.TabStop = false;
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_Label.Location = new Point(287, 283);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(123, 23);
            Password_Label.TabIndex = 3;
            Password_Label.Text = "PASSWORD:";
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_Label.Location = new Point(287, 220);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(119, 23);
            Username_Label.TabIndex = 2;
            Username_Label.Text = "USERNAME:";
            // 
            // PasswordSignIn_txtBox
            // 
            PasswordSignIn_txtBox.Location = new Point(287, 309);
            PasswordSignIn_txtBox.Name = "PasswordSignIn_txtBox";
            PasswordSignIn_txtBox.Size = new Size(282, 27);
            PasswordSignIn_txtBox.TabIndex = 1;
            PasswordSignIn_txtBox.TextChanged += PasswordSignIn_txtBox_TextChanged;
            // 
            // Registration_Panel
            // 
            Registration_Panel.Anchor = AnchorStyles.None;
            Registration_Panel.BackColor = Color.FromArgb(111, 78, 55);
            Registration_Panel.Controls.Add(SignUpCPassword_Label);
            Registration_Panel.Controls.Add(SignUpCPassword_textBox);
            Registration_Panel.Controls.Add(label1);
            Registration_Panel.Controls.Add(SignIn_Btn);
            Registration_Panel.Controls.Add(SignUpShowPassword_checkBox);
            Registration_Panel.Controls.Add(SignUp_Btn);
            Registration_Panel.Controls.Add(SignUpPage_Label);
            Registration_Panel.Controls.Add(pictureBox1);
            Registration_Panel.Controls.Add(SignUpPassword_Label);
            Registration_Panel.Controls.Add(SignUpUsername_Label);
            Registration_Panel.Controls.Add(SignUpPassword_textBox);
            Registration_Panel.Controls.Add(SignUpUsername_textBox);
            Registration_Panel.Location = new Point(1, -1);
            Registration_Panel.Name = "Registration_Panel";
            Registration_Panel.Size = new Size(885, 553);
            Registration_Panel.TabIndex = 2;
            // 
            // SignUpCPassword_Label
            // 
            SignUpCPassword_Label.AutoSize = true;
            SignUpCPassword_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpCPassword_Label.Location = new Point(305, 283);
            SignUpCPassword_Label.Name = "SignUpCPassword_Label";
            SignUpCPassword_Label.Size = new Size(223, 23);
            SignUpCPassword_Label.TabIndex = 11;
            SignUpCPassword_Label.Text = "CONFIRM PASSWORD:";
            // 
            // SignUpCPassword_textBox
            // 
            SignUpCPassword_textBox.Location = new Point(305, 309);
            SignUpCPassword_textBox.Name = "SignUpCPassword_textBox";
            SignUpCPassword_textBox.Size = new Size(282, 27);
            SignUpCPassword_textBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(575, 12);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
            label1.TabIndex = 9;
            label1.Text = "Already have an Account?";
            // 
            // SignIn_Btn
            // 
            SignIn_Btn.BackColor = Color.FromArgb(111, 78, 55);
            SignIn_Btn.FlatAppearance.BorderSize = 0;
            SignIn_Btn.FlatStyle = FlatStyle.Flat;
            SignIn_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignIn_Btn.ForeColor = Color.Transparent;
            SignIn_Btn.Location = new Point(790, 7);
            SignIn_Btn.Name = "SignIn_Btn";
            SignIn_Btn.Size = new Size(81, 31);
            SignIn_Btn.TabIndex = 8;
            SignIn_Btn.Text = "SIGN IN";
            SignIn_Btn.UseVisualStyleBackColor = false;
            SignIn_Btn.Click += SignIn_Btn_Click;
            // 
            // SignUpShowPassword_checkBox
            // 
            SignUpShowPassword_checkBox.AutoSize = true;
            SignUpShowPassword_checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpShowPassword_checkBox.Location = new Point(348, 342);
            SignUpShowPassword_checkBox.Name = "SignUpShowPassword_checkBox";
            SignUpShowPassword_checkBox.Size = new Size(180, 32);
            SignUpShowPassword_checkBox.TabIndex = 7;
            SignUpShowPassword_checkBox.Text = "Show Password";
            SignUpShowPassword_checkBox.UseVisualStyleBackColor = true;
            // 
            // SignUp_Btn
            // 
            SignUp_Btn.BackColor = Color.FromArgb(181, 101, 29);
            SignUp_Btn.FlatStyle = FlatStyle.Flat;
            SignUp_Btn.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp_Btn.ForeColor = Color.White;
            SignUp_Btn.Location = new Point(364, 391);
            SignUp_Btn.Name = "SignUp_Btn";
            SignUp_Btn.Size = new Size(145, 43);
            SignUp_Btn.TabIndex = 6;
            SignUp_Btn.Text = "SIGN UP";
            SignUp_Btn.UseVisualStyleBackColor = false;
            SignUp_Btn.Click += SignUp_Btn_Click;
            // 
            // SignUpPage_Label
            // 
            SignUpPage_Label.AutoSize = true;
            SignUpPage_Label.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpPage_Label.Location = new Point(383, 95);
            SignUpPage_Label.Name = "SignUpPage_Label";
            SignUpPage_Label.Size = new Size(219, 37);
            SignUpPage_Label.TabIndex = 5;
            SignUpPage_Label.Text = "REGISTRATION";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cup_15002205;
            pictureBox1.Location = new Point(305, 68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // SignUpPassword_Label
            // 
            SignUpPassword_Label.AutoSize = true;
            SignUpPassword_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpPassword_Label.Location = new Point(305, 216);
            SignUpPassword_Label.Name = "SignUpPassword_Label";
            SignUpPassword_Label.Size = new Size(123, 23);
            SignUpPassword_Label.TabIndex = 3;
            SignUpPassword_Label.Text = "PASSWORD:";
            // 
            // SignUpUsername_Label
            // 
            SignUpUsername_Label.AutoSize = true;
            SignUpUsername_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpUsername_Label.Location = new Point(309, 151);
            SignUpUsername_Label.Name = "SignUpUsername_Label";
            SignUpUsername_Label.Size = new Size(119, 23);
            SignUpUsername_Label.TabIndex = 2;
            SignUpUsername_Label.Text = "USERNAME:";
            // 
            // SignUpPassword_textBox
            // 
            SignUpPassword_textBox.Location = new Point(305, 242);
            SignUpPassword_textBox.Name = "SignUpPassword_textBox";
            SignUpPassword_textBox.Size = new Size(282, 27);
            SignUpPassword_textBox.TabIndex = 1;
            // 
            // SignUpUsername_textBox
            // 
            SignUpUsername_textBox.Location = new Point(308, 177);
            SignUpUsername_textBox.Name = "SignUpUsername_textBox";
            SignUpUsername_textBox.Size = new Size(282, 27);
            SignUpUsername_textBox.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 553);
            Controls.Add(Registration_Panel);
            Controls.Add(Login_Panel);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            Login_Panel.ResumeLayout(false);
            Login_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)BrandPicBox).EndInit();
            Registration_Panel.ResumeLayout(false);
            Registration_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TextBox UsernameSignIn_txtBox;
        private Panel Login_Panel;
        private Label Username_Label;
        private TextBox PasswordSignIn_txtBox;
        private Label Password_Label;
        private PictureBox BrandPicBox;
        private Label BrandName_Label;
        private Button LoginBtn;
        private CheckBox ShowPassword_checkBox;
        private Button RegistrationBtn;
        private Label SignUpLabel;
        private Panel Registration_Panel;
        private Label label1;
        private Button SignIn_Btn;
        private CheckBox SignUpShowPassword_checkBox;
        private Button SignUp_Btn;
        private Label SignUpPage_Label;
        private PictureBox pictureBox1;
        private Label SignUpPassword_Label;
        private Label SignUpUsername_Label;
        private TextBox SignUpPassword_textBox;
        private TextBox SignUpUsername_textBox;
        private Label SignUpCPassword_Label;
        private TextBox SignUpCPassword_textBox;
    }
}