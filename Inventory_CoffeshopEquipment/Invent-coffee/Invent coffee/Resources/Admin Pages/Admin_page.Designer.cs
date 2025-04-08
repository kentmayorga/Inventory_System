namespace Invent_coffee
{
    partial class Admin_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_page));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            InventoryBtn = new Button();
            RecordBtn = new Button();
            OrderBtn = new Button();
            LogOutBtn = new Button();
            MenuPanel = new Panel();
            NavBarBtn = new Button();
            ShopMIcon = new PictureBox();
            AccountBtn = new Button();
            MenuTitleLabel = new Label();
            MiniMenuPanel = new Panel();
            MiniNavLogOutBtn = new Button();
            MenuBarBtn = new Button();
            MiniNavBarAccountBtn = new Button();
            MiniNavBarRecordBtn = new Button();
            MiniNavBarOrderBtn = new Button();
            MiniNavBarInventoryBtn = new Button();
            ShopIcon_PictureBox = new PictureBox();
            GreetingLabel = new Label();
            UserRoleLabel = new Label();
            Stocks_dataGridView = new DataGridView();
            Sales_dataGridView = new DataGridView();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShopMIcon).BeginInit();
            MiniMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShopIcon_PictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Stocks_dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Sales_dataGridView).BeginInit();
            SuspendLayout();
            // 
            // InventoryBtn
            // 
            InventoryBtn.BackColor = Color.Transparent;
            InventoryBtn.FlatAppearance.BorderSize = 0;
            InventoryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            InventoryBtn.FlatStyle = FlatStyle.Flat;
            InventoryBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InventoryBtn.ForeColor = SystemColors.ButtonHighlight;
            InventoryBtn.Image = Properties.Resources.icons8_trolley_32;
            InventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            InventoryBtn.Location = new Point(1, 77);
            InventoryBtn.Margin = new Padding(0);
            InventoryBtn.Name = "InventoryBtn";
            InventoryBtn.Size = new Size(173, 59);
            InventoryBtn.TabIndex = 0;
            InventoryBtn.Text = "INVENTORY";
            InventoryBtn.TextAlign = ContentAlignment.MiddleRight;
            InventoryBtn.UseVisualStyleBackColor = false;
            InventoryBtn.Click += InventoryBtn_Click;
            // 
            // RecordBtn
            // 
            RecordBtn.BackColor = Color.Transparent;
            RecordBtn.FlatAppearance.BorderSize = 0;
            RecordBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            RecordBtn.FlatStyle = FlatStyle.Flat;
            RecordBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordBtn.ForeColor = SystemColors.ButtonHighlight;
            RecordBtn.Image = Properties.Resources.icons8_list_view_26;
            RecordBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RecordBtn.Location = new Point(0, 195);
            RecordBtn.Name = "RecordBtn";
            RecordBtn.Size = new Size(173, 59);
            RecordBtn.TabIndex = 1;
            RecordBtn.Text = "RECORDS";
            RecordBtn.UseVisualStyleBackColor = false;
            RecordBtn.Click += RecordBtn_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.BackColor = Color.Transparent;
            OrderBtn.FlatAppearance.BorderSize = 0;
            OrderBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            OrderBtn.FlatStyle = FlatStyle.Flat;
            OrderBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderBtn.ForeColor = SystemColors.ControlLightLight;
            OrderBtn.Image = Properties.Resources.icons8_product_26;
            OrderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            OrderBtn.Location = new Point(1, 136);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(173, 59);
            OrderBtn.TabIndex = 2;
            OrderBtn.Text = "ORDERS";
            OrderBtn.UseVisualStyleBackColor = false;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.Transparent;
            LogOutBtn.FlatAppearance.BorderSize = 0;
            LogOutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            LogOutBtn.FlatStyle = FlatStyle.Flat;
            LogOutBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutBtn.ForeColor = SystemColors.ButtonHighlight;
            LogOutBtn.Image = (Image)resources.GetObject("LogOutBtn.Image");
            LogOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogOutBtn.Location = new Point(0, 445);
            LogOutBtn.Margin = new Padding(0);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(174, 51);
            LogOutBtn.TabIndex = 3;
            LogOutBtn.Text = "LOG OUT";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.Sienna;
            MenuPanel.Controls.Add(NavBarBtn);
            MenuPanel.Controls.Add(ShopMIcon);
            MenuPanel.Controls.Add(AccountBtn);
            MenuPanel.Controls.Add(MenuTitleLabel);
            MenuPanel.Controls.Add(InventoryBtn);
            MenuPanel.Controls.Add(RecordBtn);
            MenuPanel.Controls.Add(LogOutBtn);
            MenuPanel.Controls.Add(OrderBtn);
            MenuPanel.Dock = DockStyle.Left;
            MenuPanel.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Margin = new Padding(3, 4, 3, 4);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(175, 553);
            MenuPanel.TabIndex = 4;
            // 
            // NavBarBtn
            // 
            NavBarBtn.FlatAppearance.BorderSize = 0;
            NavBarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            NavBarBtn.FlatStyle = FlatStyle.Flat;
            NavBarBtn.Image = (Image)resources.GetObject("NavBarBtn.Image");
            NavBarBtn.Location = new Point(3, 515);
            NavBarBtn.Name = "NavBarBtn";
            NavBarBtn.Size = new Size(170, 35);
            NavBarBtn.TabIndex = 11;
            NavBarBtn.UseVisualStyleBackColor = true;
            NavBarBtn.Click += NavBarBtn_Click;
            // 
            // ShopMIcon
            // 
            ShopMIcon.BackColor = Color.Sienna;
            ShopMIcon.BackgroundImageLayout = ImageLayout.Center;
            ShopMIcon.Image = (Image)resources.GetObject("ShopMIcon.Image");
            ShopMIcon.Location = new Point(7, 4);
            ShopMIcon.Name = "ShopMIcon";
            ShopMIcon.Size = new Size(43, 43);
            ShopMIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            ShopMIcon.TabIndex = 8;
            ShopMIcon.TabStop = false;
            // 
            // AccountBtn
            // 
            AccountBtn.BackColor = Color.Transparent;
            AccountBtn.FlatAppearance.BorderSize = 0;
            AccountBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            AccountBtn.FlatStyle = FlatStyle.Flat;
            AccountBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountBtn.ForeColor = SystemColors.ButtonHighlight;
            AccountBtn.Image = (Image)resources.GetObject("AccountBtn.Image");
            AccountBtn.ImageAlign = ContentAlignment.MiddleLeft;
            AccountBtn.Location = new Point(0, 253);
            AccountBtn.Name = "AccountBtn";
            AccountBtn.Size = new Size(173, 59);
            AccountBtn.TabIndex = 6;
            AccountBtn.Text = "ACCOUNTS";
            AccountBtn.TextAlign = ContentAlignment.MiddleRight;
            AccountBtn.UseVisualStyleBackColor = false;
            AccountBtn.Click += AccountBtn_Click;
            // 
            // MenuTitleLabel
            // 
            MenuTitleLabel.AutoSize = true;
            MenuTitleLabel.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MenuTitleLabel.Location = new Point(56, 11);
            MenuTitleLabel.Name = "MenuTitleLabel";
            MenuTitleLabel.Size = new Size(111, 33);
            MenuTitleLabel.TabIndex = 5;
            MenuTitleLabel.Text = "MENU";
            // 
            // MiniMenuPanel
            // 
            MiniMenuPanel.BackColor = Color.Sienna;
            MiniMenuPanel.Controls.Add(MiniNavLogOutBtn);
            MiniMenuPanel.Controls.Add(MenuBarBtn);
            MiniMenuPanel.Controls.Add(MiniNavBarAccountBtn);
            MiniMenuPanel.Controls.Add(MiniNavBarRecordBtn);
            MiniMenuPanel.Controls.Add(MiniNavBarOrderBtn);
            MiniMenuPanel.Controls.Add(MiniNavBarInventoryBtn);
            MiniMenuPanel.Controls.Add(ShopIcon_PictureBox);
            MiniMenuPanel.Dock = DockStyle.Left;
            MiniMenuPanel.Location = new Point(175, 0);
            MiniMenuPanel.Name = "MiniMenuPanel";
            MiniMenuPanel.Size = new Size(62, 553);
            MiniMenuPanel.TabIndex = 6;
            // 
            // MiniNavLogOutBtn
            // 
            MiniNavLogOutBtn.FlatAppearance.BorderSize = 0;
            MiniNavLogOutBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            MiniNavLogOutBtn.FlatStyle = FlatStyle.Flat;
            MiniNavLogOutBtn.Image = (Image)resources.GetObject("MiniNavLogOutBtn.Image");
            MiniNavLogOutBtn.Location = new Point(0, 455);
            MiniNavLogOutBtn.Name = "MiniNavLogOutBtn";
            MiniNavLogOutBtn.Size = new Size(61, 44);
            MiniNavLogOutBtn.TabIndex = 10;
            MiniNavLogOutBtn.UseVisualStyleBackColor = true;
            MiniNavLogOutBtn.Click += MiniNavLogOutBtn_Click;
            // 
            // MenuBarBtn
            // 
            MenuBarBtn.FlatAppearance.BorderSize = 0;
            MenuBarBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            MenuBarBtn.FlatStyle = FlatStyle.Flat;
            MenuBarBtn.Image = (Image)resources.GetObject("MenuBarBtn.Image");
            MenuBarBtn.Location = new Point(0, 505);
            MenuBarBtn.Name = "MenuBarBtn";
            MenuBarBtn.Size = new Size(61, 44);
            MenuBarBtn.TabIndex = 9;
            MenuBarBtn.UseVisualStyleBackColor = true;
            MenuBarBtn.Click += MenuBarBtn_Click;
            // 
            // MiniNavBarAccountBtn
            // 
            MiniNavBarAccountBtn.FlatAppearance.BorderSize = 0;
            MiniNavBarAccountBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            MiniNavBarAccountBtn.FlatStyle = FlatStyle.Flat;
            MiniNavBarAccountBtn.Image = (Image)resources.GetObject("MiniNavBarAccountBtn.Image");
            MiniNavBarAccountBtn.Location = new Point(0, 261);
            MiniNavBarAccountBtn.Name = "MiniNavBarAccountBtn";
            MiniNavBarAccountBtn.Size = new Size(61, 44);
            MiniNavBarAccountBtn.TabIndex = 8;
            MiniNavBarAccountBtn.UseVisualStyleBackColor = true;
            MiniNavBarAccountBtn.Click += MiniNavBarAccountBtn_Click;
            // 
            // MiniNavBarRecordBtn
            // 
            MiniNavBarRecordBtn.FlatAppearance.BorderSize = 0;
            MiniNavBarRecordBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            MiniNavBarRecordBtn.FlatStyle = FlatStyle.Flat;
            MiniNavBarRecordBtn.Image = (Image)resources.GetObject("MiniNavBarRecordBtn.Image");
            MiniNavBarRecordBtn.Location = new Point(1, 203);
            MiniNavBarRecordBtn.Name = "MiniNavBarRecordBtn";
            MiniNavBarRecordBtn.Size = new Size(61, 44);
            MiniNavBarRecordBtn.TabIndex = 7;
            MiniNavBarRecordBtn.UseVisualStyleBackColor = true;
            MiniNavBarRecordBtn.Click += MiniNavBarRecordBtn_Click;
            // 
            // MiniNavBarOrderBtn
            // 
            MiniNavBarOrderBtn.FlatAppearance.BorderSize = 0;
            MiniNavBarOrderBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            MiniNavBarOrderBtn.FlatStyle = FlatStyle.Flat;
            MiniNavBarOrderBtn.Image = (Image)resources.GetObject("MiniNavBarOrderBtn.Image");
            MiniNavBarOrderBtn.Location = new Point(-1, 143);
            MiniNavBarOrderBtn.Name = "MiniNavBarOrderBtn";
            MiniNavBarOrderBtn.Size = new Size(61, 44);
            MiniNavBarOrderBtn.TabIndex = 6;
            MiniNavBarOrderBtn.UseVisualStyleBackColor = true;
            MiniNavBarOrderBtn.Click += MiniNavBarOrderBtn_Click;
            // 
            // MiniNavBarInventoryBtn
            // 
            MiniNavBarInventoryBtn.FlatAppearance.BorderSize = 0;
            MiniNavBarInventoryBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            MiniNavBarInventoryBtn.FlatStyle = FlatStyle.Flat;
            MiniNavBarInventoryBtn.Image = (Image)resources.GetObject("MiniNavBarInventoryBtn.Image");
            MiniNavBarInventoryBtn.Location = new Point(0, 87);
            MiniNavBarInventoryBtn.Name = "MiniNavBarInventoryBtn";
            MiniNavBarInventoryBtn.Size = new Size(61, 44);
            MiniNavBarInventoryBtn.TabIndex = 5;
            MiniNavBarInventoryBtn.UseVisualStyleBackColor = true;
            MiniNavBarInventoryBtn.Click += MiniNavBarInventoryBtn_Click;
            // 
            // ShopIcon_PictureBox
            // 
            ShopIcon_PictureBox.BackColor = Color.Sienna;
            ShopIcon_PictureBox.BackgroundImageLayout = ImageLayout.Center;
            ShopIcon_PictureBox.Image = (Image)resources.GetObject("ShopIcon_PictureBox.Image");
            ShopIcon_PictureBox.Location = new Point(0, 0);
            ShopIcon_PictureBox.Name = "ShopIcon_PictureBox";
            ShopIcon_PictureBox.Padding = new Padding(5, 0, 5, 11);
            ShopIcon_PictureBox.Size = new Size(62, 65);
            ShopIcon_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ShopIcon_PictureBox.TabIndex = 3;
            ShopIcon_PictureBox.TabStop = false;
            // 
            // GreetingLabel
            // 
            GreetingLabel.AllowDrop = true;
            GreetingLabel.AutoEllipsis = true;
            GreetingLabel.AutoSize = true;
            GreetingLabel.BackColor = Color.Transparent;
            GreetingLabel.Dock = DockStyle.Top;
            GreetingLabel.Font = new Font("Century", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GreetingLabel.ForeColor = SystemColors.ControlLightLight;
            GreetingLabel.Location = new Point(237, 0);
            GreetingLabel.Name = "GreetingLabel";
            GreetingLabel.Size = new Size(175, 40);
            GreetingLabel.TabIndex = 8;
            GreetingLabel.Text = "Welcome!";
            // 
            // UserRoleLabel
            // 
            UserRoleLabel.AutoSize = true;
            UserRoleLabel.BackColor = Color.Transparent;
            UserRoleLabel.Dock = DockStyle.Top;
            UserRoleLabel.Font = new Font("Century", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            UserRoleLabel.ForeColor = SystemColors.ControlLightLight;
            UserRoleLabel.Location = new Point(237, 40);
            UserRoleLabel.Name = "UserRoleLabel";
            UserRoleLabel.Size = new Size(171, 40);
            UserRoleLabel.TabIndex = 7;
            UserRoleLabel.Text = "UserRole";
            // 
            // Stocks_dataGridView
            // 
            dataGridViewCellStyle1.BackColor = Color.Transparent;
            Stocks_dataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            Stocks_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Stocks_dataGridView.Dock = DockStyle.Bottom;
            Stocks_dataGridView.Location = new Point(237, 328);
            Stocks_dataGridView.Name = "Stocks_dataGridView";
            Stocks_dataGridView.RowHeadersWidth = 51;
            Stocks_dataGridView.Size = new Size(645, 225);
            Stocks_dataGridView.TabIndex = 9;
            // 
            // Sales_dataGridView
            // 
            Sales_dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Sales_dataGridView.Dock = DockStyle.Bottom;
            Sales_dataGridView.Location = new Point(237, 101);
            Sales_dataGridView.Name = "Sales_dataGridView";
            Sales_dataGridView.RowHeadersWidth = 51;
            Sales_dataGridView.Size = new Size(645, 227);
            Sales_dataGridView.TabIndex = 10;
            // 
            // Admin_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.admin_dash;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Sales_dataGridView);
            Controls.Add(Stocks_dataGridView);
            Controls.Add(UserRoleLabel);
            Controls.Add(GreetingLabel);
            Controls.Add(MiniMenuPanel);
            Controls.Add(MenuPanel);
            Name = "Admin_page";
            Size = new Size(882, 553);
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShopMIcon).EndInit();
            MiniMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ShopIcon_PictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)Stocks_dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)Sales_dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button InventoryBtn;
        private Button RecordBtn;
        private Button OrderBtn;
        private Button LogOutBtn;
        private Panel MenuPanel;
        private Panel MiniMenuPanel;
        private Label MenuTitleLabel;
        private PictureBox ShopIcon_PictureBox;
        private Button AccountBtn;
        private PictureBox ShopMIcon;
        private Button MiniNavBarInventoryBtn;
        private Button NavBarBtn;
        private Button MiniNavLogOutBtn;
        private Button MenuBarBtn;
        private Button MiniNavBarAccountBtn;
        private Button MiniNavBarRecordBtn;
        private Button MiniNavBarOrderBtn;
        private Label GreetingLabel;
        private Label UserRoleLabel;
        private DataGridView Stocks_dataGridView;
        private DataGridView Sales_dataGridView;
    }
}
