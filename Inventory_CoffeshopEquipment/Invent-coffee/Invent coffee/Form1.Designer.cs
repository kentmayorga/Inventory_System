
namespace Invent_coffee
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            button2 = new Button();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            SignInPassword = new TextBox();
            label3 = new Label();
            UsernameSignIn = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 78, 55);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label4);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(292, 450);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Lucida Sans Unicode", 15.75F, FontStyle.Bold);
            label6.Location = new Point(7, 179);
            label6.Name = "label6";
            label6.Size = new Size(274, 25);
            label6.TabIndex = 3;
            label6.Text = "Coffee Shop Equipment";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cup_15002205;
            pictureBox1.Location = new Point(77, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(124, 129);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 255, 247);
            button2.Font = new Font("Franklin Gothic Book", 9.75F, FontStyle.Bold);
            button2.Location = new Point(12, 403);
            button2.Name = "button2";
            button2.Size = new Size(255, 35);
            button2.TabIndex = 0;
            button2.Text = "REGISTER";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold | FontStyle.Underline);
            label4.Location = new Point(53, 371);
            label4.Name = "label4";
            label4.Size = new Size(178, 18);
            label4.TabIndex = 1;
            label4.Text = "Create an Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Sans Typewriter", 20.25F, FontStyle.Bold);
            label1.Location = new Point(303, 53);
            label1.Name = "label1";
            label1.Size = new Size(126, 31);
            label1.TabIndex = 1;
            label1.Text = "SIGN IN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label2.Location = new Point(303, 123);
            label2.Name = "label2";
            label2.Size = new Size(91, 18);
            label2.TabIndex = 1;
            label2.Text = "USERNAME:";
            // 
            // SignInPassword
            // 
            SignInPassword.Location = new Point(303, 213);
            SignInPassword.Name = "SignInPassword";
            SignInPassword.Size = new Size(247, 23);
            SignInPassword.TabIndex = 2;
            SignInPassword.TextChanged += SignInPassword_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold);
            label3.Location = new Point(303, 186);
            label3.Name = "label3";
            label3.Size = new Size(94, 18);
            label3.TabIndex = 1;
            label3.Text = "PASSWORD:";
            // 
            // UsernameSignIn
            // 
            UsernameSignIn.Location = new Point(303, 144);
            UsernameSignIn.Name = "UsernameSignIn";
            UsernameSignIn.Size = new Size(247, 23);
            UsernameSignIn.TabIndex = 2;
            UsernameSignIn.TextChanged += UsernameSignIn_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(181, 101, 29);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Sans Typewriter", 12F, FontStyle.Bold);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(303, 286);
            button1.Name = "button1";
            button1.Size = new Size(126, 36);
            button1.TabIndex = 3;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 11.25F);
            checkBox1.Location = new Point(305, 242);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(129, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Symbol", 9.75F, FontStyle.Bold);
            label5.Location = new Point(563, 9);
            label5.Name = "label5";
            label5.Size = new Size(17, 17);
            label5.TabIndex = 5;
            label5.Text = "X";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(589, 450);
            Controls.Add(label5);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(UsernameSignIn);
            Controls.Add(SignInPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox SignInPassword;
        private Label label3;
        private TextBox UsernameSignIn;
        private Button button2;
        private Button button1;
        private Label label4;
        private PictureBox pictureBox1;
        private CheckBox checkBox1;
        private Label label5;
        private Label label6;
    }
}
