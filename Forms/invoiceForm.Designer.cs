namespace shoppingApp.Forms
{
    partial class invoiceForm
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
            this.invoice = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // invoice
            // 
            this.invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.invoice.LocalReport.ReportEmbeddedResource = "shoppingApp.Invoice.invoice.rdlc";
            this.invoice.Location = new System.Drawing.Point(0, 0);
            this.invoice.Name = "invoice";
            this.invoice.ServerReport.BearerToken = null;
            this.invoice.Size = new System.Drawing.Size(800, 450);
            this.invoice.TabIndex = 0;
            // 
            // invoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.invoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "invoiceForm";
            this.Text = "invoiceForm";
            this.Load += new System.EventHandler(this.invoiceForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer invoice;
    }
}