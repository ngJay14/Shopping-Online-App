namespace shoppingApp.Forms
{
    partial class transactionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(transactionForm));
            this.flPnItems = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConDischarge = new Guna.UI2.WinForms.Guna2Button();
            this.lbTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPhoneNum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnNote = new System.Windows.Forms.Panel();
            this.rchTxtNote = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbBoxPayMethod = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnNote.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
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
            this.flPnItems.Size = new System.Drawing.Size(829, 272);
            this.flPnItems.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnConDischarge);
            this.panel1.Controls.Add(this.lbTotal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 491);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(829, 127);
            this.panel1.TabIndex = 1;
            // 
            // btnConDischarge
            // 
            this.btnConDischarge.BorderRadius = 8;
            this.btnConDischarge.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConDischarge.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConDischarge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConDischarge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConDischarge.FillColor = System.Drawing.Color.Black;
            this.btnConDischarge.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConDischarge.ForeColor = System.Drawing.Color.White;
            this.btnConDischarge.Location = new System.Drawing.Point(510, 67);
            this.btnConDischarge.Margin = new System.Windows.Forms.Padding(4);
            this.btnConDischarge.Name = "btnConDischarge";
            this.btnConDischarge.Size = new System.Drawing.Size(265, 37);
            this.btnConDischarge.TabIndex = 28;
            this.btnConDischarge.Text = "Confirm discharge";
            this.btnConDischarge.Click += new System.EventHandler(this.btnConDischarge_Click);
            // 
            // lbTotal
            // 
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
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(509, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total: ";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtPhoneNum);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pnNote);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbBoxPayMethod);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtAddress);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(0, 270);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(829, 224);
            this.panel2.TabIndex = 0;
            // 
            // txtPhoneNum
            // 
            this.txtPhoneNum.BorderColor = System.Drawing.Color.Silver;
            this.txtPhoneNum.BorderRadius = 5;
            this.txtPhoneNum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPhoneNum.DefaultText = "";
            this.txtPhoneNum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPhoneNum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPhoneNum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPhoneNum.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtPhoneNum.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtPhoneNum.ForeColor = System.Drawing.Color.Black;
            this.txtPhoneNum.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtPhoneNum.Location = new System.Drawing.Point(18, 111);
            this.txtPhoneNum.Name = "txtPhoneNum";
            this.txtPhoneNum.PasswordChar = '\0';
            this.txtPhoneNum.PlaceholderText = "Phone number";
            this.txtPhoneNum.SelectedText = "";
            this.txtPhoneNum.Size = new System.Drawing.Size(374, 39);
            this.txtPhoneNum.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "Phone number";
            // 
            // pnNote
            // 
            this.pnNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnNote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnNote.Controls.Add(this.rchTxtNote);
            this.pnNote.Location = new System.Drawing.Point(436, 42);
            this.pnNote.Name = "pnNote";
            this.pnNote.Size = new System.Drawing.Size(376, 171);
            this.pnNote.TabIndex = 32;
            // 
            // rchTxtNote
            // 
            this.rchTxtNote.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rchTxtNote.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rchTxtNote.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rchTxtNote.Location = new System.Drawing.Point(0, 0);
            this.rchTxtNote.Name = "rchTxtNote";
            this.rchTxtNote.Size = new System.Drawing.Size(374, 169);
            this.rchTxtNote.TabIndex = 27;
            this.rchTxtNote.Text = "";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(432, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Note for shipper";
            // 
            // cbBoxPayMethod
            // 
            this.cbBoxPayMethod.BackColor = System.Drawing.Color.Transparent;
            this.cbBoxPayMethod.BorderColor = System.Drawing.Color.Silver;
            this.cbBoxPayMethod.BorderRadius = 5;
            this.cbBoxPayMethod.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbBoxPayMethod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBoxPayMethod.FocusedColor = System.Drawing.Color.Black;
            this.cbBoxPayMethod.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.cbBoxPayMethod.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbBoxPayMethod.ForeColor = System.Drawing.Color.Black;
            this.cbBoxPayMethod.ItemHeight = 30;
            this.cbBoxPayMethod.Items.AddRange(new object[] {
            "Cash on Delivery (COD)",
            "Digital Payments"});
            this.cbBoxPayMethod.Location = new System.Drawing.Point(18, 177);
            this.cbBoxPayMethod.Name = "cbBoxPayMethod";
            this.cbBoxPayMethod.Size = new System.Drawing.Size(374, 36);
            this.cbBoxPayMethod.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Payment method";
            // 
            // txtAddress
            // 
            this.txtAddress.BorderColor = System.Drawing.Color.Silver;
            this.txtAddress.BorderRadius = 5;
            this.txtAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAddress.DefaultText = "";
            this.txtAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAddress.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtAddress.ForeColor = System.Drawing.Color.Black;
            this.txtAddress.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtAddress.Location = new System.Drawing.Point(18, 42);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PlaceholderText = "Shipping address";
            this.txtAddress.SelectedText = "";
            this.txtAddress.Size = new System.Drawing.Size(374, 39);
            this.txtAddress.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Shipping address";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // transactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flPnItems);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "transactionForm";
            this.Text = "cartForm";
            this.Load += new System.EventHandler(this.orderForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnNote.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flPnItems;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnConDischarge;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnNote;
        private System.Windows.Forms.RichTextBox rchTxtNote;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox cbBoxPayMethod;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtAddress;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPhoneNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ErrorProvider error;
    }
}