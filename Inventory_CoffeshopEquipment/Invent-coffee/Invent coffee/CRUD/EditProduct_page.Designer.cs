namespace Invent_coffee.CRUD
{
    partial class EditProduct_page
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
            ProductName_textBox = new TextBox();
            ProductDesc_textBox = new TextBox();
            ProductPrice_textBox = new TextBox();
            ProductStock_textBox = new TextBox();
            ProductName_label = new Label();
            ProductDescription_label = new Label();
            UpdateBtn = new Button();
            button1 = new Button();
            ProductPrice_label = new Label();
            ProductStocks_label = new Label();
            SuspendLayout();
            // 
            // ProductName_textBox
            // 
            ProductName_textBox.Location = new Point(128, 101);
            ProductName_textBox.Name = "ProductName_textBox";
            ProductName_textBox.Size = new Size(227, 27);
            ProductName_textBox.TabIndex = 0;
            // 
            // ProductDesc_textBox
            // 
            ProductDesc_textBox.Location = new Point(128, 157);
            ProductDesc_textBox.Multiline = true;
            ProductDesc_textBox.Name = "ProductDesc_textBox";
            ProductDesc_textBox.Size = new Size(227, 66);
            ProductDesc_textBox.TabIndex = 1;
            // 
            // ProductPrice_textBox
            // 
            ProductPrice_textBox.Location = new Point(128, 251);
            ProductPrice_textBox.Name = "ProductPrice_textBox";
            ProductPrice_textBox.Size = new Size(143, 27);
            ProductPrice_textBox.TabIndex = 2;
            // 
            // ProductStock_textBox
            // 
            ProductStock_textBox.Location = new Point(128, 312);
            ProductStock_textBox.Name = "ProductStock_textBox";
            ProductStock_textBox.Size = new Size(143, 27);
            ProductStock_textBox.TabIndex = 3;
            // 
            // ProductName_label
            // 
            ProductName_label.AutoSize = true;
            ProductName_label.Location = new Point(128, 66);
            ProductName_label.Name = "ProductName_label";
            ProductName_label.Size = new Size(107, 20);
            ProductName_label.TabIndex = 4;
            ProductName_label.Text = "Product Name:";
            // 
            // ProductDescription_label
            // 
            ProductDescription_label.AutoSize = true;
            ProductDescription_label.Location = new Point(128, 134);
            ProductDescription_label.Name = "ProductDescription_label";
            ProductDescription_label.Size = new Size(143, 20);
            ProductDescription_label.TabIndex = 5;
            ProductDescription_label.Text = "Product Description:";
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(576, 443);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 6;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(704, 443);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 7;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductPrice_label
            // 
            ProductPrice_label.AutoSize = true;
            ProductPrice_label.Location = new Point(128, 228);
            ProductPrice_label.Name = "ProductPrice_label";
            ProductPrice_label.Size = new Size(99, 20);
            ProductPrice_label.TabIndex = 8;
            ProductPrice_label.Text = "Product Price:";
            // 
            // ProductStocks_label
            // 
            ProductStocks_label.AutoSize = true;
            ProductStocks_label.Location = new Point(128, 289);
            ProductStocks_label.Name = "ProductStocks_label";
            ProductStocks_label.Size = new Size(109, 20);
            ProductStocks_label.TabIndex = 9;
            ProductStocks_label.Text = "Product Stocks:";
            // 
            // EditProduct_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProductStocks_label);
            Controls.Add(ProductPrice_label);
            Controls.Add(button1);
            Controls.Add(UpdateBtn);
            Controls.Add(ProductDescription_label);
            Controls.Add(ProductName_label);
            Controls.Add(ProductStock_textBox);
            Controls.Add(ProductPrice_textBox);
            Controls.Add(ProductDesc_textBox);
            Controls.Add(ProductName_textBox);
            Name = "EditProduct_page";
            Size = new Size(882, 553);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ProductName_textBox;
        private TextBox ProductDesc_textBox;
        private TextBox ProductPrice_textBox;
        private TextBox ProductStock_textBox;
        private Label ProductName_label;
        private Label ProductDescription_label;
        private Button UpdateBtn;
        private Button button1;
        private Label ProductPrice_label;
        private Label ProductStocks_label;
    }
}
