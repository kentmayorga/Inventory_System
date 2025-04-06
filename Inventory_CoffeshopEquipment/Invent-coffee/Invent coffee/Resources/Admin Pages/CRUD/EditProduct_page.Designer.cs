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
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // ProductStocks_label
            // 
            ProductStocks_label.AutoSize = true;
            ProductStocks_label.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductStocks_label.Location = new Point(443, 257);
            ProductStocks_label.Name = "ProductStocks_label";
            ProductStocks_label.Size = new Size(122, 20);
            ProductStocks_label.TabIndex = 19;
            ProductStocks_label.Text = "Product Stocks:";
            // 
            // ProductPrice_label
            // 
            ProductPrice_label.AutoSize = true;
            ProductPrice_label.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductPrice_label.Location = new Point(95, 257);
            ProductPrice_label.Name = "ProductPrice_label";
            ProductPrice_label.Size = new Size(113, 20);
            ProductPrice_label.TabIndex = 18;
            ProductPrice_label.Text = "Product Price:";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(639, 338);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 30);
            button1.TabIndex = 17;
            button1.Text = "CANCEL";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = SystemColors.ActiveBorder;
            UpdateBtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UpdateBtn.Location = new Point(42, 338);
            UpdateBtn.Margin = new Padding(3, 2, 3, 2);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(82, 30);
            UpdateBtn.TabIndex = 16;
            UpdateBtn.Text = "UPDATE";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // ProductDescription_label
            // 
            ProductDescription_label.AutoSize = true;
            ProductDescription_label.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductDescription_label.Location = new Point(95, 145);
            ProductDescription_label.Name = "ProductDescription_label";
            ProductDescription_label.Size = new Size(159, 20);
            ProductDescription_label.TabIndex = 15;
            ProductDescription_label.Text = "Product Description:";
            // 
            // ProductName_label
            // 
            ProductName_label.AutoSize = true;
            ProductName_label.Font = new Font("Century", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProductName_label.Location = new Point(95, 88);
            ProductName_label.Name = "ProductName_label";
            ProductName_label.Size = new Size(119, 20);
            ProductName_label.TabIndex = 14;
            ProductName_label.Text = "Product Name:";
            // 
            // ProductStock_textBox
            // 
            ProductStock_textBox.Location = new Point(570, 254);
            ProductStock_textBox.Margin = new Padding(3, 2, 3, 2);
            ProductStock_textBox.Name = "ProductStock_textBox";
            ProductStock_textBox.Size = new Size(126, 23);
            ProductStock_textBox.TabIndex = 13;
            // 
            // ProductPrice_textBox
            // 
            ProductPrice_textBox.Location = new Point(262, 254);
            ProductPrice_textBox.Margin = new Padding(3, 2, 3, 2);
            ProductPrice_textBox.Name = "ProductPrice_textBox";
            ProductPrice_textBox.Size = new Size(126, 23);
            ProductPrice_textBox.TabIndex = 12;
            // 
            // ProductDesc_textBox
            // 
            ProductDesc_textBox.Location = new Point(262, 136);
            ProductDesc_textBox.Margin = new Padding(3, 2, 3, 2);
            ProductDesc_textBox.Multiline = true;
            ProductDesc_textBox.Name = "ProductDesc_textBox";
            ProductDesc_textBox.Size = new Size(246, 87);
            ProductDesc_textBox.TabIndex = 11;
            // 
            // ProductName_textBox
            // 
            ProductName_textBox.Location = new Point(262, 85);
            ProductName_textBox.Margin = new Padding(3, 2, 3, 2);
            ProductName_textBox.Name = "ProductName_textBox";
            ProductName_textBox.Size = new Size(199, 23);
            ProductName_textBox.TabIndex = 10;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.icons8_home_30;
            button2.Location = new Point(18, 17);
            button2.Name = "button2";
            button2.Size = new Size(42, 44);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(275, 17);
            label1.Name = "label1";
            label1.Size = new Size(233, 33);
            label1.TabIndex = 21;
            label1.Text = "EDIT PRODUCT";
            // 
            // EditProduct_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(label1);
            Controls.Add(button2);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "EditProduct_page";
            Size = new Size(772, 415);
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
        private Button button2;
        private Label label1;
    }
}
