namespace shoppingApp.Forms
{
    partial class cartForm
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
            this.flPnItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDischarge = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmptyCart = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flPnItems
            // 
            this.flPnItems.AutoScroll = true;
            this.flPnItems.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flPnItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.flPnItems.Location = new System.Drawing.Point(0, 0);
            this.flPnItems.Name = "flPnItems";
            this.flPnItems.Padding = new System.Windows.Forms.Padding(25, 0, 20, 0);
            this.flPnItems.Size = new System.Drawing.Size(829, 460);
            this.flPnItems.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDischarge);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 153);
            this.panel1.TabIndex = 1;
            // 
            // btnDischarge
            // 
            this.btnDischarge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDischarge.BorderRadius = 8;
            this.btnDischarge.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDischarge.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDischarge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDischarge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDischarge.FillColor = System.Drawing.Color.Black;
            this.btnDischarge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDischarge.ForeColor = System.Drawing.Color.White;
            this.btnDischarge.Location = new System.Drawing.Point(510, 67);
            this.btnDischarge.Margin = new System.Windows.Forms.Padding(4);
            this.btnDischarge.Name = "btnDischarge";
            this.btnDischarge.Size = new System.Drawing.Size(265, 37);
            this.btnDischarge.TabIndex = 28;
            this.btnDischarge.Text = "Discharge";
            this.btnDischarge.Click += new System.EventHandler(this.btnDischarge_Click);
            // 
            // lbTotal
            // 
            this.lbTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbTotal.AutoSize = true;
            this.lbTotal.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotal.Location = new System.Drawing.Point(564, 25);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(34, 23);
            this.lbTotal.TabIndex = 1;
            this.lbTotal.Text = "0 đ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total: ";
            // 
            // lbEmptyCart
            // 
            this.lbEmptyCart.AutoSize = true;
            this.lbEmptyCart.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmptyCart.Location = new System.Drawing.Point(337, 222);
            this.lbEmptyCart.Name = "lbEmptyCart";
            this.lbEmptyCart.Size = new System.Drawing.Size(162, 25);
            this.lbEmptyCart.TabIndex = 0;
            this.lbEmptyCart.Text = "Your cart is empty";
            this.lbEmptyCart.Visible = false;
            // 
            // cartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 618);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flPnItems);
            this.Controls.Add(this.lbEmptyCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "cartForm";
            this.Text = "cartForm";
            this.Load += new System.EventHandler(this.cartForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnDischarge;
        private System.Windows.Forms.Label lbEmptyCart;
    }
}