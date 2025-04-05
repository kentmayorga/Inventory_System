namespace Invent_coffee
{
    partial class Checkout_Page
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
            Cart = new Button();
            CheckoutButton = new Button();
            LogOutButton = new Button();
            dataGridViewcheckout = new DataGridView();
            checkoutlabel = new Label();
            LABELCHECKOUT = new Label();
            Totallabel = new Label();
            labelTotal = new Label();
            CheckoutSuccess = new Label();
            PreviewItems = new Label();
            Navigations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewcheckout).BeginInit();
            SuspendLayout();
            // 
            // Navigations
            // 
            Navigations.BackColor = Color.FromArgb(111, 78, 55);
            Navigations.Controls.Add(Cart);
            Navigations.Controls.Add(CheckoutButton);
            Navigations.Controls.Add(LogOutButton);
            Navigations.Dock = DockStyle.Top;
            Navigations.ImeMode = ImeMode.Disable;
            Navigations.Location = new Point(0, 0);
            Navigations.Name = "Navigations";
            Navigations.Size = new Size(772, 46);
            Navigations.TabIndex = 2;
            // 
            // Cart
            // 
            Cart.Location = new Point(609, 8);
            Cart.Name = "Cart";
            Cart.Size = new Size(75, 27);
            Cart.TabIndex = 9;
            Cart.Text = "Cart";
            Cart.UseVisualStyleBackColor = true;
            Cart.Click += Cart_Click;
            // 
            // CheckoutButton
            // 
            CheckoutButton.AllowDrop = true;
            CheckoutButton.BackColor = Color.White;
            CheckoutButton.FlatAppearance.BorderSize = 0;
            CheckoutButton.FlatAppearance.MouseOverBackColor = Color.White;
            CheckoutButton.FlatStyle = FlatStyle.Flat;
            CheckoutButton.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CheckoutButton.ForeColor = Color.FromArgb(128, 64, 0);
            CheckoutButton.Location = new Point(14, 8);
            CheckoutButton.Name = "CheckoutButton";
            CheckoutButton.Size = new Size(107, 24);
            CheckoutButton.TabIndex = 6;
            CheckoutButton.Text = "CHECKOUT";
            CheckoutButton.UseVisualStyleBackColor = false;
            // 
            // LogOutButton
            // 
            LogOutButton.Font = new Font("Times New Roman", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LogOutButton.Location = new Point(690, 7);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(59, 28);
            LogOutButton.TabIndex = 5;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = true;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // dataGridViewcheckout
            // 
            dataGridViewcheckout.BackgroundColor = SystemColors.Control;
            dataGridViewcheckout.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewcheckout.Location = new Point(14, 89);
            dataGridViewcheckout.Name = "dataGridViewcheckout";
            dataGridViewcheckout.Size = new Size(424, 280);
            dataGridViewcheckout.TabIndex = 3;
            // 
            // checkoutlabel
            // 
            checkoutlabel.AutoSize = true;
            checkoutlabel.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkoutlabel.Location = new Point(457, 134);
            checkoutlabel.Name = "checkoutlabel";
            checkoutlabel.Size = new Size(53, 19);
            checkoutlabel.TabIndex = 4;
            checkoutlabel.Text = "Item/s: ";
            // 
            // LABELCHECKOUT
            // 
            LABELCHECKOUT.AutoSize = true;
            LABELCHECKOUT.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LABELCHECKOUT.Location = new Point(457, 98);
            LABELCHECKOUT.Name = "LABELCHECKOUT";
            LABELCHECKOUT.Size = new Size(112, 21);
            LABELCHECKOUT.TabIndex = 5;
            LABELCHECKOUT.Text = "List of items: ";
            // 
            // Totallabel
            // 
            Totallabel.AutoSize = true;
            Totallabel.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Totallabel.Location = new Point(457, 210);
            Totallabel.Name = "Totallabel";
            Totallabel.Size = new Size(57, 21);
            Totallabel.TabIndex = 6;
            Totallabel.Text = "Total: ";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelTotal.Location = new Point(461, 240);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(45, 19);
            labelTotal.TabIndex = 7;
            labelTotal.Text = "label2";
            // 
            // CheckoutSuccess
            // 
            CheckoutSuccess.AutoSize = true;
            CheckoutSuccess.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CheckoutSuccess.ForeColor = Color.ForestGreen;
            CheckoutSuccess.Location = new Point(477, 335);
            CheckoutSuccess.Name = "CheckoutSuccess";
            CheckoutSuccess.Padding = new Padding(5);
            CheckoutSuccess.Size = new Size(251, 34);
            CheckoutSuccess.TabIndex = 8;
            CheckoutSuccess.Text = "Successfuly Checked Out!";
            // 
            // PreviewItems
            // 
            PreviewItems.AutoSize = true;
            PreviewItems.BackColor = SystemColors.Control;
            PreviewItems.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PreviewItems.Location = new Point(14, 62);
            PreviewItems.Name = "PreviewItems";
            PreviewItems.Size = new Size(83, 24);
            PreviewItems.TabIndex = 9;
            PreviewItems.Text = "Preview";
            // 
            // Checkout_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PreviewItems);
            Controls.Add(CheckoutSuccess);
            Controls.Add(labelTotal);
            Controls.Add(Totallabel);
            Controls.Add(LABELCHECKOUT);
            Controls.Add(checkoutlabel);
            Controls.Add(dataGridViewcheckout);
            Controls.Add(Navigations);
            Name = "Checkout_Page";
            Size = new Size(772, 415);
            Navigations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewcheckout).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Navigations;
        private Button Cart;
        private Button CheckoutButton;
        private Button LogOutButton;
        private DataGridView dataGridViewcheckout;
        private Label checkoutlabel;
        private Label LABELCHECKOUT;
        private Label Totallabel;
        private Label labelTotal;
        private Label CheckoutSuccess;
        private Label PreviewItems;
    }
}
