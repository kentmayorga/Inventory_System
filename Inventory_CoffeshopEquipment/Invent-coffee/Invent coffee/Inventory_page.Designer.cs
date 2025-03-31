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
            Inventory_DataGridView = new DataGridView();
            AddProductBtn = new Button();
            BackBtn = new Button();
            button1 = new Button();
            Searchbar = new TextBox();
            SearchBtn = new Button();
            button2 = new Button();
            InputProductName = new TextBox();
            textBox2 = new TextBox();
            InputPrice = new TextBox();
            InputQuantity = new TextBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Inventory_DataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // Inventory_DataGridView
            // 
            Inventory_DataGridView.Anchor = AnchorStyles.Bottom;
            Inventory_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Inventory_DataGridView.Location = new Point(238, 116);
            Inventory_DataGridView.Margin = new Padding(3, 2, 3, 2);
            Inventory_DataGridView.Name = "Inventory_DataGridView";
            Inventory_DataGridView.RowHeadersWidth = 51;
            Inventory_DataGridView.Size = new Size(534, 315);
            Inventory_DataGridView.TabIndex = 0;
            Inventory_DataGridView.CellContentClick += Inventory_DataGridView_CellContentClick;
            // 
            // AddProductBtn
            // 
            AddProductBtn.BackColor = SystemColors.ActiveBorder;
            AddProductBtn.Location = new Point(22, 341);
            AddProductBtn.Margin = new Padding(3, 2, 3, 2);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(82, 22);
            AddProductBtn.TabIndex = 1;
            AddProductBtn.Text = "ADD";
            AddProductBtn.UseVisualStyleBackColor = false;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.BackColor = SystemColors.ActiveBorder;
            BackBtn.Location = new Point(132, 341);
            BackBtn.Margin = new Padding(3, 2, 3, 2);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(82, 22);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "BACK";
            BackBtn.UseVisualStyleBackColor = false;
            BackBtn.Click += BackBtn_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_home_30;
            button1.Location = new Point(9, 3);
            button1.Name = "button1";
            button1.Size = new Size(47, 42);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // Searchbar
            // 
            Searchbar.BackColor = SystemColors.ActiveBorder;
            Searchbar.Location = new Point(238, 13);
            Searchbar.Name = "Searchbar";
            Searchbar.Size = new Size(275, 23);
            Searchbar.TabIndex = 4;
            // 
            // SearchBtn
            // 
            SearchBtn.BackColor = SystemColors.ActiveBorder;
            SearchBtn.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.Location = new Point(524, 12);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(75, 24);
            SearchBtn.TabIndex = 5;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveBorder;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(645, 72);
            button2.Name = "button2";
            button2.Size = new Size(110, 30);
            button2.TabIndex = 6;
            button2.Text = "Sort by Price";
            button2.UseVisualStyleBackColor = false;
            // 
            // InputProductName
            // 
            InputProductName.BackColor = SystemColors.ActiveBorder;
            InputProductName.Location = new Point(9, 175);
            InputProductName.Name = "InputProductName";
            InputProductName.Size = new Size(223, 23);
            InputProductName.TabIndex = 7;
            InputProductName.Text = "Product name:";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveBorder;
            textBox2.Location = new Point(50, 126);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 23);
            textBox2.TabIndex = 8;
            textBox2.Text = "Create new product here";
            // 
            // InputPrice
            // 
            InputPrice.BackColor = SystemColors.ActiveBorder;
            InputPrice.Location = new Point(9, 226);
            InputPrice.Name = "InputPrice";
            InputPrice.Size = new Size(223, 23);
            InputPrice.TabIndex = 9;
            InputPrice.Text = "Price:";
            // 
            // InputQuantity
            // 
            InputQuantity.BackColor = SystemColors.ActiveBorder;
            InputQuantity.Location = new Point(9, 276);
            InputQuantity.Name = "InputQuantity";
            InputQuantity.Size = new Size(223, 23);
            InputQuantity.TabIndex = 10;
            InputQuantity.Text = "Quantity:";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.icons8_coffee_24;
            pictureBox2.Location = new Point(206, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(26, 25);
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // Inventory_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SaddleBrown;
            Controls.Add(pictureBox2);
            Controls.Add(InputQuantity);
            Controls.Add(InputPrice);
            Controls.Add(textBox2);
            Controls.Add(InputProductName);
            Controls.Add(button2);
            Controls.Add(SearchBtn);
            Controls.Add(Searchbar);
            Controls.Add(button1);
            Controls.Add(BackBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(Inventory_DataGridView);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Inventory_page";
            Size = new Size(772, 422);
            ((System.ComponentModel.ISupportInitialize)Inventory_DataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView Inventory_DataGridView;
        private Button AddProductBtn;
        private Button BackBtn;
        private Button button1;
        private TextBox Searchbar;
        private Button SearchBtn;
        private Button button2;
        private TextBox InputProductName;
        private TextBox textBox2;
        private TextBox InputPrice;
        private TextBox InputQuantity;
        private PictureBox pictureBox2;
    }
}
