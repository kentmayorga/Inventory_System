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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Navigations = new Panel();
            shopbutton = new Button();
            HomeButton = new Button();
            CartButton = new Button();
            dataGridViewCart = new DataGridView();
            ProductQuantity = new TextBox();
            QuantityLabel = new Label();
            UpdateQuantityButton = new Button();
            CheckoutButton = new Button();
            Navigations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            SuspendLayout();
            // 
            // Navigations
            // 
            Navigations.BackColor = Color.FromArgb(111, 78, 55);
            Navigations.Controls.Add(shopbutton);
            Navigations.Controls.Add(HomeButton);
            Navigations.Controls.Add(CartButton);
            Navigations.Dock = DockStyle.Top;
            Navigations.ImeMode = ImeMode.Disable;
            Navigations.Location = new Point(0, 0);
            Navigations.Name = "Navigations";
            Navigations.Size = new Size(772, 52);
            Navigations.TabIndex = 2;
            // 
            // shopbutton
            // 
            shopbutton.AllowDrop = true;
            shopbutton.BackColor = Color.Transparent;
            shopbutton.FlatAppearance.BorderSize = 0;
            shopbutton.FlatAppearance.MouseOverBackColor = Color.Black;
            shopbutton.FlatStyle = FlatStyle.Flat;
            shopbutton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            shopbutton.ForeColor = Color.White;
            shopbutton.Location = new Point(12, 10);
            shopbutton.Name = "shopbutton";
            shopbutton.Size = new Size(63, 24);
            shopbutton.TabIndex = 9;
            shopbutton.Text = "SHOP";
            shopbutton.UseVisualStyleBackColor = false;
            shopbutton.Click += shopbutton_Click;
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
            HomeButton.Location = new Point(684, 10);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(63, 24);
            HomeButton.TabIndex = 8;
            HomeButton.Text = "HOME";
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
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
            CartButton.Location = new Point(81, 10);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(60, 24);
            CartButton.TabIndex = 6;
            CartButton.Text = "CART";
            CartButton.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCart
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(150, 121, 105);
            dataGridViewCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCart.BackgroundColor = Color.Bisque;
            dataGridViewCart.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Bisque;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewCart.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewCart.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCart.GridColor = SystemColors.Control;
            dataGridViewCart.Location = new Point(0, 40);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Bisque;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewCart.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = Color.Bisque;
            dataGridViewCart.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCart.Size = new Size(772, 280);
            dataGridViewCart.TabIndex = 3;
            dataGridViewCart.CellMouseClick += dataGridViewCart_CellMouseClick;
            // 
            // ProductQuantity
            // 
            ProductQuantity.Location = new Point(12, 361);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(123, 23);
            ProductQuantity.TabIndex = 4;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.BackColor = Color.White;
            QuantityLabel.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            QuantityLabel.Location = new Point(12, 343);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(55, 15);
            QuantityLabel.TabIndex = 5;
            QuantityLabel.Text = "Quantity";
            QuantityLabel.Click += QuantityLabel_Click;
            // 
            // UpdateQuantityButton
            // 
            UpdateQuantityButton.Location = new Point(141, 359);
            UpdateQuantityButton.Name = "UpdateQuantityButton";
            UpdateQuantityButton.Size = new Size(100, 25);
            UpdateQuantityButton.TabIndex = 6;
            UpdateQuantityButton.Text = "Update";
            UpdateQuantityButton.UseVisualStyleBackColor = true;
            UpdateQuantityButton.Click += UpdateQuantityButton_Click;
            // 
            // CheckoutButton
            // 
            CheckoutButton.Location = new Point(657, 359);
            CheckoutButton.Name = "CheckoutButton";
            CheckoutButton.Size = new Size(100, 23);
            CheckoutButton.TabIndex = 7;
            CheckoutButton.Text = "Checkout";
            CheckoutButton.UseVisualStyleBackColor = true;
            // 
            // Cart_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(150, 121, 105);
            Controls.Add(CheckoutButton);
            Controls.Add(UpdateQuantityButton);
            Controls.Add(QuantityLabel);
            Controls.Add(ProductQuantity);
            Controls.Add(dataGridViewCart);
            Controls.Add(Navigations);
            Name = "Cart_Page";
            Size = new Size(772, 415);
            Navigations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Navigations;
        private Button HomeButton;
        private Button CartButton;
        private DataGridView dataGridViewCart;
        private TextBox ProductQuantity;
        private Label QuantityLabel;
        private Button UpdateQuantityButton;
        private Button CheckoutButton;
        private Button shopbutton;
    }
}
