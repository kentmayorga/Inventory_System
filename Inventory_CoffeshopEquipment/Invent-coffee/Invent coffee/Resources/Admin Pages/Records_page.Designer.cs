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
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            title = new Label();
            orderidlabel = new Label();
            datelabel = new Label();
            customername = new Label();
            orderstatuslabel = new Label();
            totalpayment = new Label();
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
            dataGridView1.Location = new Point(3, 140);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(760, 276);
            dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(orderidlabel);
            panel1.Controls.Add(datelabel);
            panel1.Controls.Add(customername);
            panel1.Controls.Add(orderstatuslabel);
            panel1.Controls.Add(totalpayment);
            panel1.Location = new Point(6, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(757, 54);
            panel1.TabIndex = 1;
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Century", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            title.ForeColor = Color.White;
            title.Location = new Point(212, 12);
            title.Name = "title";
            title.Size = new Size(345, 33);
            title.TabIndex = 2;
            title.Text = "RECORDS OF ORDERS";
            // 
            // orderidlabel
            // 
            orderidlabel.AutoSize = true;
            orderidlabel.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderidlabel.ForeColor = Color.White;
            orderidlabel.Location = new Point(29, 17);
            orderidlabel.Name = "orderidlabel";
            orderidlabel.Size = new Size(87, 18);
            orderidlabel.TabIndex = 3;
            orderidlabel.Text = "ORDER ID";
            // 
            // datelabel
            // 
            datelabel.AutoSize = true;
            datelabel.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datelabel.ForeColor = Color.White;
            datelabel.Location = new Point(173, 17);
            datelabel.Name = "datelabel";
            datelabel.Size = new Size(52, 18);
            datelabel.TabIndex = 4;
            datelabel.Text = "DATE";
            // 
            // customername
            // 
            customername.AutoSize = true;
            customername.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            customername.ForeColor = Color.White;
            customername.Location = new Point(276, 17);
            customername.Name = "customername";
            customername.Size = new Size(98, 18);
            customername.TabIndex = 5;
            customername.Text = "CUSTOMER";
            // 
            // orderstatuslabel
            // 
            orderstatuslabel.AutoSize = true;
            orderstatuslabel.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderstatuslabel.ForeColor = Color.White;
            orderstatuslabel.Location = new Point(421, 17);
            orderstatuslabel.Name = "orderstatuslabel";
            orderstatuslabel.Size = new Size(130, 18);
            orderstatuslabel.TabIndex = 6;
            orderstatuslabel.Text = "ORDER STATUS";
            // 
            // totalpayment
            // 
            totalpayment.AutoSize = true;
            totalpayment.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalpayment.ForeColor = Color.White;
            totalpayment.Location = new Point(591, 17);
            totalpayment.Name = "totalpayment";
            totalpayment.Size = new Size(144, 18);
            totalpayment.TabIndex = 7;
            totalpayment.Text = "TOTAL PAYMENT";
            // 
            // homebtn
            // 
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Image = Properties.Resources.icons8_home_30;
            homebtn.Location = new Point(6, 16);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(39, 37);
            homebtn.TabIndex = 3;
            homebtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(488, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 23);
            textBox1.TabIndex = 4;
            // 
            // searchbtn
            // 
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.Location = new Point(685, 52);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(75, 23);
            searchbtn.TabIndex = 5;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // Records_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(searchbtn);
            Controls.Add(textBox1);
            Controls.Add(homebtn);
            Controls.Add(title);
            Controls.Add(panel1);
            Controls.Add(dataGridView1);
            Name = "Records_page";
            Size = new Size(766, 419);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Panel panel1;
        private Label title;
        private Label orderidlabel;
        private Label datelabel;
        private Label customername;
        private Label orderstatuslabel;
        private Label totalpayment;
        private Button homebtn;
        private TextBox textBox1;
        private Button searchbtn;
    }
}
