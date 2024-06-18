namespace shoppingApp.UserControls
{
    partial class ucMessIconRec
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
            this.lbTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pcAva = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pcIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcAva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.ForeColor = System.Drawing.Color.Gray;
            this.lbTime.Location = new System.Drawing.Point(127, 66);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(106, 15);
            this.lbTime.TabIndex = 6;
            this.lbTime.Text = "11:04:23 27/03/2024";
            // 
            // pcAva
            // 
            this.pcAva.ImageRotate = 0F;
            this.pcAva.Location = new System.Drawing.Point(15, 4);
            this.pcAva.Name = "pcAva";
            this.pcAva.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pcAva.Size = new System.Drawing.Size(40, 40);
            this.pcAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcAva.TabIndex = 5;
            this.pcAva.TabStop = false;
            // 
            // pcIcon
            // 
            this.pcIcon.BackColor = System.Drawing.Color.Transparent;
            this.pcIcon.Location = new System.Drawing.Point(61, 21);
            this.pcIcon.Name = "pcIcon";
            this.pcIcon.Size = new System.Drawing.Size(60, 60);
            this.pcIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcIcon.TabIndex = 4;
            this.pcIcon.TabStop = false;
            // 
            // ucMessIconRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.pcAva);
            this.Controls.Add(this.pcIcon);
            this.Name = "ucMessIconRec";
            this.Size = new System.Drawing.Size(257, 91);
            ((System.ComponentModel.ISupportInitialize)(this.pcAva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel lbTime;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pcAva;
        private System.Windows.Forms.PictureBox pcIcon;
    }
}
