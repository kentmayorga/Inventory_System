namespace Invent_coffee
{
    partial class Login_page
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_page));
            SignUpPage_Label = new Label();
            BrandPicBox = new PictureBox();
            Username_Label = new Label();
            Password_Label = new Label();
            Username_txtBox = new TextBox();
            Password_txtBox = new TextBox();
            ShowPassword_checkBox = new CheckBox();
            LoginBtn = new Button();
            SignUpLabel = new Label();
            RegistrationBtn = new Button();
            errorProviderUsername = new ErrorProvider(components);
            ErrorMessageLabel = new Label();
            ForgotpassLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)BrandPicBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsername).BeginInit();
            SuspendLayout();
            // 
            // SignUpPage_Label
            // 
            SignUpPage_Label.AutoSize = true;
            SignUpPage_Label.BackColor = Color.Transparent;
            SignUpPage_Label.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpPage_Label.ForeColor = Color.FromArgb(111, 78, 55);
            SignUpPage_Label.Location = new Point(257, 143);
            SignUpPage_Label.Name = "SignUpPage_Label";
            SignUpPage_Label.Size = new Size(284, 28);
            SignUpPage_Label.TabIndex = 6;
            SignUpPage_Label.Text = "Coffee Shop Equipment";
            // 
            // BrandPicBox
            // 
            BrandPicBox.Image = Properties.Resources.cup_15002205;
            BrandPicBox.Location = new Point(334, 52);
            BrandPicBox.Margin = new Padding(3, 2, 3, 2);
            BrandPicBox.Name = "BrandPicBox";
            BrandPicBox.Size = new Size(121, 89);
            BrandPicBox.SizeMode = PictureBoxSizeMode.Zoom;
            BrandPicBox.TabIndex = 7;
            BrandPicBox.TabStop = false;
            // 
            // Username_Label
            // 
            Username_Label.AutoSize = true;
            Username_Label.BackColor = Color.Transparent;
            Username_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Username_Label.Location = new Point(274, 197);
            Username_Label.Name = "Username_Label";
            Username_Label.Size = new Size(94, 19);
            Username_Label.TabIndex = 8;
            Username_Label.Text = "USERNAME:";
            // 
            // Password_Label
            // 
            Password_Label.AutoSize = true;
            Password_Label.BackColor = Color.Transparent;
            Password_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_Label.Location = new Point(274, 247);
            Password_Label.Name = "Password_Label";
            Password_Label.Size = new Size(97, 19);
            Password_Label.TabIndex = 9;
            Password_Label.Text = "PASSWORD:";
            // 
            // Username_txtBox
            // 
            Username_txtBox.Location = new Point(274, 217);
            Username_txtBox.Margin = new Padding(3, 2, 3, 2);
            Username_txtBox.Name = "Username_txtBox";
            Username_txtBox.Size = new Size(247, 23);
            Username_txtBox.TabIndex = 10;
            Username_txtBox.TextChanged += Username_txtBox_TextChanged;
            // 
            // Password_txtBox
            // 
            Password_txtBox.Location = new Point(274, 266);
            Password_txtBox.Margin = new Padding(3, 2, 3, 2);
            Password_txtBox.Name = "Password_txtBox";
            Password_txtBox.Size = new Size(247, 23);
            Password_txtBox.TabIndex = 11;
            Password_txtBox.TextChanged += Password_txtBox_TextChanged;
            // 
            // ShowPassword_checkBox
            // 
            ShowPassword_checkBox.AutoSize = true;
            ShowPassword_checkBox.BackColor = Color.Transparent;
            ShowPassword_checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ShowPassword_checkBox.Location = new Point(289, 291);
            ShowPassword_checkBox.Margin = new Padding(3, 2, 3, 2);
            ShowPassword_checkBox.Name = "ShowPassword_checkBox";
            ShowPassword_checkBox.Size = new Size(147, 25);
            ShowPassword_checkBox.TabIndex = 12;
            ShowPassword_checkBox.Text = "Show Password";
            ShowPassword_checkBox.UseVisualStyleBackColor = false;
            ShowPassword_checkBox.CheckedChanged += ShowPassword_checkBox_CheckedChanged;
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(181, 101, 29);
            LoginBtn.FlatStyle = FlatStyle.Flat;
            LoginBtn.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.White;
            LoginBtn.Location = new Point(334, 320);
            LoginBtn.Margin = new Padding(3, 2, 3, 2);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(118, 32);
            LoginBtn.TabIndex = 13;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
            // 
            // SignUpLabel
            // 
            SignUpLabel.AutoSize = true;
            SignUpLabel.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SignUpLabel.Location = new Point(571, 8);
            SignUpLabel.Name = "SignUpLabel";
            SignUpLabel.Size = new Size(87, 17);
            SignUpLabel.TabIndex = 14;
            SignUpLabel.Text = "No Account?";
            // 
            // RegistrationBtn
            // 
            RegistrationBtn.BackColor = Color.FromArgb(111, 78, 55);
            RegistrationBtn.FlatAppearance.BorderSize = 0;
            RegistrationBtn.FlatStyle = FlatStyle.Flat;
            RegistrationBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegistrationBtn.ForeColor = Color.Transparent;
            RegistrationBtn.Location = new Point(678, 4);
            RegistrationBtn.Margin = new Padding(3, 2, 3, 2);
            RegistrationBtn.Name = "RegistrationBtn";
            RegistrationBtn.Size = new Size(71, 23);
            RegistrationBtn.TabIndex = 15;
            RegistrationBtn.Text = "SIGN UP";
            RegistrationBtn.UseVisualStyleBackColor = false;
            RegistrationBtn.Click += RegistrationBtn_Click;
            // 
            // errorProviderUsername
            // 
            errorProviderUsername.ContainerControl = this;
            // 
            // ErrorMessageLabel
            // 
            ErrorMessageLabel.AutoSize = true;
            ErrorMessageLabel.ForeColor = Color.Red;
            errorProviderUsername.SetIconAlignment(ErrorMessageLabel, ErrorIconAlignment.MiddleLeft);
            ErrorMessageLabel.Location = new Point(274, 382);
            ErrorMessageLabel.Name = "ErrorMessageLabel";
            ErrorMessageLabel.Size = new Size(38, 15);
            ErrorMessageLabel.TabIndex = 16;
            ErrorMessageLabel.Text = "label1";
            // 
            // ForgotpassLabel
            // 
            ForgotpassLabel.ActiveLinkColor = Color.Black;
            ForgotpassLabel.AutoSize = true;
            ForgotpassLabel.LinkColor = Color.Black;
            ForgotpassLabel.Location = new Point(342, 354);
            ForgotpassLabel.Name = "ForgotpassLabel";
            ForgotpassLabel.Size = new Size(100, 15);
            ForgotpassLabel.TabIndex = 17;
            ForgotpassLabel.TabStop = true;
            ForgotpassLabel.Text = "Forgot password?";
            ForgotpassLabel.LinkClicked += ForgotpassLabel_LinkClicked;
            // 
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(ForgotpassLabel);
            Controls.Add(ErrorMessageLabel);
            Controls.Add(RegistrationBtn);
            Controls.Add(SignUpLabel);
            Controls.Add(LoginBtn);
            Controls.Add(ShowPassword_checkBox);
            Controls.Add(Password_txtBox);
            Controls.Add(Username_txtBox);
            Controls.Add(Password_Label);
            Controls.Add(Username_Label);
            Controls.Add(BrandPicBox);
            Controls.Add(SignUpPage_Label);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login_page";
            Size = new Size(788, 450);
            ((System.ComponentModel.ISupportInitialize)BrandPicBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderUsername).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SignUpPage_Label;
        private PictureBox BrandPicBox;
        private Label Username_Label;
        private Label Password_Label;
        private TextBox Username_txtBox;
        private TextBox Password_txtBox;
        private CheckBox ShowPassword_checkBox;
        private Button LoginBtn;
        private Label SignUpLabel;
        private Button RegistrationBtn;
        private ErrorProvider errorProviderUsername;
        private Label ErrorMessageLabel;
        private LinkLabel ForgotpassLabel;
    }
}
