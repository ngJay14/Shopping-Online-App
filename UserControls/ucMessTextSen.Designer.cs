﻿namespace shoppingApp.UserControls
{
    partial class ucMessTextSen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMessTextSen));
            this.richTxtMessage = new System.Windows.Forms.RichTextBox();
            this.lbTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTxtMessage
            // 
            this.richTxtMessage.BackColor = System.Drawing.Color.White;
            this.richTxtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTxtMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTxtMessage.ForeColor = System.Drawing.Color.Black;
            this.richTxtMessage.HideSelection = false;
            this.richTxtMessage.Location = new System.Drawing.Point(182, 22);
            this.richTxtMessage.Name = "richTxtMessage";
            this.richTxtMessage.ReadOnly = true;
            this.richTxtMessage.Size = new System.Drawing.Size(162, 135);
            this.richTxtMessage.TabIndex = 6;
            this.richTxtMessage.Text = "Nguyên";
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.ForeColor = System.Drawing.Color.Gray;
            this.lbTime.Location = new System.Drawing.Point(30, 142);
            this.lbTime.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(106, 15);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "11:04:23 27/03/2024";
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.Location = new System.Drawing.Point(39, -20);
            this.lbMessage.MaximumSize = new System.Drawing.Size(250, 0);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(250, 180);
            this.lbMessage.TabIndex = 5;
            this.lbMessage.Text = resources.GetString("lbMessage.Text");
            // 
            // ucMessTextSen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.richTxtMessage);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbMessage);
            this.Name = "ucMessTextSen";
            this.Size = new System.Drawing.Size(374, 160);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtMessage;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbTime;
        private System.Windows.Forms.Label lbMessage;
    }
}
