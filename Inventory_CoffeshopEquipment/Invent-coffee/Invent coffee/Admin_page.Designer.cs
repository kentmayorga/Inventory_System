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
            SuspendLayout();
            // 
            // InventoryBtn
            // 
            InventoryBtn.Location = new Point(356, 160);
            InventoryBtn.Name = "InventoryBtn";
            InventoryBtn.Size = new Size(127, 29);
            InventoryBtn.TabIndex = 0;
            InventoryBtn.Text = "INVENTORY";
            InventoryBtn.UseVisualStyleBackColor = true;
            InventoryBtn.Click += InventoryBtn_Click;
            // 
            // RecordBtn
            // 
            RecordBtn.Location = new Point(356, 284);
            RecordBtn.Name = "RecordBtn";
            RecordBtn.Size = new Size(127, 29);
            RecordBtn.TabIndex = 1;
            RecordBtn.Text = "RECORDS";
            RecordBtn.UseVisualStyleBackColor = true;
            // 
            // OrderBtn
            // 
            OrderBtn.Location = new Point(356, 223);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.Size = new Size(127, 29);
            OrderBtn.TabIndex = 2;
            OrderBtn.Text = "ORDERS";
            OrderBtn.UseVisualStyleBackColor = true;
            // 
            // Admin_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrderBtn);
            Controls.Add(RecordBtn);
            Controls.Add(InventoryBtn);
            Name = "Admin_page";
            Size = new Size(882, 553);
            ResumeLayout(false);
        }

        #endregion

        private Button InventoryBtn;
        private Button RecordBtn;
        private Button OrderBtn;
    }
}
