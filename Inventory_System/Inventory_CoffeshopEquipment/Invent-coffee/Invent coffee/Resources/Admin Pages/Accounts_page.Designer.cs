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
            InformationData_datagridview = new DataGridView();
            tablepanel = new Panel();
            actionslabel = new Label();
            roles_label = new Label();
            addresslabel = new Label();
            contactlabel = new Label();
            namelabel = new Label();
            usernamelabel = new Label();
            Filter_btn = new Button();
            label1 = new Label();
            BackBtn = new Button();
            Searchbar_textbox = new TextBox();
            searchbtn = new Button();
            AddAccountBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)InformationData_datagridview).BeginInit();
            tablepanel.SuspendLayout();
            SuspendLayout();
            // 
            // InformationData_datagridview
            // 
            InformationData_datagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            InformationData_datagridview.Location = new Point(8, 134);
            InformationData_datagridview.Margin = new Padding(3, 4, 3, 4);
            InformationData_datagridview.Name = "InformationData_datagridview";
            InformationData_datagridview.RowHeadersWidth = 51;
            InformationData_datagridview.Size = new Size(860, 415);
            InformationData_datagridview.TabIndex = 0;
            InformationData_datagridview.CellContentClick += InformationData_datagridview_CellContentClick;
            // 
            // tablepanel
            // 
            tablepanel.BackColor = Color.Transparent;
            tablepanel.Controls.Add(actionslabel);
            tablepanel.Controls.Add(roles_label);
            tablepanel.Controls.Add(addresslabel);
            tablepanel.Controls.Add(contactlabel);
            tablepanel.Controls.Add(namelabel);
            tablepanel.Controls.Add(usernamelabel);
            tablepanel.Location = new Point(5, 102);
            tablepanel.Margin = new Padding(3, 4, 3, 4);
            tablepanel.Name = "tablepanel";
            tablepanel.Size = new Size(875, 29);
            tablepanel.TabIndex = 1;
            // 
            // actionslabel
            // 
            actionslabel.AutoSize = true;
            actionslabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            actionslabel.ForeColor = Color.White;
            actionslabel.Location = new Point(701, 0);
            actionslabel.Name = "actionslabel";
            actionslabel.Size = new Size(80, 21);
            actionslabel.TabIndex = 5;
            actionslabel.Text = "STATUS";
            // 
            // roles_label
            // 
            roles_label.AutoSize = true;
            roles_label.BackColor = Color.Transparent;
            roles_label.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            roles_label.ForeColor = Color.White;
            roles_label.Location = new Point(560, 0);
            roles_label.Name = "roles_label";
            roles_label.Size = new Size(58, 21);
            roles_label.TabIndex = 4;
            roles_label.Text = "ROLE";
            // 
            // addresslabel
            // 
            addresslabel.AutoSize = true;
            addresslabel.BackColor = Color.Transparent;
            addresslabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addresslabel.ForeColor = Color.White;
            addresslabel.Location = new Point(424, 0);
            addresslabel.Name = "addresslabel";
            addresslabel.Size = new Size(94, 21);
            addresslabel.TabIndex = 3;
            addresslabel.Text = "ADDRESS";
            // 
            // contactlabel
            // 
            contactlabel.AutoSize = true;
            contactlabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            contactlabel.ForeColor = Color.White;
            contactlabel.Location = new Point(266, 0);
            contactlabel.Name = "contactlabel";
            contactlabel.Size = new Size(132, 21);
            contactlabel.TabIndex = 2;
            contactlabel.Text = "CONTACT NO.";
            // 
            // namelabel
            // 
            namelabel.AutoSize = true;
            namelabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            namelabel.ForeColor = Color.White;
            namelabel.Location = new Point(3, 0);
            namelabel.Name = "namelabel";
            namelabel.Size = new Size(64, 21);
            namelabel.TabIndex = 1;
            namelabel.Text = "NAME";
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Font = new Font("Century", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usernamelabel.ForeColor = Color.White;
            usernamelabel.Location = new Point(95, 0);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(113, 21);
            usernamelabel.TabIndex = 0;
            usernamelabel.Text = "USERNAME";
            // 
            // Filter_btn
            // 
            Filter_btn.FlatAppearance.BorderSize = 0;
            Filter_btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            Filter_btn.FlatStyle = FlatStyle.Flat;
            Filter_btn.Image = (Image)resources.GetObject("Filter_btn.Image");
            Filter_btn.Location = new Point(507, 62);
            Filter_btn.Margin = new Padding(3, 4, 3, 4);
            Filter_btn.Name = "Filter_btn";
            Filter_btn.Size = new Size(34, 32);
            Filter_btn.TabIndex = 7;
            Filter_btn.UseVisualStyleBackColor = true;
            Filter_btn.Click += Filter_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(293, 16);
            label1.Name = "label1";
            label1.Size = new Size(319, 35);
            label1.TabIndex = 6;
            label1.Text = "USERS ACCOUNTS";
            // 
            // BackBtn
            // 
            BackBtn.FlatAppearance.BorderSize = 0;
            BackBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            BackBtn.FlatStyle = FlatStyle.Flat;
            BackBtn.Image = (Image)resources.GetObject("BackBtn.Image");
            BackBtn.Location = new Point(830, 16);
            BackBtn.Margin = new Padding(0);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(38, 36);
            BackBtn.TabIndex = 7;
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // Searchbar_textbox
            // 
            Searchbar_textbox.Location = new Point(547, 67);
            Searchbar_textbox.Margin = new Padding(3, 4, 3, 4);
            Searchbar_textbox.Name = "Searchbar_textbox";
            Searchbar_textbox.Size = new Size(231, 27);
            Searchbar_textbox.TabIndex = 10;
            // 
            // searchbtn
            // 
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Century", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.ForeColor = Color.White;
            searchbtn.Location = new Point(784, 64);
            searchbtn.Margin = new Padding(3, 4, 3, 4);
            searchbtn.Name = "searchbtn";
            searchbtn.Size = new Size(92, 31);
            searchbtn.TabIndex = 11;
            searchbtn.Text = "Search";
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // AddAccountBtn
            // 
            AddAccountBtn.FlatAppearance.BorderSize = 0;
            AddAccountBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            AddAccountBtn.FlatStyle = FlatStyle.Flat;
            AddAccountBtn.Image = (Image)resources.GetObject("AddAccountBtn.Image");
            AddAccountBtn.Location = new Point(8, 60);
            AddAccountBtn.Margin = new Padding(0);
            AddAccountBtn.Name = "AddAccountBtn";
            AddAccountBtn.Size = new Size(38, 36);
            AddAccountBtn.TabIndex = 12;
            AddAccountBtn.UseVisualStyleBackColor = true;
            AddAccountBtn.Click += AddAccountBtn_Click;
            // 
            // Accounts_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Sienna;
            Controls.Add(AddAccountBtn);
            Controls.Add(Filter_btn);
            Controls.Add(searchbtn);
            Controls.Add(Searchbar_textbox);
            Controls.Add(BackBtn);
            Controls.Add(label1);
            Controls.Add(tablepanel);
            Controls.Add(InformationData_datagridview);
            Name = "Accounts_page";
            Size = new Size(882, 553);
            ((System.ComponentModel.ISupportInitialize)InformationData_datagridview).EndInit();
            tablepanel.ResumeLayout(false);
            tablepanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView InformationData_datagridview;
        private Panel tablepanel;
        private Label usernamelabel;
        private Label roles_label;
        private Label addresslabel;
        private Label contactlabel;
        private Label namelabel;
        private Label actionslabel;
        private Label label1;
        private Button Filter_btn;
        private Button BackBtn;
        private TextBox Searchbar_textbox;
        private Button searchbtn;
        private Button AddAccountBtn;
    }
}
