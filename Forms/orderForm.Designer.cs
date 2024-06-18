namespace shoppingApp.Forms
{
    partial class orderForm
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
            this.flPnOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.lbEmptyOrder = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flPnOrders
            // 
            this.flPnOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flPnOrders.Location = new System.Drawing.Point(0, 0);
            this.flPnOrders.Name = "flPnOrders";
            this.flPnOrders.Padding = new System.Windows.Forms.Padding(20, 0, 15, 0);
            this.flPnOrders.Size = new System.Drawing.Size(829, 618);
            this.flPnOrders.TabIndex = 0;
            // 
            // lbEmptyOrder
            // 
            this.lbEmptyOrder.AutoSize = true;
            this.lbEmptyOrder.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmptyOrder.Location = new System.Drawing.Point(308, 265);
            this.lbEmptyOrder.Name = "lbEmptyOrder";
            this.lbEmptyOrder.Size = new System.Drawing.Size(216, 25);
            this.lbEmptyOrder.TabIndex = 2;
            this.lbEmptyOrder.Text = "Your have no any orders";
            this.lbEmptyOrder.Visible = false;
            // 
            // orderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 618);
            this.Controls.Add(this.lbEmptyOrder);
            this.Controls.Add(this.flPnOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "orderForm";
            this.Text = "orderForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnOrders;
        private System.Windows.Forms.Label lbEmptyOrder;
    }
}