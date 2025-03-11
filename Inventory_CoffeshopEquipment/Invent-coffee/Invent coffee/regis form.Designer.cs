namespace Invent_coffee
{
    partial class regis_form
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
            RegisterShowPassword = new CheckBox();
            RegisterSignUpButton = new Button();
            RegisterUsername = new TextBox();
            RegisterNewPassword = new TextBox();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label4 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            RegisterSinginButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            RegisterConPassword = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // RegisterShowPassword
            // 
            RegisterShowPassword.AutoSize = true;
            RegisterShowPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RegisterShowPassword.Location = new Point(317, 294);
            RegisterShowPassword.Name = "RegisterShowPassword";
            RegisterShowPassword.Size = new Size(129, 24);
            RegisterShowPassword.TabIndex = 12;
            RegisterShowPassword.Text = "Show Password";
            RegisterShowPassword.UseVisualStyleBackColor = true;
            RegisterShowPassword.CheckedChanged += RegisterShowPassword_CheckedChanged;
            // 
            // RegisterSignUpButton
            // 
            RegisterSignUpButton.BackColor = Color.FromArgb(181, 101, 29);
            RegisterSignUpButton.FlatStyle = FlatStyle.Flat;
            RegisterSignUpButton.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterSignUpButton.ForeColor = Color.Transparent;
            RegisterSignUpButton.Location = new Point(317, 362);
            RegisterSignUpButton.Name = "RegisterSignUpButton";
            RegisterSignUpButton.Size = new Size(126, 36);
            RegisterSignUpButton.TabIndex = 11;
            RegisterSignUpButton.Text = "SIGN UP";
            RegisterSignUpButton.UseVisualStyleBackColor = false;
            RegisterSignUpButton.Click += RegisterSignUpButton_Click;
            // 
            // RegisterUsername
            // 
            RegisterUsername.Location = new Point(316, 131);
            RegisterUsername.Name = "RegisterUsername";
            RegisterUsername.Size = new Size(248, 23);
            RegisterUsername.TabIndex = 8;
            // 
            // RegisterNewPassword
            // 
            RegisterNewPassword.Location = new Point(316, 200);
            RegisterNewPassword.Name = "RegisterNewPassword";
            RegisterNewPassword.Size = new Size(248, 23);
            RegisterNewPassword.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cup_15002205;
            pictureBox1.Location = new Point(90, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 129);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 247);
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(25, 390);
            button2.Name = "button2";
            button2.Size = new Size(255, 35);
            button2.TabIndex = 5;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.Location = new Point(66, 358);
            label4.Name = "label4";
            label4.Size = new Size(178, 18);
            label4.TabIndex = 6;
            label4.Text = "Create an Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(371, 38);
            label1.Name = "label1";
            label1.Size = new Size(142, 31);
            label1.TabIndex = 7;
            label1.Text = "REGISTER";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 78, 55);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(RegisterSinginButton);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 450);
            panel1.TabIndex = 13;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.cup_15002205;
            pictureBox2.Location = new Point(77, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(124, 129);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // RegisterSinginButton
            // 
            RegisterSinginButton.BackColor = Color.FromArgb(255, 255, 247);
            RegisterSinginButton.BackgroundImageLayout = ImageLayout.Center;
            RegisterSinginButton.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RegisterSinginButton.Location = new Point(12, 403);
            RegisterSinginButton.Name = "RegisterSinginButton";
            RegisterSinginButton.Size = new Size(255, 35);
            RegisterSinginButton.TabIndex = 0;
            RegisterSinginButton.Text = "SIGN IN";
            RegisterSinginButton.UseVisualStyleBackColor = false;
            RegisterSinginButton.Click += RegisterSinginButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Lucida Sans Typewriter", 11.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(33, 369);
            label2.Name = "label2";
            label2.Size = new Size(215, 17);
            label2.TabIndex = 1;
            label2.Text = "Already have an Account";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(315, 173);
            label3.Name = "label3";
            label3.Size = new Size(131, 18);
            label3.TabIndex = 14;
            label3.Text = "NEW PASSWORD:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(314, 110);
            label5.Name = "label5";
            label5.Size = new Size(91, 18);
            label5.TabIndex = 15;
            label5.Text = "USERNAME:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(313, 237);
            label6.Name = "label6";
            label6.Size = new Size(168, 18);
            label6.TabIndex = 16;
            label6.Text = "CONFIRM PASSWORD:";
            // 
            // RegisterConPassword
            // 
            RegisterConPassword.Location = new Point(317, 265);
            RegisterConPassword.Name = "RegisterConPassword";
            RegisterConPassword.Size = new Size(247, 23);
            RegisterConPassword.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(560, 9);
            label7.Name = "label7";
            label7.Size = new Size(17, 17);
            label7.TabIndex = 17;
            label7.Text = "X";
            // 
            // regis_form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 450);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label3);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(RegisterShowPassword);
            Controls.Add(RegisterSignUpButton);
            Controls.Add(RegisterUsername);
            Controls.Add(RegisterConPassword);
            Controls.Add(RegisterNewPassword);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label1);
            Name = "regis_form";
            Text = "regis_form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox RegisterShowPassword;
        private Button RegisterSignUpButton;
        private TextBox RegisterUsername;
        private TextBox RegisterNewPassword;
        private PictureBox pictureBox1;
        private Button button2;
        private Label label4;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button RegisterSinginButton;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private TextBox RegisterConPassword;
        private Label label7;
    }
}