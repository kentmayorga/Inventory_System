namespace Invent_coffee
{
    partial class Shop_Page
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
            Navigations = new Panel();
            Cart = new Button();
            HomeButton = new Button();
            LocationButton = new Button();
            ShopButton = new Button();
            LogOutButton = new Button();
            dataGridView1 = new DataGridView();
            ProductName = new Label();
            ProductDescription = new Label();
            ProductPrice = new Label();
            ProductQuantity = new TextBox();
            label1 = new Label();
            AddToCartButton = new Button();
            pictureBox1 = new PictureBox();
            Navigations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Navigations
            // 
            Navigations.BackColor = Color.FromArgb(111, 78, 55);
            Navigations.Controls.Add(Cart);
            Navigations.Controls.Add(HomeButton);
            Navigations.Controls.Add(LocationButton);
            Navigations.Controls.Add(ShopButton);
            Navigations.Controls.Add(LogOutButton);
            Navigations.Dock = DockStyle.Top;
            Navigations.ImeMode = ImeMode.Disable;
            Navigations.Location = new Point(0, 0);
            Navigations.Name = "Navigations";
            Navigations.Size = new Size(772, 46);
            Navigations.TabIndex = 1;
            // 
            // Cart
            // 
            Cart.BackColor = Color.White;
            Cart.Location = new Point(609, 9);
            Cart.Name = "Cart";
            Cart.Size = new Size(75, 23);
            Cart.TabIndex = 9;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = false;
            Cart.Click += Cart_Click;
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
            // LocationButton
            // 
            LocationButton.AllowDrop = true;
            LocationButton.BackColor = Color.Transparent;
            LocationButton.FlatAppearance.BorderSize = 0;
            LocationButton.FlatStyle = FlatStyle.Flat;
            LocationButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LocationButton.ForeColor = Color.White;
            LocationButton.Location = new Point(146, 10);
            LocationButton.Name = "LocationButton";
            LocationButton.Size = new Size(98, 24);
            LocationButton.TabIndex = 7;
            LocationButton.Text = "LOCATION";
            LocationButton.UseVisualStyleBackColor = false;
            // 
            // ShopButton
            // 
            ShopButton.AllowDrop = true;
            ShopButton.BackColor = Color.White;
            ShopButton.FlatAppearance.BorderSize = 0;
            ShopButton.FlatAppearance.MouseOverBackColor = Color.White;
            ShopButton.FlatStyle = FlatStyle.Flat;
            ShopButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShopButton.ForeColor = Color.FromArgb(128, 64, 0);
            ShopButton.Location = new Point(80, 10);
            ShopButton.Name = "ShopButton";
            ShopButton.Size = new Size(60, 24);
            ShopButton.TabIndex = 6;
            ShopButton.Text = "SHOP";
            ShopButton.UseVisualStyleBackColor = false;
            // 
            // LogOutButton
            // 
            LogOutButton.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(690, 7);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(59, 28);
            LogOutButton.TabIndex = 5;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = Color.FromArgb(150, 121, 105);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.Bisque;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Chocolate;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.Control;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Bisque;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EditMode = DataGridViewEditMode.EditOnF2;
            dataGridView1.GridColor = SystemColors.Control;
            dataGridView1.Location = new Point(0, 41);
            dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(150, 121, 105);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.ShowCellErrors = false;
            dataGridView1.Size = new Size(548, 374);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // ProductName
            // 
            ProductName.AutoSize = true;
            ProductName.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductName.Location = new Point(554, 58);
            ProductName.Name = "ProductName";
            ProductName.Size = new Size(42, 15);
            ProductName.TabIndex = 3;
            ProductName.Text = "Name:";
            // 
            // ProductDescription
            // 
            ProductDescription.AutoSize = true;
            ProductDescription.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductDescription.Location = new Point(554, 84);
            ProductDescription.Name = "ProductDescription";
            ProductDescription.Size = new Size(72, 15);
            ProductDescription.TabIndex = 4;
            ProductDescription.Text = "Description:";
            // 
            // ProductPrice
            // 
            ProductPrice.AutoSize = true;
            ProductPrice.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ProductPrice.Location = new Point(554, 110);
            ProductPrice.Name = "ProductPrice";
            ProductPrice.Size = new Size(38, 15);
            ProductPrice.TabIndex = 5;
            ProductPrice.Text = "Price:";
            // 
            // ProductQuantity
            // 
            ProductQuantity.Location = new Point(559, 346);
            ProductQuantity.Name = "ProductQuantity";
            ProductQuantity.Size = new Size(100, 23);
            ProductQuantity.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(559, 315);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 7;
            label1.Text = "Quantity";
            label1.Click += label1_Click;
            // 
            // AddToCartButton
            // 
            AddToCartButton.Location = new Point(559, 375);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(200, 23);
            AddToCartButton.TabIndex = 8;
            AddToCartButton.Text = "Add to Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(559, 144);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(195, 146);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Shop_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            Controls.Add(pictureBox1);
            Controls.Add(AddToCartButton);
            Controls.Add(label1);
            Controls.Add(ProductQuantity);
            Controls.Add(ProductPrice);
            Controls.Add(ProductDescription);
            Controls.Add(ProductName);
            Controls.Add(Navigations);
            Controls.Add(dataGridView1);
            Name = "Shop_Page";
            Size = new Size(772, 416);
            Load += Shop_Page_Load;
            Navigations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Navigations;
        private Button LocationButton;
        private Button ShopButton;
        private Button LogOutButton;
        private Button HomeButton;
        private Button Cart;
        private DataGridView dataGridView1;
        private Label ProductName;
        private Label ProductDescription;
        private Label ProductPrice;
        private TextBox ProductQuantity;
        private Label label1;
        private Button AddToCartButton;
        private PictureBox pictureBox1;
    }
}
