namespace Invent_coffee.Resources.Admin_Pages
{
    partial class Records_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records_page));
            OrderRecordInfo_dataGridView = new DataGridView();
            panel1 = new Panel();
            Quantity_label = new Label();
            Product_label = new Label();
            datelabel = new Label();
            customername = new Label();
            totalpayment = new Label();
            title = new Label();
            BackBtn = new Button();
            SearchBar_textBox = new TextBox();
            searchbtn = new Button();
            FilterBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)OrderRecordInfo_dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OrderRecordInfo_dataGridView
            // 
            OrderRecordInfo_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderRecordInfo_dataGridView.Location = new Point(3, 144);
            OrderRecordInfo_dataGridView.Margin = new Padding(3, 4, 3, 4);
            OrderRecordInfo_dataGridView.Name = "OrderRecordInfo_dataGridView";
            OrderRecordInfo_dataGridView.RowHeadersWidth = 51;
            OrderRecordInfo_dataGridView.Size = new Size(869, 411);
            OrderRecordInfo_dataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(Quantity_label);
            panel1.Controls.Add(Product_label);
            panel1.Controls.Add(datelabel);
            panel1.Controls.Add(customername);
            panel1.Controls.Add(totalpayment);
            panel1.Location = new Point(7, 107);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(865, 29);
            panel1.TabIndex = 1;
            // 
            // Quantity_label
            // 
            Quantity_label.AutoSize = true;
            Quantity_label.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Quantity_label.ForeColor = Color.White;
            Quantity_label.Location = new Point(509, 0);
            Quantity_label.Name = "Quantity_label";
            Quantity_label.Size = new Size(116, 23);
            Quantity_label.TabIndex = 8;
            Quantity_label.Text = "QUANTITY";
            // 
            // Product_label
            // 
            Product_label.AutoSize = true;
            Product_label.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Product_label.ForeColor = Color.White;
            Product_label.Location = new Point(182, 0);
            Product_label.Name = "Product_label";
            Product_label.Size = new Size(121, 23);
            Product_label.TabIndex = 3;
            Product_label.Text = "PRODUCTS";
            // 
            // datelabel
            // 
            datelabel.AutoSize = true;
            datelabel.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datelabel.ForeColor = Color.White;
            datelabel.Location = new Point(364, 0);
            datelabel.Name = "datelabel";
            datelabel.Size = new Size(66, 23);
            datelabel.TabIndex = 4;
            datelabel.Text = "DATE";
            // 
            // customername
            // 
            customername.AutoSize = true;
            customername.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customername.ForeColor = Color.White;
            customername.Location = new Point(0, 0);
            customername.Name = "customername";
            customername.Size = new Size(125, 23);
            customername.TabIndex = 5;
            customername.Text = "CUSTOMER";
            // 
            // totalpayment
            // 
            totalpayment.AutoSize = true;
            totalpayment.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalpayment.ForeColor = Color.White;
            totalpayment.Location = new Point(682, 0);
            totalpayment.Name = "totalpayment";
            totalpayment.Size = new Size(183, 23);
            totalpayment.TabIndex = 7;
            totalpayment.Text = "TOTAL PAYMENT";
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Century", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(242, 16);
            title.Name = "title";
            title.Size = new Size(422, 40);
            title.TabIndex = 2;
            title.Text = "RECORDS OF ORDERS";
            // 
            // BackBtn
            // 
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Image = (Image)resources.GetObject("BackBtn.Image");
            BackBtn.Location = new Point(824, 7);
            BackBtn.Margin = new Padding(3, 4, 3, 4);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(45, 49);
            BackBtn.TabIndex = 3;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // SearchBar_textBox
            // 
            SearchBar_textBox.Location = new Point(558, 71);
            SearchBar_textBox.Margin = new Padding(3, 4, 3, 4);
            SearchBar_textBox.Name = "SearchBar_textBox";
            SearchBar_textBox.Size = new Size(234, 27);
            SearchBar_textBox.TabIndex = 4;
            // 
            // searchbtn
            // 
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.Location = new Point(783, 69);
            searchbtn.Margin = new Padding(3, 4, 3, 4);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(86, 31);
            searchbtn.TabIndex = 5;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // FilterBtn
            // 
            FilterBtn.FlatAppearance.BorderSize = 0;
            FilterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            FilterBtn.FlatStyle = FlatStyle.Flat;
            FilterBtn.Image = (Image)resources.GetObject("FilterBtn.Image");
            FilterBtn.Location = new Point(516, 70);
            FilterBtn.Margin = new Padding(3, 4, 3, 4);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(35, 33);
            FilterBtn.TabIndex = 6;
            FilterBtn.UseVisualStyleBackColor = true;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // Records_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(FilterBtn);
            Controls.Add(searchbtn);
            Controls.Add(SearchBar_textBox);
            Controls.Add(BackBtn);
            Controls.Add(title);
            Controls.Add(panel1);
            Controls.Add(OrderRecordInfo_dataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Records_page";
            Size = new Size(875, 559);
            ((System.ComponentModel.ISupportInitialize)OrderRecordInfo_dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrderRecordInfo_dataGridView;
        private Panel panel1;
        private Label title;
        private Label datelabel;
        private Label customername;
        private Label totalpayment;
        private Button BackBtn;
        private TextBox SearchBar_textBox;
        private Button searchbtn;
        private Label Quantity_label;
        private Label Product_label;
        private Button FilterBtn;
    }
}
