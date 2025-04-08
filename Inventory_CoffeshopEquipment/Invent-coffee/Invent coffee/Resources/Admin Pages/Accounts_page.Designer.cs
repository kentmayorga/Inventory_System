namespace Invent_coffee.Resources.Admin_Pages
{
    partial class Accounts_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accounts_page));
            informationgrid = new DataGridView();
            tablepanel = new Panel();
            button1 = new Button();
            actionslabel = new Label();
            numoforderslabel = new Label();
            addresslabel = new Label();
            contactlabel = new Label();
            namelabel = new Label();
            usernamelabel = new Label();
            label1 = new Label();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Searchbox = new TextBox();
            searchbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)informationgrid).BeginInit();
            tablepanel.SuspendLayout();
            SuspendLayout();
            // 
            // informationgrid
            // 
            informationgrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            informationgrid.Location = new Point(3, 131);
            informationgrid.Name = "informationgrid";
            informationgrid.Size = new Size(766, 281);
            informationgrid.TabIndex = 0;
            informationgrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tablepanel
            // 
            tablepanel.BackColor = Color.RosyBrown;
            tablepanel.Controls.Add(button1);
            tablepanel.Controls.Add(actionslabel);
            tablepanel.Controls.Add(numoforderslabel);
            tablepanel.Controls.Add(addresslabel);
            tablepanel.Controls.Add(contactlabel);
            tablepanel.Controls.Add(namelabel);
            tablepanel.Controls.Add(usernamelabel);
            tablepanel.Location = new Point(3, 81);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(766, 44);
            tablepanel.TabIndex = 1;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(724, 9);
            button1.Name = "button1";
            button1.Size = new Size(30, 24);
            button1.TabIndex = 7;
            button1.UseVisualStyleBackColor = true;
            // 
            // actionslabel
            // 
            actionslabel.AutoSize = true;
            actionslabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            actionslabel.ForeColor = Color.White;
            actionslabel.Location = new Point(613, 17);
            actionslabel.Name = "actionslabel";
            actionslabel.Size = new Size(68, 16);
            actionslabel.TabIndex = 5;
            actionslabel.Text = "ACTIONS";
            // 
            // numoforderslabel
            // 
            numoforderslabel.AutoSize = true;
            numoforderslabel.BackColor = Color.Transparent;
            numoforderslabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            numoforderslabel.ForeColor = Color.White;
            numoforderslabel.Location = new Point(475, 17);
            numoforderslabel.Name = "numoforderslabel";
            numoforderslabel.Size = new Size(96, 16);
            numoforderslabel.TabIndex = 4;
            numoforderslabel.Text = "# OF ORDERS";
            // 
            // addresslabel
            // 
            addresslabel.AutoSize = true;
            addresslabel.BackColor = Color.Transparent;
            addresslabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addresslabel.ForeColor = Color.White;
            addresslabel.Location = new Point(362, 17);
            addresslabel.Name = "addresslabel";
            addresslabel.Size = new Size(70, 16);
            addresslabel.TabIndex = 3;
            addresslabel.Text = "ADDRESS";
            // 
            // contactlabel
            // 
            contactlabel.AutoSize = true;
            contactlabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactlabel.ForeColor = Color.White;
            contactlabel.Location = new Point(233, 17);
            contactlabel.Name = "contactlabel";
            contactlabel.Size = new Size(102, 16);
            contactlabel.TabIndex = 2;
            contactlabel.Text = "CONTACT NO.";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelabel.ForeColor = Color.White;
            namelabel.Location = new Point(141, 17);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(48, 16);
            namelabel.TabIndex = 1;
            namelabel.Text = "NAME";
            namelabel.Click += namelabel_Click;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelabel.ForeColor = Color.White;
            usernamelabel.Location = new Point(23, 17);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(85, 16);
            usernamelabel.TabIndex = 0;
            usernamelabel.Text = "USERNAME";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(256, 12);
            label1.Name = "label1";
            label1.Size = new Size(258, 28);
            label1.TabIndex = 6;
            label1.Text = "USERS ACCOUNTS";
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = Properties.Resources.icons8_home_30;
            button2.Location = new Point(13, 23);
            button2.Name = "button2";
            button2.Size = new Size(44, 39);
            button2.TabIndex = 7;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(592, 142);
            button3.Name = "button3";
            button3.Size = new Size(89, 23);
            button3.TabIndex = 8;
            button3.Text = "DEACTIVATE";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(687, 142);
            button4.Name = "button4";
            button4.Size = new Size(40, 23);
            button4.TabIndex = 9;
            button4.Text = "EDIT";
            button4.UseVisualStyleBackColor = true;
            // 
            // Searchbox
            // 
            Searchbox.Location = new Point(503, 51);
            Searchbox.Name = "Searchbox";
            Searchbox.Size = new Size(203, 23);
            Searchbox.TabIndex = 10;
            // 
            // searchbtn
            // 
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(708, 51);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(61, 23);
            searchbtn.TabIndex = 11;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            // 
            // Accounts_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(searchbtn);
            Controls.Add(Searchbox);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(tablepanel);
            Controls.Add(informationgrid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Accounts_page";
            Size = new Size(772, 415);
            ((System.ComponentModel.ISupportInitialize)informationgrid).EndInit();
            tablepanel.ResumeLayout(false);
            tablepanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView informationgrid;
        private Panel tablepanel;
        private Label usernamelabel;
        private Label numoforderslabel;
        private Label addresslabel;
        private Label contactlabel;
        private Label namelabel;
        private Label actionslabel;
        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox Searchbox;
        private Button searchbtn;
    }
}
