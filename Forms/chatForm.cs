using Microsoft.ReportingServices.Interfaces;
using shoppingApp.Classes;
using shoppingApp.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace shoppingApp.Forms
{
    public partial class chatForm : Form
    {
        public chatForm()
        {
            InitializeComponent();
        }

        public mainForm parentForm { get; set; }
        public string username { get; set; }

        sqlAdapter sql = new sqlAdapter();
        common comm = new common();

        int preY_ctrlMessage = 0;

        // Form load event
        private void chatForm_Load(object sender, EventArgs e)
        {
            usersItem();
            loadEmoImages();

            // Set event fro pc emotions
            pcEmo1.Click += new EventHandler(this.btnSend_Click);
            pcEmo2.Click += new EventHandler(this.btnSend_Click);
            pcEmo3.Click += new EventHandler(this.btnSend_Click);
            pcEmo4.Click += new EventHandler(this.btnSend_Click);
            pcEmo5.Click += new EventHandler(this.btnSend_Click);
            pcEmo6.Click += new EventHandler(this.btnSend_Click);
            pcEmo7.Click += new EventHandler(this.btnSend_Click);
            pcEmo8.Click += new EventHandler(this.btnSend_Click);
            pcEmo9.Click += new EventHandler(this.btnSend_Click);
            pcEmo10.Click += new EventHandler(this.btnSend_Click);

            // Set interval time for timers
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void addMessageItems(DataRow row)
        {
            int padding = 20;

            DateTime time = (DateTime)row["time"];

            // If message is text value
            if (row["message"] != DBNull.Value && row["icon"] == DBNull.Value && row["image"] == DBNull.Value)
            {
                if (username == row["sender"].ToString() && lbUsernameReceiver.Text == row["receiver"].ToString())
                {
                    ucMessTextSen txtSen = new ucMessTextSen();
                    //txtSen.Message = row["message"].ToString().Replace("\r\n", "<br />");
                    txtSen.Message = row["message"].ToString();
                    txtSen.Time = time.ToString("HH:mm:ss dd/MM/yyyy");

                    pnChat.Controls.Add(txtSen);
                    pnChat.ScrollControlIntoView(txtSen);

                    txtSen.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

                    txtSen.Location = new Point((pnChat.Width - txtSen.Width - padding), preY_ctrlMessage);

                    preY_ctrlMessage += txtSen.Height;
                }
                else if (username == row["receiver"].ToString() && lbUsernameReceiver.Text == row["sender"].ToString())
                {
                    ucMessTextRec txtRec = new ucMessTextRec();
                    txtRec.Ava = pcReceiver.Image;
                    //txtRec.Message = row["Message"].ToString().Replace("\r\n", "<br
                    txtRec.Message = row["Message"].ToString();
                    txtRec.Time = time.ToString("HH:mm:ss dd/MM/yyyy");

                    pnChat.Controls.Add(txtRec);
                    pnChat.ScrollControlIntoView(txtRec);

                    txtRec.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

                    txtRec.Location = new Point(5, preY_ctrlMessage);

                    preY_ctrlMessage += txtRec.Height;
                }
            }
            // If message is icon value
            else if (row["icon"] != DBNull.Value && row["image"] == DBNull.Value && row["message"] == DBNull.Value)
            {
                if (username == row["sender"].ToString() && lbUsernameReceiver.Text == row["receiver"].ToString())
                {
                    ucMessIconSen iconSen = new ucMessIconSen();
                    iconSen.Icon = imageList1.Images[int.Parse(row["icon"].ToString())];
                    iconSen.Time = time.ToString("HH:mm:ss dd/MM/yyyy");

                    pnChat.Controls.Add(iconSen);
                    pnChat.ScrollControlIntoView(iconSen);

                    iconSen.Anchor = (AnchorStyles.Top | AnchorStyles.Right);


                    iconSen.Location = new Point((pnChat.Width - iconSen.Width - padding), preY_ctrlMessage);

                    preY_ctrlMessage += iconSen.Height;
                }
                else if (username == row["receiver"].ToString() && lbUsernameReceiver.Text == row["sender"].ToString())
                {
                    ucMessIconRec iconRec = new ucMessIconRec();
                    iconRec.Ava = pcReceiver.Image;
                    iconRec.Icon = imageList1.Images[int.Parse(row["icon"].ToString())];
                    iconRec.Time = time.ToString("HH:mm:ss dd/MM/yyyy");

                    pnChat.Controls.Add(iconRec);
                    pnChat.ScrollControlIntoView(iconRec);

                    iconRec.Anchor = (AnchorStyles.Top | AnchorStyles.Left);


                    iconRec.Location = new Point(5, preY_ctrlMessage);

                    preY_ctrlMessage += iconRec.Height;
                }
            }
            // If message is image value
            else if (row["image"] != DBNull.Value && row["message"] == DBNull.Value && row["icon"] == DBNull.Value)
            {
                if (username == row["sender"].ToString() && lbUsernameReceiver.Text == row["receiver"].ToString())
                {
                    ucMessImageSen imageSen = new ucMessImageSen();
                    imageSen.Image = comm.getImage(row["image"].ToString());
                    imageSen.Time = time.ToString("HH:mm:ss dd/MM/yyyy");

                    pnChat.Controls.Add(imageSen);
                    pnChat.ScrollControlIntoView(imageSen);

                    imageSen.Anchor = (AnchorStyles.Top | AnchorStyles.Right);

                    imageSen.Location = new Point((pnChat.Width - imageSen.Width - padding), preY_ctrlMessage);

                    preY_ctrlMessage += imageSen.Height;
                }
                else if (username == row["receiver"].ToString() && lbUsernameReceiver.Text == row["sender"].ToString())
                {
                    ucMessImageRec imageRec = new ucMessImageRec();
                    imageRec.Ava = pcReceiver.Image;
                    imageRec.Image = comm.getImage(row["image"].ToString());
                    imageRec.Time = time.ToString("HH:mm:ss dd/MM/yyyy");

                    pnChat.Controls.Add(imageRec);
                    pnChat.ScrollControlIntoView(imageRec);

                    imageRec.Anchor = (AnchorStyles.Top | AnchorStyles.Left);

                    imageRec.Location = new Point(5, preY_ctrlMessage);

                    preY_ctrlMessage += imageRec.Height;
                }
            }
        }

        // Show message in chat panel
        private void messageChat()
        {
            pnChat.Focus();

            preY_ctrlMessage = 0;
            sql.updateSeenOfMessageByUsernameAndSeen(username, true);

            DataTable dt = sql.getMessByUsernameOrderByDateAsc(username);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    addMessageItems(row);
                }
            }

            pnChat.Refresh();
            pnChat.VerticalScroll.Value = pnChat.VerticalScroll.Maximum;



            preY_ctrlMessage = getLocationOfLastControl();


        }

        // List user in database into user panel
        private void usersItem()
        {
            pnUsers.Controls.Clear();

            DataTable dt;

            if (parentForm.user.Role == "admin")
                dt = sql.getUsersByRole("user");
            else
                dt = sql.getUsersByRole("admin");


            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    ucUserItem user = new ucUserItem();

                    user.Ava = row["ava"].ToString();
                    user.Username = row["username"].ToString();
                    user.Fullname = $"{row["first_name"]} {row["last_name"]}";
                    user.Color = Color.Gray;

                    user.Click += (sender, e) =>
                    {
                        pcReceiver.Image = comm.getImage(user.Ava);
                        lbUsernameReceiver.Text = user.Username;
                        lbFullnameReceiver.Text = user.Fullname;

                        setControls();
                        messageChat();
                    };
                    pnUsers.Controls.Add(user);

                }
            }
        }

        // Get Y of the last control in panel chaet
        private int getLocationOfLastControl()
        {
            int i = 0;

            foreach (Control c in pnChat.Controls)
            {
                i++;

                if (i == pnChat.Controls.Count)
                    return c.Location.Y + c.Height;
            }

            return 0;
        }

        // Set controls for this form
        private void setControls()
        {
            flPnChosenImages.Controls.Clear();

            pnImages.Visible = false;
            pnEmotions.Visible = false;
            pnChat.Visible = true;
            pnUsers.Visible = true;

            pnChat.Controls.Clear();

            txtChat.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txtChat.Text != string.Empty && pcReceiver.Image != null && flPnChosenImages.Controls.Count == 0)
            {
                if (sql.insertMessage(username, lbUsernameReceiver.Text, txtChat.Text, null, null, DateTime.Now, false))
                {
                    //sql.updateSeenOfMessageByUsernameAndSeen(username, true);

                    DataTable dt = sql.getMessByUsernameOrderByDateDesc(username);

                    if (dt.Rows.Count > 0)
                        addMessageItems(dt.Rows[0]);
                }

                txtChat.Clear();
                pnChat.VerticalScroll.Value = pnChat.VerticalScroll.Maximum;
                pnChat.Refresh();
                preY_ctrlMessage = getLocationOfLastControl();

            }
            else if (flPnChosenImages.Controls.Count == 0 && txtChat.Text == string.Empty && pnEmotions.Visible == true)
            {
                PictureBox icon = (PictureBox)sender;

                if (sql.insertMessage(username, lbUsernameReceiver.Text, null, icon.Tag.ToString(), null, DateTime.Now, false))
                {
                    //sql.updateSeenOfMessageByUsernameAndSeen(username, true);

                    DataTable dt = sql.getMessByUsernameOrderByDateDesc(username);

                    if (dt.Rows.Count > 0)
                        addMessageItems(dt.Rows[0]);
                }

                pnEmotions.Visible = false;
                pnChat.VerticalScroll.Value = pnChat.VerticalScroll.Maximum;
                pnChat.Refresh();
                preY_ctrlMessage = getLocationOfLastControl();
            }
            else if (flPnChosenImages.Controls.Count > 0 && txtChat.Text == "" && pnEmotions.Visible == false)
            {
                foreach (string path in openFileDialog1.FileNames)
                {
                    if (sql.insertMessage(username, lbUsernameReceiver.Text, null, null, path, DateTime.Now, false))
                    {
                        //sql.updateSeenOfMessageByUsernameAndSeen(username, true);

                        DataTable dt = sql.getMessByUsernameOrderByDateDesc(username);

                        if (dt.Rows.Count > 0)
                            addMessageItems(dt.Rows[0]);
                    }
                }

                flPnChosenImages.Controls.Clear();
                pnImages.Visible = false;
                pnChat.VerticalScroll.Value = pnChat.VerticalScroll.Maximum;
                pnChat.Refresh();
                preY_ctrlMessage = getLocationOfLastControl();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DataTable dt;

            dt = sql.getMessBySenderAndSeenOrderByDateAsc(lbUsernameReceiver.Text, false);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    if (row["sender"].ToString() == username)
                        return;
                    addMessageItems(row);
                    pnChat.VerticalScroll.Value = pnChat.VerticalScroll.Maximum;
                    pnChat.Refresh();
                    preY_ctrlMessage = getLocationOfLastControl();
                }

                sql.updateSeenOfMessageByUsernameAndSeen(username, true);
            }
        }

        private void btnEmotions_Click(object sender, EventArgs e)
        {
            if (pcReceiver.Image != null)
            {
                pnEmotions.Visible = true;
                pnEmotions.BringToFront();
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            if (pcReceiver.Image != null)
            {
                pnImages.Controls.Add(flPnChosenImages);
                flPnChosenImages.Location = new Point(3, 3);
                pnImages.Controls.Add(pcCloseImagePanel);

                openFileDialog1.Filter = "Select image(*.jpg; *.png; *.gif)|*.jpg; *.png; *.gif";
                openFileDialog1.Multiselect = true;


                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    foreach (String filePath in openFileDialog1.FileNames)
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Size = new Size(60, 60);
                        pictureBox.Image = comm.getImage(filePath);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                        flPnChosenImages.Controls.Add(pictureBox);
                    }

                    pnImages.Visible = true;

                    pnImages.BringToFront();
                    pnImages.Focus();
                }
                else
                {
                    pnImages.Visible = false;
                }
            }
        }

        private void loadEmoImages()
        {
            int i = 0;
            foreach (PictureBox pb in pnEmotions.Controls)
            {
                pb.Image = imageList1.Images[i];
                pb.Tag = i;
                i++;
            }
        }

        private void pcCloseImagePanel_Click(object sender, EventArgs e)
        {
            pnImages.Visible = false;
        }

        private void pcCloseEmoPanel_Click(object sender, EventArgs e)
        {
            pnEmotions.Visible = false;
        }
    }
}
