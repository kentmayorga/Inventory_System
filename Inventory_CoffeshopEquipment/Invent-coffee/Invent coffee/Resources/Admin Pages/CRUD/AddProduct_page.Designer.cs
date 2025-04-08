namespace Invent_coffee.Resources.Admin_Pages.CRUD
{
    partial class AddProduct_page
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
            ProductStock_label = new Label();
            ProductPrice_label = new Label();
            ProductDesc_label = new Label();
            ProductName_label = new Label();
            ProductImage_label = new Label();
            ProductCancelBtn = new Button();
            ProductSaveBtn = new Button();
            AddImageBtn = new Button();
            ProductStock_textBox = new TextBox();
            ProductPrice_textBox = new TextBox();
            ProductDescription_textBox = new TextBox();
            ProductName_textBox = new TextBox();
            SuspendLayout();
            // 
            // ProductStock_label
            // 
            ProductStock_label.AutoSize = true;
            ProductStock_label.Location = new Point(104, 336);
            ProductStock_label.Name = "ProductStock_label";
            ProductStock_label.Size = new Size(103, 20);
            ProductStock_label.TabIndex = 23;
            ProductStock_label.Text = "Product Stock:";
            // 
            // ProductPrice_label
            // 
            ProductPrice_label.AutoSize = true;
            ProductPrice_label.Location = new Point(101, 277);
            ProductPrice_label.Name = "ProductPrice_label";
            ProductPrice_label.Size = new Size(99, 20);
            ProductPrice_label.TabIndex = 22;
            ProductPrice_label.Text = "Product Price:";
            // 
            // ProductDesc_label
            // 
            ProductDesc_label.AutoSize = true;
            ProductDesc_label.Location = new Point(96, 134);
            ProductDesc_label.Name = "ProductDesc_label";
            ProductDesc_label.Size = new Size(143, 20);
            ProductDesc_label.TabIndex = 21;
            ProductDesc_label.Text = "Product Description:";
            // 
            // ProductName_label
            // 
            ProductName_label.AutoSize = true;
            ProductName_label.Location = new Point(96, 49);
            ProductName_label.Name = "ProductName_label";
            ProductName_label.Size = new Size(107, 20);
            ProductName_label.TabIndex = 20;
            ProductName_label.Text = "Product Name:";
            // 
            // ProductImage_label
            // 
            ProductImage_label.AutoSize = true;
            ProductImage_label.Location = new Point(232, 426);
            ProductImage_label.Name = "ProductImage_label";
            ProductImage_label.Size = new Size(87, 20);
            ProductImage_label.TabIndex = 19;
            ProductImage_label.Text = "Image_path";
            // 
            // ProductCancelBtn
            // 
            ProductCancelBtn.Location = new Point(731, 469);
            ProductCancelBtn.Name = "ProductCancelBtn";
            ProductCancelBtn.Size = new Size(94, 29);
            ProductCancelBtn.TabIndex = 18;
            ProductCancelBtn.Text = "CANCEL";
            ProductCancelBtn.UseVisualStyleBackColor = true;
            ProductCancelBtn.Click += ProductCancelBtn_Click;
            // 
            // ProductSaveBtn
            // 
            ProductSaveBtn.Location = new Point(612, 469);
            ProductSaveBtn.Name = "ProductSaveBtn";
            ProductSaveBtn.Size = new Size(94, 29);
            ProductSaveBtn.TabIndex = 17;
            ProductSaveBtn.Text = "SAVE";
            ProductSaveBtn.UseVisualStyleBackColor = true;
            ProductSaveBtn.Click += ProductSaveBtn_Click;
            // 
            // AddImageBtn
            // 
            AddImageBtn.Location = new Point(119, 422);
            AddImageBtn.Name = "AddImageBtn";
            AddImageBtn.Size = new Size(94, 29);
            AddImageBtn.TabIndex = 16;
            AddImageBtn.Text = "IMAGE";
            AddImageBtn.UseVisualStyleBackColor = true;
            AddImageBtn.Click += AddImageBtn_Click;
            // 
            // ProductStock_textBox
            // 
            ProductStock_textBox.Location = new Point(119, 359);
            ProductStock_textBox.Name = "ProductStock_textBox";
            ProductStock_textBox.Size = new Size(125, 27);
            ProductStock_textBox.TabIndex = 15;
            // 
            // ProductPrice_textBox
            // 
            ProductPrice_textBox.Location = new Point(119, 300);
            ProductPrice_textBox.Name = "ProductPrice_textBox";
            ProductPrice_textBox.Size = new Size(125, 27);
            ProductPrice_textBox.TabIndex = 14;
            // 
            // ProductDescription_textBox
            // 
            ProductDescription_textBox.Location = new Point(119, 157);
            ProductDescription_textBox.Multiline = true;
            ProductDescription_textBox.Name = "ProductDescription_textBox";
            ProductDescription_textBox.Size = new Size(506, 109);
            ProductDescription_textBox.TabIndex = 13;
            // 
            // ProductName_textBox
            // 
            ProductName_textBox.Location = new Point(119, 83);
            ProductName_textBox.Name = "ProductName_textBox";
            ProductName_textBox.Size = new Size(506, 27);
            ProductName_textBox.TabIndex = 12;
            // 
            // AddProduct_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductStock_label);
            Controls.Add(ProductPrice_label);
            Controls.Add(ProductDesc_label);
            Controls.Add(ProductName_label);
            Controls.Add(ProductImage_label);
            Controls.Add(ProductCancelBtn);
            Controls.Add(ProductSaveBtn);
            Controls.Add(AddImageBtn);
            Controls.Add(ProductStock_textBox);
            Controls.Add(ProductPrice_textBox);
            Controls.Add(ProductDescription_textBox);
            Controls.Add(ProductName_textBox);
            Name = "AddProduct_page";
            Size = new Size(882, 553);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProductStock_label;
        private Label ProductPrice_label;
        private Label ProductDesc_label;
        private Label ProductName_label;
        private Label ProductImage_label;
        private Button ProductCancelBtn;
        private Button ProductSaveBtn;
        private Button AddImageBtn;
        private TextBox ProductStock_textBox;
        private TextBox ProductPrice_textBox;
        private TextBox ProductDescription_textBox;
        private TextBox ProductName_textBox;
    }
}
