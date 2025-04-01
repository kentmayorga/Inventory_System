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
            InventoryBtn = new Button();
            RecordBtn = new Button();
            OrderBtn = new Button();
            LogOutBtn = new Button();
            MenuPanel = new Panel();
            NavBarBtn = new Button();
            ShopMIcon = new PictureBox();
            AccountBtn = new Button();
            label1 = new Label();
            ProfileBtn = new Button();
            MiniMenuPanel = new Panel();
            MiniNavLogOutBtn = new Button();
            MenuBarBtn = new Button();
            MiniNavBarAccountBtn = new Button();
            MiniNavBarRecordBtn = new Button();
            MiniNavBarOrderBtn = new Button();
            MiniNavBarInventoryBtn = new Button();
            MiniNavBarProfileBtn = new Button();
            ShopIcon_PictureBox = new PictureBox();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShopMIcon).BeginInit();
            MiniMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ShopIcon_PictureBox).BeginInit();
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
            InventoryBtn.Location = new Point(1, 125);
            InventoryBtn.Margin = new Padding(0);
            InventoryBtn.Name = "InventoryBtn";
            InventoryBtn.Size = new Size(173, 75);
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
            RecordBtn.Location = new Point(0, 271);
            RecordBtn.Name = "RecordBtn";
            RecordBtn.Size = new Size(174, 75);
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
            OrderBtn.Location = new Point(1, 200);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(173, 75);
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
            LogOutBtn.Location = new Point(0, 446);
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
            MenuPanel.Controls.Add(label1);
            MenuPanel.Controls.Add(ProfileBtn);
            MenuPanel.Controls.Add(InventoryBtn);
            MenuPanel.Controls.Add(RecordBtn);
            MenuPanel.Controls.Add(LogOutBtn);
            MenuPanel.Controls.Add(OrderBtn);
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
            ShopMIcon.Size = new Size(44, 42);
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
            AccountBtn.Location = new Point(0, 344);
            AccountBtn.Name = "AccountBtn";
            AccountBtn.Size = new Size(174, 75);
            AccountBtn.TabIndex = 6;
            AccountBtn.Text = "ACCOUNTS";
            AccountBtn.TextAlign = ContentAlignment.MiddleRight;
            AccountBtn.UseVisualStyleBackColor = false;
            AccountBtn.Click += AccountBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(56, 11);
            label1.Name = "label1";
            label1.Size = new Size(111, 33);
            label1.TabIndex = 5;
            label1.Text = "MENU";
            // 
            // ProfileBtn
            // 
            ProfileBtn.BackColor = Color.Transparent;
            ProfileBtn.FlatAppearance.BorderSize = 0;
            ProfileBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            ProfileBtn.FlatStyle = FlatStyle.Flat;
            ProfileBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileBtn.ForeColor = SystemColors.Window;
            ProfileBtn.Image = (Image)resources.GetObject("ProfileBtn.Image");
            ProfileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ProfileBtn.Location = new Point(0, 52);
            ProfileBtn.Margin = new Padding(3, 4, 3, 4);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(174, 75);
            ProfileBtn.TabIndex = 4;
            ProfileBtn.Text = "PROFILE";
            ProfileBtn.UseVisualStyleBackColor = false;
            ProfileBtn.Click += ProfileBtn_Click;
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
            MiniMenuPanel.Controls.Add(MiniNavBarProfileBtn);
            MiniMenuPanel.Controls.Add(ShopIcon_PictureBox);
            MiniMenuPanel.Location = new Point(0, 1);
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
            MiniNavBarAccountBtn.Location = new Point(0, 310);
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
            MiniNavBarRecordBtn.Location = new Point(1, 260);
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
            MiniNavBarOrderBtn.Location = new Point(-1, 203);
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
            MiniNavBarInventoryBtn.Location = new Point(0, 142);
            MiniNavBarInventoryBtn.Name = "MiniNavBarInventoryBtn";
            MiniNavBarInventoryBtn.Size = new Size(61, 44);
            MiniNavBarInventoryBtn.TabIndex = 5;
            MiniNavBarInventoryBtn.UseVisualStyleBackColor = true;
            MiniNavBarInventoryBtn.Click += MiniNavBarInventoryBtn_Click;
            // 
            // MiniNavBarProfileBtn
            // 
            MiniNavBarProfileBtn.FlatAppearance.BorderSize = 0;
            MiniNavBarProfileBtn.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            MiniNavBarProfileBtn.FlatStyle = FlatStyle.Flat;
            MiniNavBarProfileBtn.Image = (Image)resources.GetObject("MiniNavBarProfileBtn.Image");
            MiniNavBarProfileBtn.Location = new Point(1, 82);
            MiniNavBarProfileBtn.Name = "MiniNavBarProfileBtn";
            MiniNavBarProfileBtn.Size = new Size(58, 44);
            MiniNavBarProfileBtn.TabIndex = 4;
            MiniNavBarProfileBtn.UseVisualStyleBackColor = true;
            MiniNavBarProfileBtn.Click += MiniNavBarProfileBtn_Click;
            // 
            // ShopIcon_PictureBox
            // 
            ShopIcon_PictureBox.BackColor = Color.Sienna;
            ShopIcon_PictureBox.BackgroundImageLayout = ImageLayout.Center;
            ShopIcon_PictureBox.Image = (Image)resources.GetObject("ShopIcon_PictureBox.Image");
            ShopIcon_PictureBox.Location = new Point(0, 0);
            ShopIcon_PictureBox.Name = "ShopIcon_PictureBox";
            ShopIcon_PictureBox.Padding = new Padding(5, 0, 5, 10);
            ShopIcon_PictureBox.Size = new Size(62, 65);
            ShopIcon_PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            ShopIcon_PictureBox.TabIndex = 3;
            ShopIcon_PictureBox.TabStop = false;
            // 
            // Admin_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.admin_dash;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(MiniMenuPanel);
            Controls.Add(MenuPanel);
            Name = "Admin_page";
            Size = new Size(882, 553);
            Load += Admin_page_Load;
            MenuPanel.ResumeLayout(false);
            MenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ShopMIcon).EndInit();
            MiniMenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ShopIcon_PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button InventoryBtn;
        private Button RecordBtn;
        private Button OrderBtn;
        private Button LogOutBtn;
        private Panel MenuPanel;
        private Button ProfileBtn;
        private Panel MiniMenuPanel;
        private Label label1;
        private PictureBox ShopIcon_PictureBox;
        private Button AccountBtn;
        private PictureBox ShopMIcon;
        private Button MiniNavBarInventoryBtn;
        private Button MiniNavBarProfileBtn;
        private Button NavBarBtn;
        private Button MiniNavLogOutBtn;
        private Button MenuBarBtn;
        private Button MiniNavBarAccountBtn;
        private Button MiniNavBarRecordBtn;
        private Button MiniNavBarOrderBtn;
    }
}
