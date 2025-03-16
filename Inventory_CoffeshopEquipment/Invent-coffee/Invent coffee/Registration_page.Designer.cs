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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cup_15002205;
            pictureBox1.Location = new Point(302, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(72, 64);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // SignUpPage_Label
            // 
            SignUpPage_Label.AutoSize = true;
            SignUpPage_Label.Font = new Font("Century Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpPage_Label.Location = new Point(380, 118);
            SignUpPage_Label.Name = "SignUpPage_Label";
            SignUpPage_Label.Size = new Size(219, 37);
            SignUpPage_Label.TabIndex = 6;
            SignUpPage_Label.Text = "REGISTRATION";
            // 
            // SignUpUsername_Label
            // 
            SignUpUsername_Label.AutoSize = true;
            SignUpUsername_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpUsername_Label.Location = new Point(306, 187);
            SignUpUsername_Label.Name = "SignUpUsername_Label";
            SignUpUsername_Label.Size = new Size(119, 23);
            SignUpUsername_Label.TabIndex = 7;
            SignUpUsername_Label.Text = "USERNAME:";
            // 
            // SignUpUsername_textBox
            // 
            SignUpUsername_textBox.Location = new Point(306, 213);
            SignUpUsername_textBox.Name = "SignUpUsername_textBox";
            SignUpUsername_textBox.Size = new Size(282, 27);
            SignUpUsername_textBox.TabIndex = 8;
            // 
            // SignUpCPassword_Label
            // 
            SignUpCPassword_Label.AutoSize = true;
            SignUpCPassword_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpCPassword_Label.Location = new Point(306, 320);
            SignUpCPassword_Label.Name = "SignUpCPassword_Label";
            SignUpCPassword_Label.Size = new Size(223, 23);
            SignUpCPassword_Label.TabIndex = 17;
            SignUpCPassword_Label.Text = "CONFIRM PASSWORD:";
            // 
            // SignUpCPassword_textBox
            // 
            SignUpCPassword_textBox.Location = new Point(306, 346);
            SignUpCPassword_textBox.Name = "SignUpCPassword_textBox";
            SignUpCPassword_textBox.Size = new Size(282, 27);
            SignUpCPassword_textBox.TabIndex = 16;
            // 
            // SignUpShowPassword_checkBox
            // 
            SignUpShowPassword_checkBox.AutoSize = true;
            SignUpShowPassword_checkBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpShowPassword_checkBox.Location = new Point(349, 379);
            SignUpShowPassword_checkBox.Name = "SignUpShowPassword_checkBox";
            SignUpShowPassword_checkBox.Size = new Size(180, 32);
            SignUpShowPassword_checkBox.TabIndex = 15;
            SignUpShowPassword_checkBox.Text = "Show Password";
            SignUpShowPassword_checkBox.UseVisualStyleBackColor = true;
            // 
            // SignUp_Btn
            // 
            SignUp_Btn.BackColor = Color.FromArgb(181, 101, 29);
            SignUp_Btn.FlatStyle = FlatStyle.Flat;
            SignUp_Btn.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUp_Btn.ForeColor = Color.White;
            SignUp_Btn.Location = new Point(365, 428);
            SignUp_Btn.Name = "SignUp_Btn";
            SignUp_Btn.Size = new Size(145, 43);
            SignUp_Btn.TabIndex = 14;
            SignUp_Btn.Text = "SIGN UP";
            SignUp_Btn.UseVisualStyleBackColor = false;
            SignUp_Btn.Click += SignUp_Btn_Click;
            // 
            // SignUpPassword_Label
            // 
            SignUpPassword_Label.AutoSize = true;
            SignUpPassword_Label.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SignUpPassword_Label.Location = new Point(306, 253);
            SignUpPassword_Label.Name = "SignUpPassword_Label";
            SignUpPassword_Label.Size = new Size(123, 23);
            SignUpPassword_Label.TabIndex = 13;
            SignUpPassword_Label.Text = "PASSWORD:";
            // 
            // SignUpPassword_textBox
            // 
            SignUpPassword_textBox.Location = new Point(306, 279);
            SignUpPassword_textBox.Name = "SignUpPassword_textBox";
            SignUpPassword_textBox.Size = new Size(282, 27);
            SignUpPassword_textBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(574, 11);
            label1.Name = "label1";
            label1.Size = new Size(209, 20);
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
            SignIn_Btn.Location = new Point(789, 6);
            SignIn_Btn.Name = "SignIn_Btn";
            SignIn_Btn.Size = new Size(81, 31);
            SignIn_Btn.TabIndex = 18;
            SignIn_Btn.Text = "SIGN IN";
            SignIn_Btn.UseVisualStyleBackColor = false;
            SignIn_Btn.Click += SignIn_Btn_Click;
            // 
            // Registration_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(111, 78, 55);
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
            Name = "Registration_page";
            Size = new Size(900, 600);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
