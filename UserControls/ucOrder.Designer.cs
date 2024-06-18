namespace shoppingApp.UserControls
{
    partial class ucOrder
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAddress = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPayment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbProdPrice = new System.Windows.Forms.Label();
            this.lbProdName = new System.Windows.Forms.Label();
            this.btnInfo = new Guna.UI2.WinForms.Guna2CircleButton();
            this.pcProdImage = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lbDate);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lbAddress);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lbPayment);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lbTotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(-1, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(418, 148);
            this.panel2.TabIndex = 4;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.ForeColor = System.Drawing.Color.Black;
            this.lbAddress.Location = new System.Drawing.Point(91, 18);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(66, 21);
            this.lbAddress.TabIndex = 10;
            this.lbAddress.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Address: ";
            // 
            // lbPayment
            // 
            this.lbPayment.AutoSize = true;
            this.lbPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPayment.ForeColor = System.Drawing.Color.Black;
            this.lbPayment.Location = new System.Drawing.Point(147, 46);
            this.lbPayment.Name = "lbPayment";
            this.lbPayment.Size = new System.Drawing.Size(128, 21);
            this.lbPayment.TabIndex = 9;
            this.lbPayment.Text = "Payment method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "Payment method: ";
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.ForeColor = System.Drawing.Color.Firebrick;
            this.lbTotal.Location = new System.Drawing.Point(64, 75);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(42, 21);
            this.lbTotal.TabIndex = 8;
            this.lbTotal.Text = "Total";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 7;
            this.label3.Text = "Total:  ";
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.Black;
            this.lbQuantity.Location = new System.Drawing.Point(613, 53);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(56, 17);
            this.lbQuantity.TabIndex = 12;
            this.lbQuantity.Text = "Quantity";
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Black;
            this.lbSize.Location = new System.Drawing.Point(560, 53);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(31, 17);
            this.lbSize.TabIndex = 11;
            this.lbSize.Text = "Size";
            // 
            // lbProdPrice
            // 
            this.lbProdPrice.AutoSize = true;
            this.lbProdPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.lbProdPrice.Location = new System.Drawing.Point(559, 85);
            this.lbProdPrice.Name = "lbProdPrice";
            this.lbProdPrice.Size = new System.Drawing.Size(102, 21);
            this.lbProdPrice.TabIndex = 10;
            this.lbProdPrice.Text = "Product Price";
            // 
            // lbProdName
            // 
            this.lbProdName.AutoSize = true;
            this.lbProdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdName.ForeColor = System.Drawing.Color.Black;
            this.lbProdName.Location = new System.Drawing.Point(559, 18);
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(110, 21);
            this.lbProdName.TabIndex = 9;
            this.lbProdName.Text = "Product Name";
            // 
            // btnInfo
            // 
            this.btnInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInfo.FillColor = System.Drawing.Color.Transparent;
            this.btnInfo.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInfo.ForeColor = System.Drawing.Color.White;
            this.btnInfo.Image = global::shoppingApp.Properties.Resources.menu_vertical_30px;
            this.btnInfo.ImageSize = new System.Drawing.Size(30, 30);
            this.btnInfo.Location = new System.Drawing.Point(763, 48);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnInfo.Size = new System.Drawing.Size(40, 40);
            this.btnInfo.TabIndex = 13;
            // 
            // pcProdImage
            // 
            this.pcProdImage.Location = new System.Drawing.Point(423, 10);
            this.pcProdImage.Name = "pcProdImage";
            this.pcProdImage.Size = new System.Drawing.Size(120, 115);
            this.pcProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcProdImage.TabIndex = 8;
            this.pcProdImage.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(17, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 21);
            this.label4.TabIndex = 11;
            this.label4.Text = "Date:  ";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.Black;
            this.lbDate.Location = new System.Drawing.Point(64, 104);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(42, 21);
            this.lbDate.TabIndex = 12;
            this.lbDate.Text = "Date";
            // 
            // ucOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.lbQuantity);
            this.Controls.Add(this.lbSize);
            this.Controls.Add(this.lbProdPrice);
            this.Controls.Add(this.lbProdName);
            this.Controls.Add(this.pcProdImage);
            this.Controls.Add(this.panel2);
            this.Name = "ucOrder";
            this.Size = new System.Drawing.Size(813, 136);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label lbPayment;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label lbSize;
        private System.Windows.Forms.Label lbProdPrice;
        private System.Windows.Forms.Label lbProdName;
        private System.Windows.Forms.PictureBox pcProdImage;
        private Guna.UI2.WinForms.Guna2CircleButton btnInfo;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label4;
    }
}
