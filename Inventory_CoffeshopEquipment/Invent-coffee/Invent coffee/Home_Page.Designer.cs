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
            Navigations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
<<<<<<< HEAD
            Navigations.Size = new Size(720, 49);
=======
            Navigations.Size = new Size(740, 49);
>>>>>>> 3d155b4e7c02403352e20d80b2ef59b33fe7cfd0
            Navigations.TabIndex = 0;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.ForeColor = Color.White;
            Username.Location = new Point(614, 16);
            Username.Name = "Username";
            Username.Size = new Size(32, 15);
            Username.TabIndex = 8;
            Username.Text = "label";
            // 
            // LocationButton
            // 
            LocationButton.AllowDrop = true;
            LocationButton.BackColor = Color.Transparent;
            LocationButton.FlatAppearance.BorderSize = 0;
            LocationButton.FlatStyle = FlatStyle.Flat;
            LocationButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LocationButton.ForeColor = Color.White;
            LocationButton.Location = new Point(65, 11);
            LocationButton.Name = "LocationButton";
            LocationButton.Size = new Size(98, 24);
            LocationButton.TabIndex = 7;
            LocationButton.Text = "LOCATION";
            LocationButton.UseVisualStyleBackColor = false;
            // 
            // ShopButton
            // 
            ShopButton.AllowDrop = true;
            ShopButton.BackColor = Color.Transparent;
            ShopButton.FlatAppearance.BorderSize = 0;
            ShopButton.FlatAppearance.MouseOverBackColor = Color.Red;
            ShopButton.FlatStyle = FlatStyle.Flat;
            ShopButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShopButton.ForeColor = Color.White;
            ShopButton.Location = new Point(12, 11);
            ShopButton.Name = "ShopButton";
            ShopButton.Size = new Size(60, 24);
            ShopButton.TabIndex = 6;
            ShopButton.Text = "SHOP";
            ShopButton.UseVisualStyleBackColor = false;
            ShopButton.Click += ShopButton_Click;
            // 
            // LogOutButton
            // 
            LogOutButton.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(667, 10);
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
<<<<<<< HEAD
            pictureBox1.Location = new Point(21, 349);
=======
            pictureBox1.Location = new Point(41, 336);
>>>>>>> 3d155b4e7c02403352e20d80b2ef59b33fe7cfd0
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
            label23.Size = new Size(300, 46);
            label23.TabIndex = 2;
            label23.Text = "MANGA INDIFICA";
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
            // Home_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(Navigations);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home_Page";
<<<<<<< HEAD
            Size = new Size(720, 450);
=======
            Size = new Size(703, 399);
>>>>>>> 3d155b4e7c02403352e20d80b2ef59b33fe7cfd0
            Navigations.ResumeLayout(false);
            Navigations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}
