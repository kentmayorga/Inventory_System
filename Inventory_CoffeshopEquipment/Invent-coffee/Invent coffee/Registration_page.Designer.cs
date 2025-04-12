namespace Invent_coffee
{
    partial class Registration_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration_page));
            pictureBox1 = new PictureBox();
            SignUpPage_Label = new Label();
            SignUpUsername_Label = new Label();
            SignUpUsername_textBox = new TextBox();
            SignUpCPassword_Label = new Label();
            SignUpCPassword_textBox = new TextBox();
            SignUpShowPassword_checkBox = new CheckBox();
            SignUp_Btn = new Button();
            SignUpPassword_Label = new Label();
            SignUpPassword_textBox = new TextBox();
            label1 = new Label();
            SignIn_Btn = new Button();
            ErrorProviderSigninUsername = new ErrorProvider(components);
            ErrorLabelSignUp = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderSigninUsername).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cup_15002205;
            pictureBox1.Location = new Point(264, 68);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SignUpPage_Label
            // 
            SignUpPage_Label.AutoSize = true;
            SignUpPage_Label.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpPage_Label.Location = new Point(332, 88);
            SignUpPage_Label.Name = "SignUpPage_Label";
            SignUpPage_Label.Size = new Size(174, 28);
            SignUpPage_Label.TabIndex = 6;
            SignUpPage_Label.Text = "REGISTRATION";
            // 
            // SignUpUsername_Label
            // 
            SignUpUsername_Label.AutoSize = true;
            SignUpUsername_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpUsername_Label.Location = new Point(268, 140);
            SignUpUsername_Label.Name = "SignUpUsername_Label";
            SignUpUsername_Label.Size = new Size(94, 19);
            SignUpUsername_Label.TabIndex = 7;
            SignUpUsername_Label.Text = "USERNAME:";
            // 
            // SignUpUsername_textBox
            // 
            SignUpUsername_textBox.Location = new Point(268, 160);
            SignUpUsername_textBox.Margin = new Padding(3, 2, 3, 2);
            SignUpUsername_textBox.Name = "SignUpUsername_textBox";
            SignUpUsername_textBox.Size = new Size(247, 23);
            SignUpUsername_textBox.TabIndex = 8;
            // 
            // SignUpCPassword_Label
            // 
            SignUpCPassword_Label.AutoSize = true;
            SignUpCPassword_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpCPassword_Label.Location = new Point(268, 240);
            SignUpCPassword_Label.Name = "SignUpCPassword_Label";
            SignUpCPassword_Label.Size = new Size(173, 19);
            SignUpCPassword_Label.TabIndex = 17;
            SignUpCPassword_Label.Text = "CONFIRM PASSWORD:";
            // 
            // SignUpCPassword_textBox
            // 
            SignUpCPassword_textBox.Location = new Point(268, 260);
            SignUpCPassword_textBox.Margin = new Padding(3, 2, 3, 2);
            SignUpCPassword_textBox.Name = "SignUpCPassword_textBox";
            SignUpCPassword_textBox.Size = new Size(247, 23);
            SignUpCPassword_textBox.TabIndex = 16;
            SignUpCPassword_textBox.TextChanged += SignUpCPassword_textBox_TextChanged;
            // 
            // SignUpShowPassword_checkBox
            // 
            SignUpShowPassword_checkBox.AutoSize = true;
            SignUpShowPassword_checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpShowPassword_checkBox.Location = new Point(305, 284);
            SignUpShowPassword_checkBox.Margin = new Padding(3, 2, 3, 2);
            SignUpShowPassword_checkBox.Name = "SignUpShowPassword_checkBox";
            SignUpShowPassword_checkBox.Size = new Size(147, 25);
            SignUpShowPassword_checkBox.TabIndex = 15;
            SignUpShowPassword_checkBox.Text = "Show Password";
            SignUpShowPassword_checkBox.UseVisualStyleBackColor = true;
            SignUpShowPassword_checkBox.CheckedChanged += SignUpShowPassword_checkBox_CheckedChanged;
            // 
            // SignUp_Btn
            // 
            SignUp_Btn.BackColor = Color.FromArgb(181, 101, 29);
            SignUp_Btn.FlatStyle = FlatStyle.Flat;
            SignUp_Btn.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp_Btn.ForeColor = Color.White;
            SignUp_Btn.Location = new Point(319, 321);
            SignUp_Btn.Margin = new Padding(3, 2, 3, 2);
            SignUp_Btn.Name = "SignUp_Btn";
            SignUp_Btn.Size = new Size(127, 32);
            SignUp_Btn.TabIndex = 14;
            SignUp_Btn.Text = "SIGN UP";
            SignUp_Btn.UseVisualStyleBackColor = false;
            SignUp_Btn.Click += SignUp_Btn_Click;
            // 
            // SignUpPassword_Label
            // 
            SignUpPassword_Label.AutoSize = true;
            SignUpPassword_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpPassword_Label.Location = new Point(268, 190);
            SignUpPassword_Label.Name = "SignUpPassword_Label";
            SignUpPassword_Label.Size = new Size(97, 19);
            SignUpPassword_Label.TabIndex = 13;
            SignUpPassword_Label.Text = "PASSWORD:";
            // 
            // SignUpPassword_textBox
            // 
            SignUpPassword_textBox.Location = new Point(268, 209);
            SignUpPassword_textBox.Margin = new Padding(3, 2, 3, 2);
            SignUpPassword_textBox.Name = "SignUpPassword_textBox";
            SignUpPassword_textBox.Size = new Size(247, 23);
            SignUpPassword_textBox.TabIndex = 12;
            SignUpPassword_textBox.TextChanged += SignUpPassword_textBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(502, 8);
            label1.Name = "label1";
            label1.Size = new Size(168, 17);
            label1.TabIndex = 19;
            label1.Text = "Already have an Account?";
            // 
            // SignIn_Btn
            // 
            SignIn_Btn.BackColor = Color.FromArgb(111, 78, 55);
            SignIn_Btn.FlatAppearance.BorderSize = 0;
            SignIn_Btn.FlatStyle = FlatStyle.Flat;
            SignIn_Btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignIn_Btn.ForeColor = Color.Transparent;
            SignIn_Btn.Location = new Point(690, 4);
            SignIn_Btn.Margin = new Padding(3, 2, 3, 2);
            SignIn_Btn.Name = "SignIn_Btn";
            SignIn_Btn.Size = new Size(71, 23);
            SignIn_Btn.TabIndex = 18;
            SignIn_Btn.Text = "SIGN IN";
            SignIn_Btn.UseVisualStyleBackColor = false;
            SignIn_Btn.Click += SignIn_Btn_Click;
            // 
            // ErrorProviderSigninUsername
            // 
            ErrorProviderSigninUsername.ContainerControl = this;
            // 
            // ErrorLabelSignUp
            // 
            ErrorLabelSignUp.AutoSize = true;
            ErrorLabelSignUp.ForeColor = Color.Red;
            ErrorLabelSignUp.Location = new Point(268, 358);
            ErrorLabelSignUp.Name = "ErrorLabelSignUp";
            ErrorLabelSignUp.Size = new Size(38, 15);
            ErrorLabelSignUp.TabIndex = 20;
            ErrorLabelSignUp.Text = "label2";
            // 
            // Registration_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(ErrorLabelSignUp);
            Controls.Add(label1);
            Controls.Add(SignIn_Btn);
            Controls.Add(SignUpCPassword_Label);
            Controls.Add(SignUpCPassword_textBox);
            Controls.Add(SignUpShowPassword_checkBox);
            Controls.Add(SignUp_Btn);
            Controls.Add(SignUpPassword_Label);
            Controls.Add(SignUpPassword_textBox);
            Controls.Add(SignUpUsername_textBox);
            Controls.Add(SignUpUsername_Label);
            Controls.Add(SignUpPage_Label);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Registration_page";
            Size = new Size(788, 450);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)ErrorProviderSigninUsername).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label SignUpPage_Label;
        private Label SignUpUsername_Label;
        private TextBox SignUpUsername_textBox;
        private Label SignUpCPassword_Label;
        private TextBox SignUpCPassword_textBox;
        private CheckBox SignUpShowPassword_checkBox;
        private Button SignUp_Btn;
        private Label SignUpPassword_Label;
        private TextBox SignUpPassword_textBox;
        private Label label1;
        private Button SignIn_Btn;
        private ErrorProvider ErrorProviderSigninUsername;
        private Label ErrorLabelSignUp;
    }
}
