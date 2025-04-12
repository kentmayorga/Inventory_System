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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cart_Page));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            Navigations = new Panel();
            HomeButton = new Button();
            CartButton = new Button();
            dataGridViewCart = new DataGridView();
            ProductQuantity = new TextBox();
            QuantityLabel = new Label();
            UpdateQuantityButton = new Button();
            CheckoutButton = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            Navigations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            HomeButton.BackgroundImage = (Image)resources.GetObject("HomeButton.BackgroundImage");
            HomeButton.BackgroundImageLayout = ImageLayout.Stretch;
            HomeButton.FlatAppearance.BorderSize = 0;
            HomeButton.FlatAppearance.MouseOverBackColor = Color.Black;
            HomeButton.FlatStyle = FlatStyle.Flat;
            HomeButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HomeButton.ForeColor = Color.White;
            HomeButton.Location = new Point(68, -5);
            HomeButton.Name = "HomeButton";
            HomeButton.Size = new Size(63, 43);
            HomeButton.TabIndex = 8;
            HomeButton.UseVisualStyleBackColor = false;
            HomeButton.Click += HomeButton_Click;
            // 
            // CartButton
            // 
            CartButton.AllowDrop = true;
            CartButton.BackColor = Color.Transparent;
            CartButton.BackgroundImage = (Image)resources.GetObject("CartButton.BackgroundImage");
            CartButton.BackgroundImageLayout = ImageLayout.Stretch;
            CartButton.FlatAppearance.BorderSize = 0;
            CartButton.FlatAppearance.MouseOverBackColor = Color.White;
            CartButton.FlatStyle = FlatStyle.Flat;
            CartButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CartButton.ForeColor = Color.FromArgb(128, 64, 0);
            CartButton.Location = new Point(-3, -19);
            CartButton.Name = "CartButton";
            CartButton.Size = new Size(80, 79);
            CartButton.TabIndex = 6;
            CartButton.UseVisualStyleBackColor = false;
            // 
            // dataGridViewCart
            // 
            dataGridViewCellStyle1.BackColor = Color.Bisque;
            dataGridViewCart.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCart.Location = new Point(0, 40);
            dataGridViewCart.Name = "dataGridViewCart";
            dataGridViewCellStyle2.BackColor = Color.FromArgb(111, 78, 55);
            dataGridViewCart.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCart.Size = new Size(772, 279);
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
            QuantityLabel.BackColor = Color.Transparent;
            QuantityLabel.Location = new Point(12, 343);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(53, 15);
            QuantityLabel.TabIndex = 5;
            QuantityLabel.Text = "Quantity";
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
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.cup_15002205;
            pictureBox1.Location = new Point(391, 359);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 41);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(111, 78, 55);
            label1.Location = new Point(345, 335);
            label1.Name = "label1";
            label1.Size = new Size(171, 23);
            label1.TabIndex = 9;
            label1.Text = "MANGI INDIFICA";
            // 
            // Cart_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private PictureBox pictureBox1;
        private Label label1;
    }
}
