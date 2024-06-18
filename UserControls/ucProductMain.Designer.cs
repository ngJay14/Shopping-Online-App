namespace shoppingApp.UserControls
{
    partial class ucProductMain
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
            this.lbProdName = new System.Windows.Forms.Label();
            this.lbPrice = new System.Windows.Forms.Label();
            this.pcProdImage = new System.Windows.Forms.PictureBox();
            this.lbDeal = new System.Windows.Forms.Label();
            this.lbDisPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProdName
            // 
            this.lbProdName.AutoSize = true;
            this.lbProdName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdName.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbProdName.Location = new System.Drawing.Point(4, 227);
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(89, 17);
            this.lbProdName.TabIndex = 1;
            this.lbProdName.Text = "Product name";
            // 
            // lbPrice
            // 
            this.lbPrice.AutoSize = true;
            this.lbPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrice.ForeColor = System.Drawing.Color.Black;
            this.lbPrice.Location = new System.Drawing.Point(4, 253);
            this.lbPrice.Name = "lbPrice";
            this.lbPrice.Size = new System.Drawing.Size(36, 17);
            this.lbPrice.TabIndex = 2;
            this.lbPrice.Text = "Price";
            // 
            // pcProdImage
            // 
            this.pcProdImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcProdImage.Location = new System.Drawing.Point(0, 0);
            this.pcProdImage.Name = "pcProdImage";
            this.pcProdImage.Size = new System.Drawing.Size(198, 220);
            this.pcProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcProdImage.TabIndex = 0;
            this.pcProdImage.TabStop = false;
            // 
            // lbDeal
            // 
            this.lbDeal.AutoSize = true;
            this.lbDeal.Font = new System.Drawing.Font("Segoe UI", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDeal.ForeColor = System.Drawing.Color.Firebrick;
            this.lbDeal.Location = new System.Drawing.Point(137, 10);
            this.lbDeal.Name = "lbDeal";
            this.lbDeal.Size = new System.Drawing.Size(53, 25);
            this.lbDeal.TabIndex = 3;
            this.lbDeal.Text = "Deal";
            this.lbDeal.Visible = false;
            // 
            // lbDisPrice
            // 
            this.lbDisPrice.AutoSize = true;
            this.lbDisPrice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisPrice.ForeColor = System.Drawing.Color.DimGray;
            this.lbDisPrice.Location = new System.Drawing.Point(117, 253);
            this.lbDisPrice.Name = "lbDisPrice";
            this.lbDisPrice.Size = new System.Drawing.Size(54, 17);
            this.lbDisPrice.TabIndex = 4;
            this.lbDisPrice.Text = "DisPrice";
            this.lbDisPrice.Visible = false;
            // 
            // ucProductMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbDisPrice);
            this.Controls.Add(this.lbDeal);
            this.Controls.Add(this.lbPrice);
            this.Controls.Add(this.lbProdName);
            this.Controls.Add(this.pcProdImage);
            this.Name = "ucProductMain";
            this.Size = new System.Drawing.Size(198, 298);
            ((System.ComponentModel.ISupportInitialize)(this.pcProdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcProdImage;
        private System.Windows.Forms.Label lbProdName;
        private System.Windows.Forms.Label lbPrice;
        private System.Windows.Forms.Label lbDeal;
        private System.Windows.Forms.Label lbDisPrice;
    }
}
