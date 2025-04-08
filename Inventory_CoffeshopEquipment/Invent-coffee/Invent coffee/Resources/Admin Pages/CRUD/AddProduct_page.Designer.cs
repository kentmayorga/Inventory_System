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
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // ProductStock_label
            // 
            ProductStock_label.AutoSize = true;
            ProductStock_label.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductStock_label.Location = new Point(439, 259);
            ProductStock_label.Name = "ProductStock_label";
            ProductStock_label.Size = new Size(115, 20);
            ProductStock_label.TabIndex = 23;
            ProductStock_label.Text = "Product Stock:";
            // 
            // ProductPrice_label
            // 
            ProductPrice_label.AutoSize = true;
            ProductPrice_label.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPrice_label.Location = new Point(89, 262);
            ProductPrice_label.Name = "ProductPrice_label";
            ProductPrice_label.Size = new Size(113, 20);
            ProductPrice_label.TabIndex = 22;
            ProductPrice_label.Text = "Product Price:";
            // 
            // ProductDesc_label
            // 
            ProductDesc_label.AutoSize = true;
            ProductDesc_label.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductDesc_label.Location = new Point(89, 145);
            ProductDesc_label.Name = "ProductDesc_label";
            ProductDesc_label.Size = new Size(159, 20);
            ProductDesc_label.TabIndex = 21;
            ProductDesc_label.Text = "Product Description:";
            // 
            // ProductName_label
            // 
            ProductName_label.AutoSize = true;
            ProductName_label.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductName_label.Location = new Point(89, 94);
            ProductName_label.Name = "ProductName_label";
            ProductName_label.Size = new Size(119, 20);
            ProductName_label.TabIndex = 20;
            ProductName_label.Text = "Product Name:";
            // 
            // ProductImage_label
            // 
            ProductImage_label.AutoSize = true;
            ProductImage_label.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductImage_label.Location = new Point(373, 304);
            ProductImage_label.Name = "ProductImage_label";
            ProductImage_label.Size = new Size(73, 16);
            ProductImage_label.TabIndex = 19;
            ProductImage_label.Text = "Image_path";
            // 
            // ProductCancelBtn
            // 
            ProductCancelBtn.BackColor = SystemColors.ActiveBorder;
            ProductCancelBtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductCancelBtn.Location = new Point(637, 339);
            ProductCancelBtn.Margin = new Padding(3, 2, 3, 2);
            ProductCancelBtn.Name = "ProductCancelBtn";
            ProductCancelBtn.Size = new Size(82, 30);
            ProductCancelBtn.TabIndex = 18;
            ProductCancelBtn.Text = "CANCEL";
            ProductCancelBtn.UseVisualStyleBackColor = false;
            ProductCancelBtn.Click += ProductCancelBtn_Click;
            // 
            // ProductSaveBtn
            // 
            ProductSaveBtn.BackColor = SystemColors.ActiveBorder;
            ProductSaveBtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductSaveBtn.Location = new Point(53, 339);
            ProductSaveBtn.Margin = new Padding(3, 2, 3, 2);
            ProductSaveBtn.Name = "ProductSaveBtn";
            ProductSaveBtn.Size = new Size(82, 30);
            ProductSaveBtn.TabIndex = 17;
            ProductSaveBtn.Text = "SAVE";
            ProductSaveBtn.UseVisualStyleBackColor = false;
            ProductSaveBtn.Click += ProductSaveBtn_Click;
            // 
            // AddImageBtn
            // 
            AddImageBtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AddImageBtn.Location = new Point(270, 300);
            AddImageBtn.Margin = new Padding(3, 2, 3, 2);
            AddImageBtn.Name = "AddImageBtn";
            AddImageBtn.Size = new Size(82, 22);
            AddImageBtn.TabIndex = 16;
            AddImageBtn.Text = "IMAGE";
            AddImageBtn.UseVisualStyleBackColor = true;
            AddImageBtn.Click += AddImageBtn_Click;
            // 
            // ProductStock_textBox
            // 
            ProductStock_textBox.Location = new Point(575, 259);
            ProductStock_textBox.Margin = new Padding(3, 2, 3, 2);
            ProductStock_textBox.Name = "ProductStock_textBox";
            ProductStock_textBox.Size = new Size(110, 23);
            ProductStock_textBox.TabIndex = 15;
            // 
            // ProductPrice_textBox
            // 
            ProductPrice_textBox.Location = new Point(270, 259);
            ProductPrice_textBox.Margin = new Padding(3, 2, 3, 2);
            ProductPrice_textBox.Name = "ProductPrice_textBox";
            ProductPrice_textBox.Size = new Size(110, 23);
            ProductPrice_textBox.TabIndex = 14;
            // 
            // ProductDescription_textBox
            // 
            ProductDescription_textBox.Location = new Point(270, 145);
            ProductDescription_textBox.Margin = new Padding(3, 2, 3, 2);
            ProductDescription_textBox.Multiline = true;
            ProductDescription_textBox.Name = "ProductDescription_textBox";
            ProductDescription_textBox.Size = new Size(231, 88);
            ProductDescription_textBox.TabIndex = 13;
            // 
            // ProductName_textBox
            // 
            ProductName_textBox.Location = new Point(270, 91);
            ProductName_textBox.Margin = new Padding(3, 2, 3, 2);
            ProductName_textBox.Name = "ProductName_textBox";
            ProductName_textBox.Size = new Size(127, 23);
            ProductName_textBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(312, 11);
            label1.Name = "label1";
            label1.Size = new Size(198, 28);
            label1.TabIndex = 24;
            label1.Text = "ADD PRODUCT";
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = Properties.Resources.icons8_home_30;
            button1.Location = new Point(14, 18);
            button1.Name = "button1";
            button1.Size = new Size(40, 33);
            button1.TabIndex = 25;
            button1.UseVisualStyleBackColor = true;
            // 
            // AddProduct_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(button1);
            Controls.Add(label1);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "AddProduct_page";
            Size = new Size(772, 415);
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
        private Label label1;
        private Button button1;
    }
}
