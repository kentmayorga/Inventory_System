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
            dataGridView1 = new DataGridView();
            Titlepage = new Label();
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            markasdonebtn = new Button();
            vieworderbtn = new Button();
            homebtn = new Button();
            textBox1 = new TextBox();
            searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 138);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(764, 275);
            dataGridView1.TabIndex = 0;
            // 
            // Titlepage
            // 
            Titlepage.AutoSize = true;
            Titlepage.BackColor = Color.Transparent;
            Titlepage.Font = new Font("Century", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Titlepage.ForeColor = Color.White;
            Titlepage.Location = new Point(310, 15);
            Titlepage.Name = "Titlepage";
            Titlepage.Size = new Size(140, 33);
            Titlepage.TabIndex = 1;
            Titlepage.Text = "ORDERS";
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 82);
            panel1.Name = "panel1";
            panel1.Size = new Size(764, 50);
            panel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(20, 16);
            label1.Name = "label1";
            label1.Size = new Size(87, 18);
            label1.TabIndex = 0;
            label1.Text = "ORDER ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(113, 16);
            label2.Name = "label2";
            label2.Size = new Size(52, 18);
            label2.TabIndex = 1;
            label2.Text = "DATE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(180, 16);
            label3.Name = "label3";
            label3.Size = new Size(98, 18);
            label3.TabIndex = 2;
            label3.Text = "CUSTOMER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(284, 16);
            label4.Name = "label4";
            label4.Size = new Size(152, 18);
            label4.TabIndex = 3;
            label4.Text = "PAYMENT STATUS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(442, 16);
            label5.Name = "label5";
            label5.Size = new Size(130, 18);
            label5.TabIndex = 4;
            label5.Text = "ORDER STATUS";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(641, 16);
            label6.Name = "label6";
            label6.Size = new Size(79, 18);
            label6.TabIndex = 5;
            label6.Text = "ACTIONS";
            // 
            // markasdonebtn
            // 
            markasdonebtn.Location = new Point(578, 153);
            markasdonebtn.Name = "markasdonebtn";
            markasdonebtn.Size = new Size(87, 21);
            markasdonebtn.TabIndex = 6;
            markasdonebtn.Text = "Mark as done";
            markasdonebtn.UseVisualStyleBackColor = true;
            // 
            // vieworderbtn
            // 
            vieworderbtn.Location = new Point(671, 153);
            vieworderbtn.Name = "vieworderbtn";
            vieworderbtn.Size = new Size(84, 21);
            vieworderbtn.TabIndex = 7;
            vieworderbtn.Text = "View Order";
            vieworderbtn.UseVisualStyleBackColor = true;
            // 
            // homebtn
            // 
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.ForeColor = Color.Transparent;
            homebtn.Image = Properties.Resources.icons8_home_30;
            homebtn.Location = new Point(23, 15);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(42, 33);
            homebtn.TabIndex = 8;
            homebtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(494, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(196, 23);
            textBox1.TabIndex = 6;
            // 
            // searchbtn
            // 
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(692, 52);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 9;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // Order_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(searchbtn);
            Controls.Add(textBox1);
            Controls.Add(homebtn);
            Controls.Add(markasdonebtn);
            Controls.Add(vieworderbtn);
            Controls.Add(panel1);
            Controls.Add(Titlepage);
            Controls.Add(dataGridView1);
            Name = "Order_page";
            Size = new Size(770, 416);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label Titlepage;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Button markasdonebtn;
        private Button vieworderbtn;
        private Button homebtn;
        private TextBox textBox1;
        private Button searchbtn;
    }
}
