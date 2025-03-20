namespace Invent_coffee
{
    partial class Cart_Page
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
            HomeButton = new Button();
            CartButton = new Button();
            panel1 = new Panel();
            Navigations.SuspendLayout();
            SuspendLayout();
            // 
            // Navigations
            // 
            Navigations.BackColor = Color.FromArgb(111, 78, 55);
            Navigations.Controls.Add(HomeButton);
            Navigations.Controls.Add(CartButton);
            Navigations.Dock = DockStyle.Top;
            Navigations.ImeMode = ImeMode.Disable;
            Navigations.Location = new Point(0, 0);
            Navigations.Name = "Navigations";
            Navigations.Size = new Size(772, 46);
            Navigations.TabIndex = 2;
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
            HomeButton.Location = new Point(78, 10);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(63, 24);
            HomeButton.TabIndex = 8;
            HomeButton.Text = "HOME";
            HomeButton.UseVisualStyleBackColor = false;
            // 
            // CartButton
            // 
            CartButton.AllowDrop = true;
            CartButton.BackColor = Color.White;
            CartButton.FlatAppearance.BorderSize = 0;
            CartButton.FlatAppearance.MouseOverBackColor = Color.White;
            CartButton.FlatStyle = FlatStyle.Flat;
            CartButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CartButton.ForeColor = Color.FromArgb(128, 64, 0);
            CartButton.Location = new Point(12, 10);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(60, 24);
            CartButton.TabIndex = 6;
            CartButton.Text = "CART";
            CartButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.Location = new Point(223, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(313, 328);
            panel1.TabIndex = 3;
            // 
            // Cart_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(Navigations);
            Name = "Cart_Page";
            Size = new Size(772, 415);
            Navigations.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Navigations;
        private Button HomeButton;
        private Button CartButton;
        private Panel panel1;
    }
}
