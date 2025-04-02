namespace Invent_coffee.Resources.Admin_Pages.CRUD
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
            ProductStocks_label = new Label();
            ProductPrice_label = new Label();
            button1 = new Button();
            UpdateBtn = new Button();
            ProductDescription_label = new Label();
            ProductName_label = new Label();
            ProductStock_textBox = new TextBox();
            ProductPrice_textBox = new TextBox();
            ProductDesc_textBox = new TextBox();
            ProductName_textBox = new TextBox();
            SuspendLayout();
            // 
            // ProductStocks_label
            // 
            ProductStocks_label.AutoSize = true;
            ProductStocks_label.Location = new Point(106, 296);
            ProductStocks_label.Name = "ProductStocks_label";
            ProductStocks_label.Size = new Size(109, 20);
            ProductStocks_label.TabIndex = 19;
            ProductStocks_label.Text = "Product Stocks:";
            // 
            // ProductPrice_label
            // 
            ProductPrice_label.AutoSize = true;
            ProductPrice_label.Location = new Point(106, 235);
            ProductPrice_label.Name = "ProductPrice_label";
            ProductPrice_label.Size = new Size(99, 20);
            ProductPrice_label.TabIndex = 18;
            ProductPrice_label.Text = "Product Price:";
            // 
            // button1
            // 
            button1.Location = new Point(682, 450);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 17;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Location = new Point(554, 450);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(94, 29);
            UpdateBtn.TabIndex = 16;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = true;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ProductDescription_label
            // 
            ProductDescription_label.AutoSize = true;
            ProductDescription_label.Location = new Point(106, 141);
            ProductDescription_label.Name = "ProductDescription_label";
            ProductDescription_label.Size = new Size(143, 20);
            ProductDescription_label.TabIndex = 15;
            ProductDescription_label.Text = "Product Description:";
            // 
            // ProductName_label
            // 
            ProductName_label.AutoSize = true;
            ProductName_label.Location = new Point(106, 73);
            ProductName_label.Name = "ProductName_label";
            ProductName_label.Size = new Size(107, 20);
            ProductName_label.TabIndex = 14;
            ProductName_label.Text = "Product Name:";
            // 
            // ProductStock_textBox
            // 
            ProductStock_textBox.Location = new Point(106, 319);
            ProductStock_textBox.Name = "ProductStock_textBox";
            ProductStock_textBox.Size = new Size(143, 27);
            ProductStock_textBox.TabIndex = 13;
            // 
            // ProductPrice_textBox
            // 
            ProductPrice_textBox.Location = new Point(106, 258);
            ProductPrice_textBox.Name = "ProductPrice_textBox";
            ProductPrice_textBox.Size = new Size(143, 27);
            ProductPrice_textBox.TabIndex = 12;
            // 
            // ProductDesc_textBox
            // 
            ProductDesc_textBox.Location = new Point(106, 164);
            ProductDesc_textBox.Multiline = true;
            ProductDesc_textBox.Name = "ProductDesc_textBox";
            ProductDesc_textBox.Size = new Size(227, 66);
            ProductDesc_textBox.TabIndex = 11;
            // 
            // ProductName_textBox
            // 
            ProductName_textBox.Location = new Point(106, 108);
            ProductName_textBox.Name = "ProductName_textBox";
            ProductName_textBox.Size = new Size(227, 27);
            ProductName_textBox.TabIndex = 10;
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

        private Label ProductStocks_label;
        private Label ProductPrice_label;
        private Button button1;
        private Button UpdateBtn;
        private Label ProductDescription_label;
        private Label ProductName_label;
        private TextBox ProductStock_textBox;
        private TextBox ProductPrice_textBox;
        private TextBox ProductDesc_textBox;
        private TextBox ProductName_textBox;
    }
}
