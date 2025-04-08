namespace Invent_coffee.Resources.Admin_Pages
{
    partial class Order_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Order_page));
            OrderInfo_dataGridView = new DataGridView();
            OrderTitle_label = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Customer_label = new Label();
            Date_label = new Label();
            Backbtn = new Button();
            SearchBar_textBox = new TextBox();
            SearchBtn = new Button();
            FilterBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)OrderInfo_dataGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // OrderInfo_dataGridView
            // 
            OrderInfo_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrderInfo_dataGridView.Location = new Point(6, 147);
            OrderInfo_dataGridView.Margin = new Padding(3, 4, 3, 4);
            OrderInfo_dataGridView.Name = "OrderInfo_dataGridView";
            OrderInfo_dataGridView.RowHeadersWidth = 51;
            OrderInfo_dataGridView.Size = new Size(862, 404);
            OrderInfo_dataGridView.TabIndex = 0;
            // 
            // OrderTitle_label
            // 
            OrderTitle_label.AutoSize = true;
            OrderTitle_label.BackColor = Color.Transparent;
            OrderTitle_label.Font = new Font("Century", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            OrderTitle_label.ForeColor = Color.White;
            OrderTitle_label.Location = new Point(354, 20);
            OrderTitle_label.Name = "OrderTitle_label";
            OrderTitle_label.Size = new Size(171, 40);
            OrderTitle_label.TabIndex = 1;
            OrderTitle_label.Text = "ORDERS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(Customer_label);
            panel1.Controls.Add(Date_label);
            panel1.Location = new Point(3, 109);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(873, 30);
            panel1.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(760, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 23);
            label6.TabIndex = 5;
            label6.Text = "ACTIONS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(539, 0);
            label5.Name = "label5";
            label5.Size = new Size(166, 23);
            label5.TabIndex = 4;
            label5.Text = "ORDER STATUS";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(292, 0);
            label4.Name = "label4";
            label4.Size = new Size(194, 23);
            label4.TabIndex = 3;
            label4.Text = "PAYMENT STATUS";
            // 
            // Customer_label
            // 
            Customer_label.AutoSize = true;
            Customer_label.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Customer_label.ForeColor = Color.White;
            Customer_label.Location = new Point(114, 0);
            Customer_label.Name = "Customer_label";
            Customer_label.Size = new Size(125, 23);
            Customer_label.TabIndex = 2;
            Customer_label.Text = "CUSTOMER";
            // 
            // Date_label
            // 
            Date_label.AutoSize = true;
            Date_label.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Date_label.ForeColor = Color.White;
            Date_label.Location = new Point(3, 0);
            Date_label.Name = "Date_label";
            Date_label.Size = new Size(66, 23);
            Date_label.TabIndex = 1;
            Date_label.Text = "DATE";
            // 
            // Backbtn
            // 
            Backbtn.FlatAppearance.BorderSize = 0;
            Backbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            Backbtn.FlatStyle = FlatStyle.Flat;
            Backbtn.ForeColor = Color.Transparent;
            Backbtn.Image = (Image)resources.GetObject("Backbtn.Image");
            Backbtn.Location = new Point(820, 16);
            Backbtn.Margin = new Padding(3, 4, 3, 4);
            Backbtn.Name = "Backbtn";
            Backbtn.Size = new Size(48, 44);
            Backbtn.TabIndex = 8;
            Backbtn.UseVisualStyleBackColor = true;
            Backbtn.Click += Backbtn_Click;
            // 
            // SearchBar_textBox
            // 
            SearchBar_textBox.Location = new Point(527, 73);
            SearchBar_textBox.Margin = new Padding(3, 4, 3, 4);
            SearchBar_textBox.Name = "SearchBar_textBox";
            SearchBar_textBox.Size = new Size(243, 27);
            SearchBar_textBox.TabIndex = 6;
            // 
            // SearchBtn
            // 
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(778, 70);
            SearchBtn.Margin = new Padding(3, 4, 3, 4);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(86, 31);
            SearchBtn.TabIndex = 9;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = true;
            SearchBtn.Click += SearchBtn_Click;
            // 
            // FilterBtn
            // 
            FilterBtn.FlatAppearance.BorderSize = 0;
            FilterBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            FilterBtn.FlatStyle = FlatStyle.Flat;
            FilterBtn.ForeColor = Color.Transparent;
            FilterBtn.Image = (Image)resources.GetObject("FilterBtn.Image");
            FilterBtn.Location = new Point(472, 70);
            FilterBtn.Margin = new Padding(3, 4, 3, 4);
            FilterBtn.Name = "FilterBtn";
            FilterBtn.Size = new Size(38, 35);
            FilterBtn.TabIndex = 10;
            FilterBtn.UseVisualStyleBackColor = true;
            FilterBtn.Click += FilterBtn_Click;
            // 
            // Order_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(FilterBtn);
            Controls.Add(SearchBtn);
            Controls.Add(SearchBar_textBox);
            Controls.Add(Backbtn);
            Controls.Add(panel1);
            Controls.Add(OrderTitle_label);
            Controls.Add(OrderInfo_dataGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Order_page";
            Size = new Size(880, 555);
            ((System.ComponentModel.ISupportInitialize)OrderInfo_dataGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView OrderInfo_dataGridView;
        private Label OrderTitle_label;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label Customer_label;
        private Label Date_label;
        private Label label6;
        private Button Backbtn;
        private TextBox SearchBar_textBox;
        private Button SearchBtn;
        private Button FilterBtn;
    }
}
