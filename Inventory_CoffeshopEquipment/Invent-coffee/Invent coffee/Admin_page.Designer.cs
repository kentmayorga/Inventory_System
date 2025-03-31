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
            InventoryBtn = new Button();
            RecordBtn = new Button();
            OrderBtn = new Button();
            LogOutBtn = new Button();
            MenuPanel = new Panel();
            ProfileBtn = new Button();
            MenuBtn = new Button();
            HomeBtn = new Button();
            MenuPanel.SuspendLayout();
            SuspendLayout();
            // 
            // InventoryBtn
            // 
            InventoryBtn.BackColor = Color.Transparent;
            InventoryBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            InventoryBtn.FlatStyle = FlatStyle.Flat;
            InventoryBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            InventoryBtn.ForeColor = SystemColors.ButtonHighlight;
            InventoryBtn.Image = Properties.Resources.icons8_trolley_32;
            InventoryBtn.ImageAlign = ContentAlignment.MiddleLeft;
            InventoryBtn.Location = new Point(0, 123);
            InventoryBtn.Margin = new Padding(0);
            InventoryBtn.Name = "InventoryBtn";
            InventoryBtn.Size = new Size(220, 69);
            InventoryBtn.TabIndex = 0;
            InventoryBtn.Text = "INVENTORY";
            InventoryBtn.UseVisualStyleBackColor = false;
            InventoryBtn.Click += InventoryBtn_Click;
            // 
            // RecordBtn
            // 
            RecordBtn.BackColor = Color.Transparent;
            RecordBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            RecordBtn.FlatStyle = FlatStyle.Flat;
            RecordBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RecordBtn.ForeColor = SystemColors.ButtonHighlight;
            RecordBtn.Image = Properties.Resources.icons8_list_view_26;
            RecordBtn.ImageAlign = ContentAlignment.MiddleLeft;
            RecordBtn.Location = new Point(0, 254);
            RecordBtn.Margin = new Padding(3, 2, 3, 2);
            RecordBtn.Name = "RecordBtn";
            RecordBtn.Size = new Size(210, 62);
            RecordBtn.TabIndex = 1;
            RecordBtn.Text = "RECORDS";
            RecordBtn.UseVisualStyleBackColor = false;
            RecordBtn.Click += RecordBtn_Click;
            // 
            // OrderBtn
            // 
            OrderBtn.BackColor = Color.Transparent;
            OrderBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            OrderBtn.FlatStyle = FlatStyle.Flat;
            OrderBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            OrderBtn.ForeColor = SystemColors.ControlLightLight;
            OrderBtn.Image = Properties.Resources.icons8_product_26;
            OrderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            OrderBtn.Location = new Point(0, 183);
            OrderBtn.Margin = new Padding(3, 2, 3, 2);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(217, 79);
            OrderBtn.TabIndex = 2;
            OrderBtn.Text = "ORDERS";
            OrderBtn.UseVisualStyleBackColor = false;
            OrderBtn.Click += OrderBtn_Click;
            // 
            // LogOutBtn
            // 
            LogOutBtn.BackColor = Color.Transparent;
            LogOutBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            LogOutBtn.FlatStyle = FlatStyle.Flat;
            LogOutBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutBtn.ForeColor = SystemColors.ButtonHighlight;
            LogOutBtn.Image = Properties.Resources.icons8_logout_rounded_26;
            LogOutBtn.ImageAlign = ContentAlignment.MiddleLeft;
            LogOutBtn.Location = new Point(0, 307);
            LogOutBtn.Margin = new Padding(0);
            LogOutBtn.Name = "LogOutBtn";
            LogOutBtn.Size = new Size(210, 64);
            LogOutBtn.TabIndex = 3;
            LogOutBtn.Text = "LOG OUT";
            LogOutBtn.UseVisualStyleBackColor = false;
            LogOutBtn.Click += LogOutBtn_Click;
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.Sienna;
            MenuPanel.Controls.Add(MenuBtn);
            MenuPanel.Controls.Add(ProfileBtn);
            MenuPanel.Controls.Add(InventoryBtn);
            MenuPanel.Controls.Add(RecordBtn);
            MenuPanel.Controls.Add(LogOutBtn);
            MenuPanel.Controls.Add(OrderBtn);
            MenuPanel.Location = new Point(0, 0);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(210, 415);
            MenuPanel.TabIndex = 4;
            // 
            // ProfileBtn
            // 
            ProfileBtn.BackColor = Color.Transparent;
            ProfileBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            ProfileBtn.FlatStyle = FlatStyle.Flat;
            ProfileBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ProfileBtn.ForeColor = SystemColors.ButtonHighlight;
            ProfileBtn.Image = Properties.Resources.icons8_male_user_26;
            ProfileBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ProfileBtn.Location = new Point(0, 66);
            ProfileBtn.Name = "ProfileBtn";
            ProfileBtn.Size = new Size(210, 63);
            ProfileBtn.TabIndex = 4;
            ProfileBtn.Text = "PROFILE";
            ProfileBtn.UseVisualStyleBackColor = false;
            // 
            // MenuBtn
            // 
            MenuBtn.BackColor = Color.Transparent;
            MenuBtn.FlatAppearance.BorderColor = Color.FromArgb(128, 64, 0);
            MenuBtn.FlatAppearance.BorderSize = 0;
            MenuBtn.FlatStyle = FlatStyle.Flat;
            MenuBtn.Font = new Font("Century", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MenuBtn.ForeColor = SystemColors.ButtonHighlight;
            MenuBtn.Image = Properties.Resources.icons8_menu_16;
            MenuBtn.ImageAlign = ContentAlignment.MiddleLeft;
            MenuBtn.Location = new Point(0, 0);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(210, 60);
            MenuBtn.TabIndex = 5;
            MenuBtn.Text = "MENU";
            MenuBtn.UseVisualStyleBackColor = false;
            // 
            // HomeBtn
            // 
            HomeBtn.BackColor = Color.Sienna;
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.Image = Properties.Resources.icons8_home_30;
            HomeBtn.Location = new Point(717, 7);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(43, 43);
            HomeBtn.TabIndex = 5;
            HomeBtn.UseVisualStyleBackColor = false;
            // 
            // Admin_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            BackgroundImage = Properties.Resources.admin_dash;
            Controls.Add(HomeBtn);
            Controls.Add(MenuPanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin_page";
            Size = new Size(772, 415);
            Load += Admin_page_Load;
            MenuPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button InventoryBtn;
        private Button RecordBtn;
        private Button OrderBtn;
        private Button LogOutBtn;
        private Panel MenuPanel;
        private Button ProfileBtn;
        private Button MenuBtn;
        private Button HomeBtn;
    }
}
