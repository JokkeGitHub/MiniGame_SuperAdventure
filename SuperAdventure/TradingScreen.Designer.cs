namespace SuperAdventure
{
    partial class TradingScreen
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMyInventory = new System.Windows.Forms.Label();
            this.lblVendorInventory = new System.Windows.Forms.Label();
            this.dgvVendorItems = new System.Windows.Forms.DataGridView();
            this.dgvMyItems = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.imgBoxVendor = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMyInventory
            // 
            this.lblMyInventory.AutoSize = true;
            this.lblMyInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyInventory.Location = new System.Drawing.Point(260, 20);
            this.lblMyInventory.Name = "lblMyInventory";
            this.lblMyInventory.Size = new System.Drawing.Size(111, 22);
            this.lblMyInventory.TabIndex = 0;
            this.lblMyInventory.Text = "My Inventory";
            // 
            // lblVendorInventory
            // 
            this.lblVendorInventory.AutoSize = true;
            this.lblVendorInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVendorInventory.Location = new System.Drawing.Point(736, 20);
            this.lblVendorInventory.Name = "lblVendorInventory";
            this.lblVendorInventory.Size = new System.Drawing.Size(146, 22);
            this.lblVendorInventory.TabIndex = 1;
            this.lblVendorInventory.Text = "Vendor Inventory";
            // 
            // dgvVendorItems
            // 
            this.dgvVendorItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendorItems.Location = new System.Drawing.Point(740, 54);
            this.dgvVendorItems.Name = "dgvVendorItems";
            this.dgvVendorItems.RowHeadersWidth = 51;
            this.dgvVendorItems.RowTemplate.Height = 24;
            this.dgvVendorItems.Size = new System.Drawing.Size(321, 398);
            this.dgvVendorItems.TabIndex = 2;
            // 
            // dgvMyItems
            // 
            this.dgvMyItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMyItems.Location = new System.Drawing.Point(12, 54);
            this.dgvMyItems.Name = "dgvMyItems";
            this.dgvMyItems.RowHeadersWidth = 51;
            this.dgvMyItems.RowTemplate.Height = 24;
            this.dgvMyItems.Size = new System.Drawing.Size(359, 398);
            this.dgvMyItems.TabIndex = 3;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(499, 468);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 41);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // imgBoxVendor
            // 
            this.imgBoxVendor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imgBoxVendor.Location = new System.Drawing.Point(377, 54);
            this.imgBoxVendor.Name = "imgBoxVendor";
            this.imgBoxVendor.Size = new System.Drawing.Size(357, 398);
            this.imgBoxVendor.TabIndex = 5;
            this.imgBoxVendor.TabStop = false;
            // 
            // TradingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 519);
            this.Controls.Add(this.imgBoxVendor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.dgvMyItems);
            this.Controls.Add(this.dgvVendorItems);
            this.Controls.Add(this.lblVendorInventory);
            this.Controls.Add(this.lblMyInventory);
            this.Name = "TradingScreen";
            this.Text = "Trade";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendorItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMyItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgBoxVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMyInventory;
        private System.Windows.Forms.Label lblVendorInventory;
        private System.Windows.Forms.DataGridView dgvVendorItems;
        private System.Windows.Forms.DataGridView dgvMyItems;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox imgBoxVendor;
    }
}