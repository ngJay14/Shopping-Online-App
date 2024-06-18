using shoppingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shoppingApp.Forms
{
    public partial class logupForm : Form
    {
        public logupForm()
        {
            InitializeComponent();
        }

        common com = new common();
        message mess = new message();
        sqlAdapter sql = new sqlAdapter();

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Link button log in click event
        private void lnkLbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            loginForm login = new loginForm();
            login.Show();
        }

        // Check validated informations
        private bool checkValInfo()
        {
            // Check empty value of ava picture
            if (pcAva.Image == null)
            {
                MessageBox.Show(mess.logupMess1);
                return false;
            }


            // Check empty value of firstname textbox
            if (string.IsNullOrEmpty(txtFirstname.Text.Trim()))
            {
                error.SetError(txtFirstname, mess.logupMess2);
                return false;
            }
            else
                error.SetError(txtFirstname, string.Empty);


            // Check empty value of lastname textbox
            if (string.IsNullOrEmpty(txtLastname.Text.Trim()))
            {
                error.SetError(txtLastname, mess.logupMess3);
                return false;
            }
            else
                error.SetError(txtLastname, string.Empty);


            // Check empty value of username textbox
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                error.SetError(txtUsername, mess.logupMess4);
                return false;
            }
            else if (sql.getUserByUsername(txtUsername.Text.Trim()) != null)
            {
                error.SetError(txtUsername, mess.logupMess5);
                return false;
            }
            else
                error.SetError(txtUsername, string.Empty);


            // Check empty value of email textbox
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                error.SetError(txtEmail, mess.logupMess8);
                return false;
            }
            else if (!com.ValidateEmail(txtEmail.Text.Trim()))
            {
                error.SetError(txtEmail, mess.logupMess9);
                return false;
            }
            else
                error.SetError(txtEmail, string.Empty);


            // Check empty value of phone number textbox
            if (string.IsNullOrEmpty(txtPhoneNum.Text.Trim()))
            {
                error.SetError(txtPhoneNum, mess.logupMess6);
                return false;
            }
            else if (!com.IsPhoneNumber(txtPhoneNum.Text.Trim()))
            {
                error.SetError(txtPhoneNum, mess.logupMess7);
                return false;
            }
            else
                error.SetError(txtPhoneNum, string.Empty);



            // Check empty value of password textbox
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                error.SetError(txtPass, mess.logupMess10);
                return false;
            }
            else
                error.SetError(txtPass, string.Empty);

            return true;
        }

        // Check enter key pressed
        private void _enterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogup_Click(sender, e);
        }

        // Button log up click event
        private void btnLogup_Click(object sender, EventArgs e)
        {
            if (!checkValInfo())
            {
                return;
            }

            string imageDir = getAvaImageUrl();

            if (sql.insertUser(txtUsername.Text.Trim(), txtFirstname.Text.Trim(), txtLastname.Text.Trim(),
                txtPhoneNum.Text.Trim(), txtEmail.Text.Trim(), txtPass.Text.Trim(), imageDir, "user"))
            {
                File.Copy(ofd.FileName, imageDir);
                MessageBox.Show("insert ok");
            }
            else
                MessageBox.Show(mess.logupMess5);
        }

        // PictureBox Ava click event
        private void pcAva_Click(object sender, EventArgs e)
        {
            ofd.Filter = "select image(*.jpg; *.png; *.gif|*.jpg; *.png; *.gif)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcAva.Image = Image.FromFile(ofd.FileName);
            }
        }

        // Get image url to save image in bin\\Debug folder of solution
        private string getAvaImageUrl()
        {
            string extension = Path.GetExtension(ofd.FileName);

            var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
            var imageDirRel = $"user_images\\ava_{txtUsername.Text.Trim()}{extension}";
            var imageDirAbs = Path.Combine(assemblyParentPath, imageDirRel);

            return imageDirRel;
        }

        // Form load event
        private void logupForm_Load(object sender, EventArgs e)
        {
            // Set enter key down event for buttons
            txtFirstname.KeyDown += new KeyEventHandler(_enterPress);
            txtLastname.KeyDown += new KeyEventHandler(_enterPress);
            txtUsername.KeyDown += new KeyEventHandler(_enterPress);
            txtEmail.KeyDown += new KeyEventHandler(_enterPress);
            txtPhoneNum.KeyDown += new KeyEventHandler(_enterPress);
            txtPass.KeyDown += new KeyEventHandler(_enterPress);
        }
    }
}
