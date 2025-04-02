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
            ((System.ComponentModel.ISupportInitialize)Inventory_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // Inventory_DataGridView
            // 
            Inventory_DataGridView.Anchor = AnchorStyles.None;
            Inventory_DataGridView.BackgroundColor = SystemColors.GrayText;
            Inventory_DataGridView.BorderStyle = BorderStyle.None;
            Inventory_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Inventory_DataGridView.Location = new Point(10, 85);
            Inventory_DataGridView.Name = "Inventory_DataGridView";
            Inventory_DataGridView.RowHeadersWidth = 51;
            Inventory_DataGridView.ScrollBars = ScrollBars.Vertical;
            Inventory_DataGridView.Size = new Size(860, 454);
            Inventory_DataGridView.TabIndex = 0;
            Inventory_DataGridView.CellContentClick += Inventory_DataGridView_CellContentClick;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = Color.SaddleBrown;
            AddProductBtn.FlatAppearance.BorderSize = 0;
            AddProductBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            AddProductBtn.FlatStyle = FlatStyle.Flat;
            AddProductBtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddProductBtn.Image = (Image)resources.GetObject("AddProductBtn.Image");
            AddProductBtn.Location = new Point(3, 11);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(51, 40);
            AddProductBtn.TabIndex = 1;
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // Searchbar_textbox
            // 
            Searchbar_textbox.BackColor = SystemColors.Control;
            Searchbar_textbox.Location = new Point(258, 18);
            Searchbar_textbox.Margin = new Padding(3, 4, 3, 4);
            Searchbar_textbox.Name = "Searchbar_textbox";
            Searchbar_textbox.Size = new Size(328, 27);
            Searchbar_textbox.TabIndex = 4;
            Searchbar_textbox.Enter += SearchBtn_Click;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = Color.SaddleBrown;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = SystemColors.ButtonHighlight;
            SearchBtn.Location = new Point(592, 15);
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
            FilterBtn.BackColor = Color.SaddleBrown;
            FilterBtn.FlatAppearance.BorderSize = 0;
            FilterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            FilterBtn.FlatStyle = FlatStyle.Flat;
            FilterBtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FilterBtn.Image = (Image)resources.GetObject("FilterBtn.Image");
            FilterBtn.Location = new Point(60, 12);
            FilterBtn.Margin = new Padding(3, 4, 3, 4);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(46, 35);
            FilterBtn.TabIndex = 6;
            FilterBtn.UseVisualStyleBackColor = false;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = Color.SaddleBrown;
            BackBtn.Cursor = Cursors.Hand;
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Image = (Image)resources.GetObject("BackBtn.Image");
            BackBtn.Location = new Point(818, 5);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(61, 44);
            BackBtn.TabIndex = 2;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // ProductNameTableHeader
            // 
            ProductNameTableHeader.AutoSize = true;
            ProductNameTableHeader.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductNameTableHeader.ForeColor = SystemColors.ControlLightLight;
            ProductNameTableHeader.Location = new Point(10, 60);
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
            ProductPriceTableHeader.Location = new Point(201, 60);
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
            ProductStockTableHeader.Location = new Point(383, 60);
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
            ProductSoldTableHeader.Location = new Point(566, 60);
            ProductSoldTableHeader.Name = "ProductSoldTableHeader";
            ProductSoldTableHeader.Size = new Size(51, 22);
            ProductSoldTableHeader.TabIndex = 10;
            ProductSoldTableHeader.Text = "Sold:";
            // 
            // Inventory_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
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
    }
}
