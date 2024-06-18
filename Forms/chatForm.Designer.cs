namespace shoppingApp.Forms
{
    partial class chatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatForm));
            this.pnUsers = new System.Windows.Forms.FlowLayoutPanel();
            this.pnChat = new System.Windows.Forms.Panel();
            this.pnImages = new System.Windows.Forms.Panel();
            this.flPnChosenImages = new System.Windows.Forms.FlowLayoutPanel();
            this.pcCloseImagePanel = new System.Windows.Forms.PictureBox();
            this.pnEmotions = new System.Windows.Forms.Panel();
            this.pcEmo1 = new System.Windows.Forms.PictureBox();
            this.pcEmo2 = new System.Windows.Forms.PictureBox();
            this.pcEmo3 = new System.Windows.Forms.PictureBox();
            this.pcEmo4 = new System.Windows.Forms.PictureBox();
            this.pcEmo5 = new System.Windows.Forms.PictureBox();
            this.pcEmo6 = new System.Windows.Forms.PictureBox();
            this.pcEmo7 = new System.Windows.Forms.PictureBox();
            this.pcEmo8 = new System.Windows.Forms.PictureBox();
            this.pcEmo9 = new System.Windows.Forms.PictureBox();
            this.pcEmo10 = new System.Windows.Forms.PictureBox();
            this.pcCloseEmoPanel = new System.Windows.Forms.PictureBox();
            this.pnType = new Guna.UI2.WinForms.Guna2Panel();
            this.btnEmotions = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnImage = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtChat = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSend = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnReceiver = new Guna.UI2.WinForms.Guna2Panel();
            this.lbFullnameReceiver = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lbUsernameReceiver = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pcReceiver = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnImages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcCloseImagePanel)).BeginInit();
            this.pnEmotions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCloseEmoPanel)).BeginInit();
            this.pnType.SuspendLayout();
            this.pnReceiver.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcReceiver)).BeginInit();
            this.SuspendLayout();
            // 
            // pnUsers
            // 
            this.pnUsers.BackColor = System.Drawing.Color.White;
            this.pnUsers.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnUsers.Location = new System.Drawing.Point(0, 0);
            this.pnUsers.Name = "pnUsers";
            this.pnUsers.Size = new System.Drawing.Size(281, 618);
            this.pnUsers.TabIndex = 4;
            // 
            // pnChat
            // 
            this.pnChat.AutoScroll = true;
            this.pnChat.BackColor = System.Drawing.SystemColors.Control;
            this.pnChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnChat.Location = new System.Drawing.Point(281, 76);
            this.pnChat.Name = "pnChat";
            this.pnChat.Size = new System.Drawing.Size(548, 491);
            this.pnChat.TabIndex = 6;
            // 
            // pnImages
            // 
            this.pnImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnImages.Controls.Add(this.flPnChosenImages);
            this.pnImages.Controls.Add(this.pcCloseImagePanel);
            this.pnImages.Location = new System.Drawing.Point(344, 485);
            this.pnImages.Name = "pnImages";
            this.pnImages.Size = new System.Drawing.Size(250, 82);
            this.pnImages.TabIndex = 0;
            this.pnImages.Visible = false;
            // 
            // flPnChosenImages
            // 
            this.flPnChosenImages.AutoScroll = true;
            this.flPnChosenImages.BackColor = System.Drawing.Color.Transparent;
            this.flPnChosenImages.Location = new System.Drawing.Point(3, 3);
            this.flPnChosenImages.Name = "flPnChosenImages";
            this.flPnChosenImages.Size = new System.Drawing.Size(215, 70);
            this.flPnChosenImages.TabIndex = 2;
            this.flPnChosenImages.WrapContents = false;
            // 
            // pcCloseImagePanel
            // 
            this.pcCloseImagePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcCloseImagePanel.Image = global::shoppingApp.Properties.Resources.close2;
            this.pcCloseImagePanel.Location = new System.Drawing.Point(224, 3);
            this.pcCloseImagePanel.Name = "pcCloseImagePanel";
            this.pcCloseImagePanel.Size = new System.Drawing.Size(20, 20);
            this.pcCloseImagePanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCloseImagePanel.TabIndex = 1;
            this.pcCloseImagePanel.TabStop = false;
            this.pcCloseImagePanel.Click += new System.EventHandler(this.pcCloseImagePanel_Click);
            // 
            // pnEmotions
            // 
            this.pnEmotions.BackColor = System.Drawing.Color.Transparent;
            this.pnEmotions.Controls.Add(this.pcEmo1);
            this.pnEmotions.Controls.Add(this.pcEmo2);
            this.pnEmotions.Controls.Add(this.pcEmo3);
            this.pnEmotions.Controls.Add(this.pcEmo4);
            this.pnEmotions.Controls.Add(this.pcEmo5);
            this.pnEmotions.Controls.Add(this.pcEmo6);
            this.pnEmotions.Controls.Add(this.pcEmo7);
            this.pnEmotions.Controls.Add(this.pcEmo8);
            this.pnEmotions.Controls.Add(this.pcEmo9);
            this.pnEmotions.Controls.Add(this.pcEmo10);
            this.pnEmotions.Controls.Add(this.pcCloseEmoPanel);
            this.pnEmotions.Location = new System.Drawing.Point(344, 517);
            this.pnEmotions.Name = "pnEmotions";
            this.pnEmotions.Size = new System.Drawing.Size(436, 50);
            this.pnEmotions.TabIndex = 1;
            this.pnEmotions.Visible = false;
            // 
            // pcEmo1
            // 
            this.pcEmo1.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo1.Image = global::shoppingApp.Properties.Resources.smile;
            this.pcEmo1.ImageLocation = "";
            this.pcEmo1.Location = new System.Drawing.Point(10, 0);
            this.pcEmo1.Name = "pcEmo1";
            this.pcEmo1.Size = new System.Drawing.Size(40, 40);
            this.pcEmo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo1.TabIndex = 2;
            this.pcEmo1.TabStop = false;
            // 
            // pcEmo2
            // 
            this.pcEmo2.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo2.Image = global::shoppingApp.Properties.Resources.neutral;
            this.pcEmo2.Location = new System.Drawing.Point(50, 0);
            this.pcEmo2.Name = "pcEmo2";
            this.pcEmo2.Size = new System.Drawing.Size(40, 40);
            this.pcEmo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo2.TabIndex = 3;
            this.pcEmo2.TabStop = false;
            // 
            // pcEmo3
            // 
            this.pcEmo3.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo3.Image = global::shoppingApp.Properties.Resources.smiling;
            this.pcEmo3.Location = new System.Drawing.Point(90, 0);
            this.pcEmo3.Name = "pcEmo3";
            this.pcEmo3.Size = new System.Drawing.Size(40, 40);
            this.pcEmo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo3.TabIndex = 4;
            this.pcEmo3.TabStop = false;
            // 
            // pcEmo4
            // 
            this.pcEmo4.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo4.Image = global::shoppingApp.Properties.Resources.angry;
            this.pcEmo4.Location = new System.Drawing.Point(130, 0);
            this.pcEmo4.Name = "pcEmo4";
            this.pcEmo4.Size = new System.Drawing.Size(40, 40);
            this.pcEmo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo4.TabIndex = 5;
            this.pcEmo4.TabStop = false;
            // 
            // pcEmo5
            // 
            this.pcEmo5.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo5.Image = global::shoppingApp.Properties.Resources.emoji;
            this.pcEmo5.Location = new System.Drawing.Point(170, 0);
            this.pcEmo5.Name = "pcEmo5";
            this.pcEmo5.Size = new System.Drawing.Size(40, 40);
            this.pcEmo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo5.TabIndex = 6;
            this.pcEmo5.TabStop = false;
            // 
            // pcEmo6
            // 
            this.pcEmo6.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo6.Image = global::shoppingApp.Properties.Resources.love;
            this.pcEmo6.Location = new System.Drawing.Point(210, 0);
            this.pcEmo6.Name = "pcEmo6";
            this.pcEmo6.Size = new System.Drawing.Size(40, 40);
            this.pcEmo6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo6.TabIndex = 7;
            this.pcEmo6.TabStop = false;
            // 
            // pcEmo7
            // 
            this.pcEmo7.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo7.Image = global::shoppingApp.Properties.Resources.sad_2;
            this.pcEmo7.Location = new System.Drawing.Point(250, 0);
            this.pcEmo7.Name = "pcEmo7";
            this.pcEmo7.Size = new System.Drawing.Size(40, 40);
            this.pcEmo7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo7.TabIndex = 8;
            this.pcEmo7.TabStop = false;
            // 
            // pcEmo8
            // 
            this.pcEmo8.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo8.Image = global::shoppingApp.Properties.Resources.sad_cry;
            this.pcEmo8.Location = new System.Drawing.Point(290, 0);
            this.pcEmo8.Name = "pcEmo8";
            this.pcEmo8.Size = new System.Drawing.Size(40, 40);
            this.pcEmo8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo8.TabIndex = 9;
            this.pcEmo8.TabStop = false;
            // 
            // pcEmo9
            // 
            this.pcEmo9.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo9.Image = global::shoppingApp.Properties.Resources.shocked;
            this.pcEmo9.Location = new System.Drawing.Point(330, 0);
            this.pcEmo9.Name = "pcEmo9";
            this.pcEmo9.Size = new System.Drawing.Size(40, 40);
            this.pcEmo9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo9.TabIndex = 10;
            this.pcEmo9.TabStop = false;
            // 
            // pcEmo10
            // 
            this.pcEmo10.BackColor = System.Drawing.Color.Transparent;
            this.pcEmo10.Image = global::shoppingApp.Properties.Resources.sad;
            this.pcEmo10.Location = new System.Drawing.Point(370, 0);
            this.pcEmo10.Name = "pcEmo10";
            this.pcEmo10.Size = new System.Drawing.Size(40, 40);
            this.pcEmo10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcEmo10.TabIndex = 11;
            this.pcEmo10.TabStop = false;
            // 
            // pcCloseEmoPanel
            // 
            this.pcCloseEmoPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcCloseEmoPanel.Image = global::shoppingApp.Properties.Resources.close2;
            this.pcCloseEmoPanel.Location = new System.Drawing.Point(411, 0);
            this.pcCloseEmoPanel.Name = "pcCloseEmoPanel";
            this.pcCloseEmoPanel.Size = new System.Drawing.Size(20, 20);
            this.pcCloseEmoPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcCloseEmoPanel.TabIndex = 12;
            this.pcCloseEmoPanel.TabStop = false;
            this.pcCloseEmoPanel.Click += new System.EventHandler(this.pcCloseEmoPanel_Click);
            // 
            // pnType
            // 
            this.pnType.BackColor = System.Drawing.Color.White;
            this.pnType.Controls.Add(this.btnEmotions);
            this.pnType.Controls.Add(this.btnImage);
            this.pnType.Controls.Add(this.txtChat);
            this.pnType.Controls.Add(this.btnSend);
            this.pnType.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnType.Location = new System.Drawing.Point(281, 567);
            this.pnType.Name = "pnType";
            this.pnType.Size = new System.Drawing.Size(548, 51);
            this.pnType.TabIndex = 8;
            // 
            // btnEmotions
            // 
            this.btnEmotions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmotions.BackColor = System.Drawing.Color.LightCyan;
            this.btnEmotions.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnEmotions.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEmotions.Image = global::shoppingApp.Properties.Resources.emotional;
            this.btnEmotions.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnEmotions.ImageRotate = 0F;
            this.btnEmotions.ImageSize = new System.Drawing.Size(30, 30);
            this.btnEmotions.Location = new System.Drawing.Point(439, 6);
            this.btnEmotions.Name = "btnEmotions";
            this.btnEmotions.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEmotions.Size = new System.Drawing.Size(46, 37);
            this.btnEmotions.TabIndex = 4;
            this.btnEmotions.Click += new System.EventHandler(this.btnEmotions_Click);
            // 
            // btnImage
            // 
            this.btnImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnImage.BackColor = System.Drawing.Color.LightCyan;
            this.btnImage.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnImage.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImage.Image = global::shoppingApp.Properties.Resources.image;
            this.btnImage.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnImage.ImageRotate = 0F;
            this.btnImage.ImageSize = new System.Drawing.Size(20, 20);
            this.btnImage.Location = new System.Drawing.Point(11, 6);
            this.btnImage.Name = "btnImage";
            this.btnImage.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnImage.Size = new System.Drawing.Size(46, 37);
            this.btnImage.TabIndex = 3;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // txtChat
            // 
            this.txtChat.AcceptsTab = true;
            this.txtChat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtChat.AutoScroll = true;
            this.txtChat.BackColor = System.Drawing.Color.Transparent;
            this.txtChat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChat.DefaultText = "";
            this.txtChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChat.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtChat.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.txtChat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChat.ForeColor = System.Drawing.Color.Black;
            this.txtChat.HoverState.BorderColor = System.Drawing.Color.Black;
            this.txtChat.Location = new System.Drawing.Point(63, 6);
            this.txtChat.Multiline = true;
            this.txtChat.Name = "txtChat";
            this.txtChat.PasswordChar = '\0';
            this.txtChat.PlaceholderText = "Type here";
            this.txtChat.SelectedText = "";
            this.txtChat.Size = new System.Drawing.Size(369, 36);
            this.txtChat.TabIndex = 1;
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btnSend.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnSend.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSend.Image = global::shoppingApp.Properties.Resources.send;
            this.btnSend.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnSend.ImageRotate = 0F;
            this.btnSend.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSend.Location = new System.Drawing.Point(492, 6);
            this.btnSend.Name = "btnSend";
            this.btnSend.PressedState.ImageSize = new System.Drawing.Size(25, 25);
            this.btnSend.Size = new System.Drawing.Size(46, 37);
            this.btnSend.TabIndex = 0;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // pnReceiver
            // 
            this.pnReceiver.BackColor = System.Drawing.Color.White;
            this.pnReceiver.Controls.Add(this.lbFullnameReceiver);
            this.pnReceiver.Controls.Add(this.lbUsernameReceiver);
            this.pnReceiver.Controls.Add(this.pcReceiver);
            this.pnReceiver.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnReceiver.Location = new System.Drawing.Point(281, 0);
            this.pnReceiver.Name = "pnReceiver";
            this.pnReceiver.Size = new System.Drawing.Size(548, 76);
            this.pnReceiver.TabIndex = 9;
            // 
            // lbFullnameReceiver
            // 
            this.lbFullnameReceiver.BackColor = System.Drawing.Color.Transparent;
            this.lbFullnameReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFullnameReceiver.Location = new System.Drawing.Point(90, 46);
            this.lbFullnameReceiver.Name = "lbFullnameReceiver";
            this.lbFullnameReceiver.Size = new System.Drawing.Size(58, 17);
            this.lbFullnameReceiver.TabIndex = 2;
            this.lbFullnameReceiver.Text = "Full name";
            // 
            // lbUsernameReceiver
            // 
            this.lbUsernameReceiver.BackColor = System.Drawing.Color.Transparent;
            this.lbUsernameReceiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameReceiver.Location = new System.Drawing.Point(90, 18);
            this.lbUsernameReceiver.Name = "lbUsernameReceiver";
            this.lbUsernameReceiver.Size = new System.Drawing.Size(85, 22);
            this.lbUsernameReceiver.TabIndex = 1;
            this.lbUsernameReceiver.Text = "Username";
            // 
            // pcReceiver
            // 
            this.pcReceiver.FillColor = System.Drawing.Color.Gainsboro;
            this.pcReceiver.ImageRotate = 0F;
            this.pcReceiver.Location = new System.Drawing.Point(9, 4);
            this.pcReceiver.Name = "pcReceiver";
            this.pcReceiver.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pcReceiver.Size = new System.Drawing.Size(64, 64);
            this.pcReceiver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcReceiver.TabIndex = 0;
            this.pcReceiver.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "smile.png");
            this.imageList1.Images.SetKeyName(1, "neutral.png");
            this.imageList1.Images.SetKeyName(2, "smiling.png");
            this.imageList1.Images.SetKeyName(3, "angry.png");
            this.imageList1.Images.SetKeyName(4, "emoji.png");
            this.imageList1.Images.SetKeyName(5, "love.png");
            this.imageList1.Images.SetKeyName(6, "sad_2.png");
            this.imageList1.Images.SetKeyName(7, "sad_cry.png");
            this.imageList1.Images.SetKeyName(8, "shocked.png");
            this.imageList1.Images.SetKeyName(9, "sad.png");
            this.imageList1.Images.SetKeyName(10, "close2.png");
            // 
            // chatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(829, 618);
            this.Controls.Add(this.pnChat);
            this.Controls.Add(this.pnImages);
            this.Controls.Add(this.pnReceiver);
            this.Controls.Add(this.pnEmotions);
            this.Controls.Add(this.pnType);
            this.Controls.Add(this.pnUsers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "chatForm";
            this.Text = "chatForm";
            this.Load += new System.EventHandler(this.chatForm_Load);
            this.pnImages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcCloseImagePanel)).EndInit();
            this.pnEmotions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcEmo10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcCloseEmoPanel)).EndInit();
            this.pnType.ResumeLayout(false);
            this.pnReceiver.ResumeLayout(false);
            this.pnReceiver.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcReceiver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnUsers;
        private System.Windows.Forms.Panel pnChat;
        private System.Windows.Forms.Panel pnEmotions;
        private System.Windows.Forms.PictureBox pcCloseEmoPanel;
        private System.Windows.Forms.PictureBox pcEmo10;
        private System.Windows.Forms.PictureBox pcEmo9;
        private System.Windows.Forms.PictureBox pcEmo8;
        private System.Windows.Forms.PictureBox pcEmo4;
        private System.Windows.Forms.PictureBox pcEmo7;
        private System.Windows.Forms.PictureBox pcEmo3;
        private System.Windows.Forms.PictureBox pcEmo6;
        private System.Windows.Forms.PictureBox pcEmo5;
        private System.Windows.Forms.PictureBox pcEmo2;
        private System.Windows.Forms.PictureBox pcEmo1;
        private System.Windows.Forms.Panel pnImages;
        private System.Windows.Forms.FlowLayoutPanel flPnChosenImages;
        private System.Windows.Forms.PictureBox pcCloseImagePanel;
        private Guna.UI2.WinForms.Guna2Panel pnType;
        private Guna.UI2.WinForms.Guna2ImageButton btnEmotions;
        private Guna.UI2.WinForms.Guna2ImageButton btnImage;
        private Guna.UI2.WinForms.Guna2TextBox txtChat;
        private Guna.UI2.WinForms.Guna2ImageButton btnSend;
        private Guna.UI2.WinForms.Guna2Panel pnReceiver;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbFullnameReceiver;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbUsernameReceiver;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pcReceiver;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList imageList1;
    }
}