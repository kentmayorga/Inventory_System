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
            Navigations = new Panel();
            Username = new Label();
            LocationButton = new Button();
            ShopButton = new Button();
            LogOutButton = new Button();
            pictureBox1 = new PictureBox();
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
            Navigations.Size = new Size(720, 49);
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
            pictureBox1.Location = new Point(21, 349);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(699, 352);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Home_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(Navigations);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home_Page";
            Size = new Size(720, 450);
            Navigations.ResumeLayout(false);
            Navigations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Navigations;
        private Button LogOutButton;
        private Button ShopButton;
        private Button LocationButton;
        private Label Username;
        private PictureBox pictureBox1;
    }
}
