namespace shoppingApp.Forms
{
    partial class loginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnForgetPass = new System.Windows.Forms.Panel();
            this.pcReturn = new System.Windows.Forms.PictureBox();
            this.lbDesForPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbForPass = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnSend = new Guna.UI2.WinForms.Guna2Button();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnLogin = new System.Windows.Forms.Panel();
            this.lbSignup = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lnkLbForgetPass = new System.Windows.Forms.LinkLabel();
            this.lnkLbLogup = new System.Windows.Forms.LinkLabel();
            this.lbQues = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnExit = new Guna.UI2.WinForms.Guna2ImageButton();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.pnForgetPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcReturn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 471);
            this.panel1.TabIndex = 1;
            // 
            // pnForgetPass
            // 
            this.pnForgetPass.Controls.Add(this.pcReturn);
            this.pnForgetPass.Controls.Add(this.lbDesForPass);
            this.pnForgetPass.Controls.Add(this.lbForPass);
            this.pnForgetPass.Controls.Add(this.btnSend);
            this.pnForgetPass.Controls.Add(this.txtEmail);
            this.pnForgetPass.Location = new System.Drawing.Point(435, 40);
            this.pnForgetPass.Name = "pnForgetPass";
            this.pnForgetPass.Size = new System.Drawing.Size(337, 372);
            this.pnForgetPass.TabIndex = 34;
            this.pnForgetPass.Visible = false;
            // 
            // pcReturn
            // 
            this.pcReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcReturn.Image = global::shoppingApp.Properties.Resources.undo_30px;
            this.pcReturn.Location = new System.Drawing.Point(277, 7);
            this.pcReturn.Margin = new System.Windows.Forms.Padding(4);
            this.pcReturn.Name = "pcReturn";
            this.pcReturn.Size = new System.Drawing.Size(25, 25);
            this.pcReturn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcReturn.TabIndex = 29;
            this.pcReturn.TabStop = false;
            this.pcReturn.Click += new System.EventHandler(this.pcReturn_Click);
            // 
            // lbDesForPass
            // 
            this.lbDesForPass.AutoSize = false;
            this.lbDesForPass.BackColor = System.Drawing.Color.Transparent;
            this.lbDesForPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDesForPass.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDesForPass.Location = new System.Drawing.Point(36, 86);
            this.lbDesForPass.Margin = new System.Windows.Forms.Padding(4);
            this.lbDesForPass.Name = "lbDesForPass";
            this.lbDesForPass.Size = new System.Drawing.Size(234, 48);
            this.lbDesForPass.TabIndex = 28;
            this.lbDesForPass.Text = "Please enter your email and we will send password to your email address\r\n";
            this.lbDesForPass.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbForPass
            // 
            this.lbForPass.BackColor = System.Drawing.Color.Transparent;
            this.lbForPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbForPass.Location = new System.Drawing.Point(48, 40);
            this.lbForPass.Margin = new System.Windows.Forms.Padding(4);
            this.lbForPass.Name = "lbForPass";
            this.lbForPass.Size = new System.Drawing.Size(221, 33);
            this.lbForPass.TabIndex = 27;
            this.lbForPass.Text = "Forget password";
            // 
            // btnSend
            // 
            this.btnSend.BorderRadius = 8;
            this.btnSend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSend.FillColor = System.Drawing.Color.Black;
            this.btnSend.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Location = new System.Drawing.Point(54, 203);
            this.btnSend.Margin = new System.Windows.Forms.Padding(4);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(201, 50);
            this.btnSend.TabIndex = 26;
            this.btnSend.Text = "Send";
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.BorderRadius = 5;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(19, 143);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(272, 41);
            this.txtEmail.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 47);
            this.label1.TabIndex = 100;
            this.label1.Text = "WELCOME BACK";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::shoppingApp.Properties.Resources.logo_name_slogan;
            this.pictureBox1.Location = new System.Drawing.Point(70, 120);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 8;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(24, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(329, 36);
            this.txtUsername.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 8;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.Black;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(94, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(180, 45);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "Log in";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.BorderRadius = 8;
            this.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPass.DefaultText = "";
            this.txtPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPass.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.ForeColor = System.Drawing.Color.Black;
            this.txtPass.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtPass.Location = new System.Drawing.Point(24, 108);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '●';
            this.txtPass.PlaceholderText = "Password";
            this.txtPass.SelectedText = "";
            this.txtPass.Size = new System.Drawing.Size(329, 36);
            this.txtPass.TabIndex = 1;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // pnLogin
            // 
            this.pnLogin.Controls.Add(this.lbSignup);
            this.pnLogin.Controls.Add(this.lnkLbForgetPass);
            this.pnLogin.Controls.Add(this.lnkLbLogup);
            this.pnLogin.Controls.Add(this.lbQues);
            this.pnLogin.Controls.Add(this.txtUsername);
            this.pnLogin.Controls.Add(this.txtPass);
            this.pnLogin.Controls.Add(this.btnLogin);
            this.pnLogin.Location = new System.Drawing.Point(416, 83);
            this.pnLogin.Name = "pnLogin";
            this.pnLogin.Size = new System.Drawing.Size(384, 288);
            this.pnLogin.TabIndex = 8;
            // 
            // lbSignup
            // 
            this.lbSignup.BackColor = System.Drawing.Color.Transparent;
            this.lbSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSignup.Location = new System.Drawing.Point(137, 3);
            this.lbSignup.Name = "lbSignup";
            this.lbSignup.Size = new System.Drawing.Size(94, 33);
            this.lbSignup.TabIndex = 9;
            this.lbSignup.Text = "Sign In";
            // 
            // lnkLbForgetPass
            // 
            this.lnkLbForgetPass.AutoSize = true;
            this.lnkLbForgetPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLbForgetPass.Location = new System.Drawing.Point(109, 250);
            this.lnkLbForgetPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLbForgetPass.Name = "lnkLbForgetPass";
            this.lnkLbForgetPass.Size = new System.Drawing.Size(152, 17);
            this.lnkLbForgetPass.TabIndex = 33;
            this.lnkLbForgetPass.TabStop = true;
            this.lnkLbForgetPass.Text = "Forget your passwod ?";
            this.lnkLbForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbForgetPass_LinkClicked);
            // 
            // lnkLbLogup
            // 
            this.lnkLbLogup.AutoSize = true;
            this.lnkLbLogup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnkLbLogup.Location = new System.Drawing.Point(234, 217);
            this.lnkLbLogup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lnkLbLogup.Name = "lnkLbLogup";
            this.lnkLbLogup.Size = new System.Drawing.Size(56, 17);
            this.lnkLbLogup.TabIndex = 32;
            this.lnkLbLogup.TabStop = true;
            this.lnkLbLogup.Text = "Sign up";
            this.lnkLbLogup.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbLogup_LinkClicked);
            // 
            // lbQues
            // 
            this.lbQues.BackColor = System.Drawing.Color.Transparent;
            this.lbQues.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQues.Location = new System.Drawing.Point(83, 217);
            this.lbQues.Margin = new System.Windows.Forms.Padding(4);
            this.lbQues.Name = "lbQues";
            this.lbQues.Size = new System.Drawing.Size(148, 18);
            this.lbQues.TabIndex = 31;
            this.lbQues.Text = "Dont\'t have an account ?";
            // 
            // btnExit
            // 
            this.btnExit.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnExit.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Image = global::shoppingApp.Properties.Resources.delete_30px;
            this.btnExit.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnExit.ImageRotate = 0F;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(770, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnExit.Size = new System.Drawing.Size(30, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.pnForgetPass);
            this.Controls.Add(this.pnLogin);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SHON";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnForgetPass.ResumeLayout(false);
            this.pnForgetPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcReturn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnLogin.ResumeLayout(false);
            this.pnLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ImageButton btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPass;
        private System.Windows.Forms.Panel pnLogin;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbSignup;
        private System.Windows.Forms.LinkLabel lnkLbForgetPass;
        private System.Windows.Forms.LinkLabel lnkLbLogup;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbQues;
        private System.Windows.Forms.Panel pnForgetPass;
        private System.Windows.Forms.PictureBox pcReturn;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbDesForPass;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbForPass;
        private Guna.UI2.WinForms.Guna2Button btnSend;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.ErrorProvider error;
    }
}