namespace Invent_coffee
{
    partial class Home_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            Navigations = new Panel();
            Username = new Label();
            LocationButton = new Button();
            ShopButton = new Button();
            LogOutButton = new Button();
            pictureBox1 = new PictureBox();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label5 = new Label();
            button1 = new Button();
            Navigations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Navigations
            // 
            Navigations.BackColor = Color.FromArgb(111, 78, 55);
            Navigations.Controls.Add(Username);
            Navigations.Controls.Add(LocationButton);
            Navigations.Controls.Add(ShopButton);
            Navigations.Controls.Add(LogOutButton);
            Navigations.Dock = DockStyle.Top;
            Navigations.ImeMode = ImeMode.Disable;
            Navigations.Location = new Point(0, 0);
            Navigations.Name = "Navigations";
            Navigations.Size = new Size(771, 49);
            Navigations.TabIndex = 0;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.ForeColor = Color.White;
            Username.Location = new Point(627, 16);
            Username.Name = "Username";
            Username.Size = new Size(32, 15);
            Username.TabIndex = 8;
            Username.Text = "label";
            // 
            // LocationButton
            // 
            LocationButton.AllowDrop = true;
            LocationButton.BackColor = Color.Transparent;
            LocationButton.BackgroundImage = (Image)resources.GetObject("LocationButton.BackgroundImage");
            LocationButton.BackgroundImageLayout = ImageLayout.Stretch;
            LocationButton.FlatAppearance.BorderSize = 0;
            LocationButton.FlatStyle = FlatStyle.Flat;
            LocationButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LocationButton.ForeColor = Color.White;
            LocationButton.Location = new Point(76, 2);
            LocationButton.Name = "LocationButton";
            LocationButton.Size = new Size(58, 42);
            LocationButton.TabIndex = 7;
            LocationButton.UseVisualStyleBackColor = false;
            // 
            // ShopButton
            // 
            ShopButton.AllowDrop = true;
            ShopButton.BackColor = Color.Transparent;
            ShopButton.BackgroundImage = (Image)resources.GetObject("ShopButton.BackgroundImage");
            ShopButton.BackgroundImageLayout = ImageLayout.Stretch;
            ShopButton.FlatAppearance.BorderSize = 0;
            ShopButton.FlatAppearance.MouseOverBackColor = Color.Red;
            ShopButton.FlatStyle = FlatStyle.Flat;
            ShopButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShopButton.ForeColor = Color.White;
            ShopButton.Location = new Point(13, 2);
            ShopButton.Name = "ShopButton";
            ShopButton.Size = new Size(48, 44);
            ShopButton.TabIndex = 6;
            ShopButton.UseVisualStyleBackColor = false;
            ShopButton.Click += ShopButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(685, 10);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(59, 28);
            LogOutButton.TabIndex = 5;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ab6ea7db_513a_4397_9cbd_e99ba6a30e0f1;
            pictureBox1.Location = new Point(41, 336);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(699, 352);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Trebuchet MS", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.Location = new Point(235, 136);
            label23.Name = "label23";
            label23.Size = new Size(289, 46);
            label23.TabIndex = 2;
            label23.Text = "MANGI INDIFICA";
            label23.Click += label1_Click;
            // 
            // label24
            // 
            label24.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label24.Location = new Point(29, 198);
            label24.Name = "label24";
            label24.Size = new Size(697, 64);
            label24.TabIndex = 3;
            label24.Text = resources.GetString("label24.Text");
            label24.TextAlign = ContentAlignment.TopCenter;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.BackColor = SystemColors.ActiveCaptionText;
            label25.Font = new Font("Trebuchet MS", 9F);
            label25.ForeColor = SystemColors.Control;
            label25.Location = new Point(347, 274);
            label25.Name = "label25";
            label25.Size = new Size(57, 18);
            label25.TabIndex = 4;
            label25.Text = "About us";
            // 
            // label2
            // 
            label2.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 719);
            label2.Name = "label2";
            label2.Size = new Size(697, 117);
            label2.TabIndex = 6;
            label2.Text = resources.GetString("label2.Text");
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Aquamarine;
            label1.Location = new Point(41, 43);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 0;
            label1.Text = "How can we help you?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(36, 76);
            label3.Name = "label3";
            label3.Size = new Size(154, 29);
            label3.TabIndex = 1;
            label3.Text = "Contact us";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(37, 128);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(111, 78, 55);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.ImeMode = ImeMode.Disable;
            panel1.Location = new Point(0, 836);
            panel1.Name = "panel1";
            panel1.Size = new Size(771, 269);
            panel1.TabIndex = 5;
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(41, 105);
            label5.Name = "label5";
            label5.Size = new Size(257, 38);
            label5.TabIndex = 7;
            label5.Text = "We're here to help and answer questions you might have. We look forward to hearing from you!";
            // 
            // button1
            // 
            button1.AllowDrop = true;
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(43, 137);
            button1.Name = "button1";
            button1.Size = new Size(37, 33);
            button1.TabIndex = 8;
            button1.UseVisualStyleBackColor = false;
            // 
            // Home_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(Navigations);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home_Page";
            Size = new Size(771, 450);
            Navigations.ResumeLayout(false);
            Navigations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Navigations;
        private Button LogOutButton;
        private Button ShopButton;
        private Button LocationButton;
        private Label Username;
        private PictureBox pictureBox1;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Label label5;
        private Button button1;
    }
}
