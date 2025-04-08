namespace Invent_coffee
{
    partial class Inventory_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory_page));
            Inventory_DataGridView = new DataGridView();
            AddProductBtn = new Button();
            Searchbar_textbox = new TextBox();
            SearchBtn = new Button();
            FilterBtn = new Button();
            BackBtn = new Button();
            ProductNameTableHeader = new Label();
            ProductPriceTableHeader = new Label();
            ProductStockTableHeader = new Label();
            ProductSoldTableHeader = new Label();
            InventoryTitle_label = new Label();
            ((System.ComponentModel.ISupportInitialize)Inventory_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // Inventory_DataGridView
            // 
            Inventory_DataGridView.Anchor = AnchorStyles.None;
            Inventory_DataGridView.BackgroundColor = SystemColors.GrayText;
            Inventory_DataGridView.BorderStyle = BorderStyle.None;
            Inventory_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Inventory_DataGridView.Location = new Point(12, 130);
            Inventory_DataGridView.Name = "Inventory_DataGridView";
            Inventory_DataGridView.RowHeadersWidth = 51;
            Inventory_DataGridView.ScrollBars = ScrollBars.Vertical;
            Inventory_DataGridView.Size = new Size(855, 420);
            Inventory_DataGridView.TabIndex = 0;
            Inventory_DataGridView.CellContentClick += Inventory_DataGridView_CellContentClick;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.Transparent;
            AddProductBtn.FlatAppearance.BorderSize = 0;
            AddProductBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            AddProductBtn.FlatStyle = FlatStyle.Flat;
            AddProductBtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddProductBtn.Image = (Image)resources.GetObject("AddProductBtn.Image");
            AddProductBtn.Location = new Point(5, 56);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(51, 40);
            AddProductBtn.TabIndex = 1;
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // Searchbar_textbox
            // 
            Searchbar_textbox.BackColor = SystemColors.Control;
            Searchbar_textbox.Location = new Point(260, 63);
            Searchbar_textbox.Margin = new Padding(3, 4, 3, 4);
            Searchbar_textbox.Name = "Searchbar_textbox";
            Searchbar_textbox.Size = new Size(328, 27);
            Searchbar_textbox.TabIndex = 4;
            Searchbar_textbox.Enter += SearchBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.Transparent;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(594, 60);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(97, 32);
            SearchBtn.TabIndex = 5;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // FilterBtn
            // 
            FilterBtn.BackColor = Color.Transparent;
            FilterBtn.FlatAppearance.BorderSize = 0;
            FilterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            FilterBtn.FlatStyle = FlatStyle.Flat;
            FilterBtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterBtn.Image = (Image)resources.GetObject("FilterBtn.Image");
            FilterBtn.Location = new Point(62, 57);
            FilterBtn.Margin = new Padding(3, 4, 3, 4);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(46, 35);
            FilterBtn.TabIndex = 6;
            FilterBtn.UseVisualStyleBackColor = false;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.Transparent;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Image = (Image)resources.GetObject("BackBtn.Image");
            BackBtn.Location = new Point(806, 52);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(61, 44);
            BackBtn.TabIndex = 2;
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // ProductNameTableHeader
            // 
            ProductNameTableHeader.AutoSize = true;
            ProductNameTableHeader.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameTableHeader.ForeColor = SystemColors.ControlLightLight;
            ProductNameTableHeader.Location = new Point(12, 105);
            ProductNameTableHeader.Name = "ProductNameTableHeader";
            ProductNameTableHeader.Size = new Size(65, 22);
            ProductNameTableHeader.TabIndex = 7;
            ProductNameTableHeader.Text = "Name:";
            // 
            // ProductPriceTableHeader
            // 
            ProductPriceTableHeader.AutoSize = true;
            ProductPriceTableHeader.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPriceTableHeader.ForeColor = SystemColors.ControlLightLight;
            ProductPriceTableHeader.Location = new Point(203, 105);
            ProductPriceTableHeader.Name = "ProductPriceTableHeader";
            ProductPriceTableHeader.Size = new Size(58, 22);
            ProductPriceTableHeader.TabIndex = 8;
            ProductPriceTableHeader.Text = "Price:";
            // 
            // ProductStockTableHeader
            // 
            ProductStockTableHeader.AutoSize = true;
            ProductStockTableHeader.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductStockTableHeader.ForeColor = SystemColors.ControlLightLight;
            ProductStockTableHeader.Location = new Point(385, 105);
            ProductStockTableHeader.Name = "ProductStockTableHeader";
            ProductStockTableHeader.Size = new Size(61, 22);
            ProductStockTableHeader.TabIndex = 9;
            ProductStockTableHeader.Text = "Stock:";
            // 
            // ProductSoldTableHeader
            // 
            ProductSoldTableHeader.AutoSize = true;
            ProductSoldTableHeader.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductSoldTableHeader.ForeColor = SystemColors.ControlLightLight;
            ProductSoldTableHeader.Location = new Point(568, 105);
            ProductSoldTableHeader.Name = "ProductSoldTableHeader";
            ProductSoldTableHeader.Size = new Size(51, 22);
            ProductSoldTableHeader.TabIndex = 10;
            ProductSoldTableHeader.Text = "Sold:";
            // 
            // InventoryTitle_label
            // 
            InventoryTitle_label.AutoSize = true;
            InventoryTitle_label.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            InventoryTitle_label.ForeColor = Color.White;
            InventoryTitle_label.Location = new Point(320, 10);
            InventoryTitle_label.Name = "InventoryTitle_label";
            InventoryTitle_label.Size = new Size(214, 35);
            InventoryTitle_label.TabIndex = 11;
            InventoryTitle_label.Text = "INVENTORY";
            // 
            // Inventory_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(InventoryTitle_label);
            Controls.Add(ProductSoldTableHeader);
            Controls.Add(ProductStockTableHeader);
            Controls.Add(ProductPriceTableHeader);
            Controls.Add(ProductNameTableHeader);
            Controls.Add(FilterBtn);
            Controls.Add(SearchBtn);
            Controls.Add(Searchbar_textbox);
            Controls.Add(BackBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(Inventory_DataGridView);
            Name = "Inventory_page";
            Size = new Size(882, 553);
            ((System.ComponentModel.ISupportInitialize)Inventory_DataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Inventory_DataGridView;
        private Button AddProductBtn;
        private TextBox Searchbar_textbox;
        private Button SearchBtn;
        private Button FilterBtn;
        private Button BackBtn;
        private Label ProductNameTableHeader;
        private Label ProductPriceTableHeader;
        private Label ProductStockTableHeader;
        private Label ProductSoldTableHeader;
        private Label InventoryTitle_label;
    }
}
