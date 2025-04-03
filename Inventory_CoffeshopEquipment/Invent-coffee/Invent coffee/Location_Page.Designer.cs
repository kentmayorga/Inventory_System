namespace Invent_coffee
{
    partial class Location_Page
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
            locationbutton = new Button();
            Cart = new Button();
            HomeButton = new Button();
            panel1 = new Panel();
            Navigations.SuspendLayout();
            SuspendLayout();
            // 
            // Navigations
            // 
            Navigations.BackColor = Color.FromArgb(111, 78, 55);
            Navigations.Controls.Add(locationbutton);
            Navigations.Controls.Add(Cart);
            Navigations.Controls.Add(HomeButton);
            Navigations.Dock = DockStyle.Top;
            Navigations.ImeMode = ImeMode.Disable;
            Navigations.Location = new Point(0, 0);
            Navigations.Name = "Navigations";
            Navigations.Size = new Size(772, 46);
            Navigations.TabIndex = 2;
            // 
            // locationbutton
            // 
            locationbutton.AllowDrop = true;
            locationbutton.BackColor = Color.White;
            locationbutton.FlatAppearance.BorderSize = 0;
            locationbutton.FlatAppearance.MouseOverBackColor = Color.White;
            locationbutton.FlatStyle = FlatStyle.Flat;
            locationbutton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            locationbutton.ForeColor = Color.FromArgb(128, 64, 0);
            locationbutton.Location = new Point(86, 11);
            locationbutton.Name = "locationbutton";
            locationbutton.Size = new Size(94, 24);
            locationbutton.TabIndex = 10;
            locationbutton.Text = "LOCATION";
            locationbutton.UseVisualStyleBackColor = false;
            // 
            // Cart
            // 
            Cart.Location = new Point(646, 10);
            Cart.Name = "Cart";
            Cart.Size = new Size(75, 23);
            Cart.TabIndex = 9;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            // 
            // HomeButton
            // 
            HomeButton.AllowDrop = true;
            HomeButton.BackColor = Color.Transparent;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = Color.White;
            HomeButton.Location = new Point(11, 11);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(63, 24);
            HomeButton.TabIndex = 8;
            HomeButton.Text = "HOME";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click_1;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(772, 369);
            panel1.TabIndex = 3;
            // 
            // Location_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            Controls.Add(panel1);
            Controls.Add(Navigations);
            Name = "Location_Page";
            Size = new Size(772, 415);
            Navigations.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Navigations;
        private Button Cart;
        private Button HomeButton;
        private Button locationbutton;
        private Panel panel1;
    }
}
