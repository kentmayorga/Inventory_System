namespace Invent_coffee
{
    partial class Inventory_page
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
            Inventory_DataGridView = new DataGridView();
            AddProductBtn = new Button();
            BackBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)Inventory_DataGridView).BeginInit();
            SuspendLayout();
            // 
            // Inventory_DataGridView
            // 
            Inventory_DataGridView.Anchor = AnchorStyles.Bottom;
            Inventory_DataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Inventory_DataGridView.Location = new Point(0, 216);
            Inventory_DataGridView.Name = "Inventory_DataGridView";
            Inventory_DataGridView.RowHeadersWidth = 51;
            Inventory_DataGridView.Size = new Size(882, 337);
            Inventory_DataGridView.TabIndex = 0;
            Inventory_DataGridView.CellContentClick += Inventory_DataGridView_CellContentClick;
            // 
            // AddProductBtn
            // 
            AddProductBtn.Location = new Point(44, 99);
            AddProductBtn.Name = "AddProductBtn";
            AddProductBtn.Size = new Size(94, 29);
            AddProductBtn.TabIndex = 1;
            AddProductBtn.Text = "ADD";
            AddProductBtn.UseVisualStyleBackColor = true;
            AddProductBtn.Click += AddProductBtn_Click;
            // 
            // BackBtn
            // 
            BackBtn.Location = new Point(455, 114);
            BackBtn.Name = "BackBtn";
            BackBtn.Size = new Size(94, 29);
            BackBtn.TabIndex = 2;
            BackBtn.Text = "BACK";
            BackBtn.UseVisualStyleBackColor = true;
            BackBtn.Click += BackBtn_Click;
            // 
            // Inventory_page
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BackBtn);
            Controls.Add(AddProductBtn);
            Controls.Add(Inventory_DataGridView);
            Name = "Inventory_page";
            Size = new Size(882, 553);
            ((System.ComponentModel.ISupportInitialize)Inventory_DataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView Inventory_DataGridView;
        private Button AddProductBtn;
        private Button BackBtn;
    }
}
