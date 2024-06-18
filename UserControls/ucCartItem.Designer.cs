namespace shoppingApp.UserControls
{
    partial class ucCartItem
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbAmountPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbQuantity = new System.Windows.Forms.Label();
            this.btnPlus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnMinus = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbSize = new System.Windows.Forms.Label();
            this.lbProdPrice = new System.Windows.Forms.Label();
            this.lbProdName = new System.Windows.Forms.Label();
            this.pcProdImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 138);
            this.panel1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.lbAmountPrice);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(573, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(176, 140);
            this.panel4.TabIndex = 9;
            // 
            // lbAmountPrice
            // 
            this.lbAmountPrice.AutoSize = true;
            this.lbAmountPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAmountPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAmountPrice.Location = new System.Drawing.Point(42, 73);
            this.lbAmountPrice.Name = "lbAmountPrice";
            this.lbAmountPrice.Size = new System.Drawing.Size(104, 42);
            this.lbAmountPrice.TabIndex = 10;
            this.lbAmountPrice.Text = "Product\r\nAmount Price";
            this.lbAmountPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(52, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Amount";
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.Transparent;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = global::shoppingApp.Properties.Resources.delete_bin_30px;
            this.btnDelete.ImageSize = new System.Drawing.Size(30, 30);
            this.btnDelete.Location = new System.Drawing.Point(761, 53);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.lbQuantity);
            this.panel3.Controls.Add(this.btnPlus);
            this.panel3.Controls.Add(this.btnMinus);
            this.panel3.Location = new System.Drawing.Point(409, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(165, 139);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(47, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantity";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbQuantity
            // 
            this.lbQuantity.AutoSize = true;
            this.lbQuantity.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantity.ForeColor = System.Drawing.Color.Black;
            this.lbQuantity.Location = new System.Drawing.Point(73, 74);
            this.lbQuantity.Name = "lbQuantity";
            this.lbQuantity.Size = new System.Drawing.Size(19, 21);
            this.lbQuantity.TabIndex = 5;
            this.lbQuantity.Text = "0";
            this.lbQuantity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbQuantity.Click += new System.EventHandler(this.lbQuantity_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnPlus.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPlus.Image = global::shoppingApp.Properties.Resources.plus_math_30px;
            this.btnPlus.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnPlus.ImageRotate = 0F;
            this.btnPlus.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPlus.Location = new System.Drawing.Point(110, 74);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnPlus.Size = new System.Drawing.Size(25, 25);
            this.btnPlus.TabIndex = 1;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinus.HoverState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnMinus.Image = global::shoppingApp.Properties.Resources.minus_30px;
            this.btnMinus.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinus.ImageRotate = 0F;
            this.btnMinus.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMinus.Location = new System.Drawing.Point(28, 74);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.PressedState.ImageSize = new System.Drawing.Size(22, 22);
            this.btnMinus.Size = new System.Drawing.Size(25, 25);
            this.btnMinus.TabIndex = 0;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbSize);
            this.panel2.Controls.Add(this.lbProdPrice);
            this.panel2.Controls.Add(this.lbProdName);
            this.panel2.Controls.Add(this.pcProdImage);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(407, 138);
            this.panel2.TabIndex = 3;
            // 
            // lbSize
            // 
            this.lbSize.AutoSize = true;
            this.lbSize.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSize.ForeColor = System.Drawing.Color.Black;
            this.lbSize.Location = new System.Drawing.Point(175, 59);
            this.lbSize.Name = "lbSize";
            this.lbSize.Size = new System.Drawing.Size(31, 17);
            this.lbSize.TabIndex = 6;
            this.lbSize.Text = "Size";
            // 
            // lbProdPrice
            // 
            this.lbProdPrice.AutoSize = true;
            this.lbProdPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.lbProdPrice.Location = new System.Drawing.Point(174, 78);
            this.lbProdPrice.Name = "lbProdPrice";
            this.lbProdPrice.Size = new System.Drawing.Size(102, 21);
            this.lbProdPrice.TabIndex = 5;
            this.lbProdPrice.Text = "Product Price";
            // 
            // lbProdName
            // 
            this.lbProdName.AutoSize = true;
            this.lbProdName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProdName.ForeColor = System.Drawing.Color.Black;
            this.lbProdName.Location = new System.Drawing.Point(174, 35);
            this.lbProdName.Name = "lbProdName";
            this.lbProdName.Size = new System.Drawing.Size(110, 21);
            this.lbProdName.TabIndex = 4;
            this.lbProdName.Text = "Product Name";
            // 
            // pcProdImage
            // 
            this.pcProdImage.Location = new System.Drawing.Point(23, 12);
            this.pcProdImage.Name = "pcProdImage";
            this.pcProdImage.Size = new System.Drawing.Size(120, 115);
            this.pcProdImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcProdImage.TabIndex = 3;
            this.pcProdImage.TabStop = false;
            // 
            // ucCartItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Name = "ucCartItem";
            this.Size = new System.Drawing.Size(815, 138);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcProdImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbProdPrice;
        private System.Windows.Forms.Label lbProdName;
        private System.Windows.Forms.PictureBox pcProdImage;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinus;
        private Guna.UI2.WinForms.Guna2ImageButton btnPlus;
        private System.Windows.Forms.Label lbQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbSize;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbAmountPrice;
        private System.Windows.Forms.Label label2;
    }
}
