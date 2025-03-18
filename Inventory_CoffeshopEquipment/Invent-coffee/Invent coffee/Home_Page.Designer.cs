namespace Invent_coffee
{
    partial class Home_Page
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
            Navigations = new Panel();
            AccountLinkLabel = new LinkLabel();
            LocationLabel = new Label();
            SubscriptionLabel = new Label();
            BestSellerLabel = new Label();
            ShopLabel = new Label();
            Navigations.SuspendLayout();
            SuspendLayout();
            // 
            // Navigations
            // 
            Navigations.BackColor = Color.FromArgb(111, 78, 55);
            Navigations.Controls.Add(AccountLinkLabel);
            Navigations.Controls.Add(LocationLabel);
            Navigations.Controls.Add(SubscriptionLabel);
            Navigations.Controls.Add(BestSellerLabel);
            Navigations.Controls.Add(ShopLabel);
            Navigations.Dock = DockStyle.Top;
            Navigations.ImeMode = ImeMode.Disable;
            Navigations.Location = new Point(0, 0);
            Navigations.Name = "Navigations";
            Navigations.Size = new Size(788, 49);
            Navigations.TabIndex = 0;
            // 
            // AccountLinkLabel
            // 
            AccountLinkLabel.ActiveLinkColor = Color.White;
            AccountLinkLabel.AutoSize = true;
            AccountLinkLabel.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AccountLinkLabel.LinkColor = Color.White;
            AccountLinkLabel.Location = new Point(679, 17);
            AccountLinkLabel.Name = "AccountLinkLabel";
            AccountLinkLabel.Size = new Size(86, 16);
            AccountLinkLabel.TabIndex = 4;
            AccountLinkLabel.TabStop = true;
            AccountLinkLabel.Text = "My Account";
            // 
            // LocationLabel
            // 
            LocationLabel.AutoSize = true;
            LocationLabel.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LocationLabel.ForeColor = Color.White;
            LocationLabel.Location = new Point(572, 14);
            LocationLabel.Name = "LocationLabel";
            LocationLabel.Size = new Size(101, 19);
            LocationLabel.TabIndex = 3;
            LocationLabel.Text = "LOCATION";
            // 
            // SubscriptionLabel
            // 
            SubscriptionLabel.AutoSize = true;
            SubscriptionLabel.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SubscriptionLabel.ForeColor = Color.White;
            SubscriptionLabel.Location = new Point(207, 14);
            SubscriptionLabel.Name = "SubscriptionLabel";
            SubscriptionLabel.Size = new Size(138, 19);
            SubscriptionLabel.TabIndex = 2;
            SubscriptionLabel.Text = "SUBSCRIPTION";
            // 
            // BestSellerLabel
            // 
            BestSellerLabel.AutoSize = true;
            BestSellerLabel.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BestSellerLabel.ForeColor = Color.White;
            BestSellerLabel.Location = new Point(78, 14);
            BestSellerLabel.Name = "BestSellerLabel";
            BestSellerLabel.Size = new Size(123, 19);
            BestSellerLabel.TabIndex = 1;
            BestSellerLabel.Text = "BEST SELLER";
            // 
            // ShopLabel
            // 
            ShopLabel.AutoSize = true;
            ShopLabel.Cursor = Cursors.Hand;
            ShopLabel.Font = new Font("Imprint MT Shadow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ShopLabel.ForeColor = Color.White;
            ShopLabel.Location = new Point(15, 14);
            ShopLabel.Name = "ShopLabel";
            ShopLabel.Size = new Size(57, 19);
            ShopLabel.TabIndex = 0;
            ShopLabel.Text = "SHOP";
            // 
            // Home_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Navigations);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home_Page";
            Size = new Size(788, 450);
            Navigations.ResumeLayout(false);
            Navigations.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel Navigations;
        private Label ShopLabel;
        private Label LocationLabel;
        private Label SubscriptionLabel;
        private Label BestSellerLabel;
        private LinkLabel AccountLinkLabel;
    }
}
