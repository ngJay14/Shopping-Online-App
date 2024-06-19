using shoppingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace shoppingApp.Forms
{
    public partial class loginForm : Form
    {
        public loginForm()
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

        // Link button log up click event
        private void lnkLbLogup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            logupForm logup = new logupForm();
            logup.ShowDialog();
        }

        // Link button forget password click event
        private void lnkLbForgetPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pnForgetPass.Visible = true;
            pnLogin.Visible = false;
        }

        // Button return click events
        private void pcReturn_Click(object sender, EventArgs e)
        {
            loginForm_Load(sender, e);
        }

        // Check validated informations
        private bool checkValInfo(bool login)
        {
            if (login)
            {
                // Check empty value of username textbox
                if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
                {
                    error.SetError(txtUsername, mess.logupMess4);
                    return false;
                }
                else
                    error.SetError(txtUsername, string.Empty);

                // Check empty value of password textbox
                if (string.IsNullOrEmpty(txtPass.Text.Trim()))
                {
                    error.SetError(txtPass, mess.logupMess10);
                    return false;
                }
                else
                    error.SetError(txtPass, string.Empty);
            }
            else
            {
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
            }

            return true;
        }

        // Check enter key pressed
        private void _enterPress(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }

        // Button log in click event
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!checkValInfo(true))
            {
                return;
            }

            User user = sql.getUserByUsername(txtUsername.Text.Trim());
            if (user != null && string.Equals(user.Password, txtPass.Text.Trim()))
            {
                if (string.Equals(user.Password, txtPass.Text.Trim()))
                {
                    this.Hide();

                    mainForm main = new mainForm();
                    main.user = user;
                    main.ShowDialog();
                }
            }
            else
                MessageBox.Show(mess.loginMess1);
        }

        // Button send click event
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!checkValInfo(false))
            {
                return;
            }
            else
            {
                if(sql.checkExistEmail(txtEmail.Text.Trim()))
                {
                    string pass = sql.getPasswordByEmail(txtEmail.Text.Trim());
                    com.sendEmail(txtEmail.Text.Trim(), mess.loginMess5, mess.loginMess4 + pass, null);
                    txtEmail.Clear();

                    MessageBox.Show(mess.loginMess2);
                }
                else
                {
                    MessageBox.Show(mess.loginMess3);
                    return;
                }
            }

            // Send password to email
            
        }

        // Form load event
        private void loginForm_Load(object sender, EventArgs e)
        {
            this.Controls.Add(pnForgetPass);
            pnForgetPass.Location = new Point(450, 40);

            pnLogin.Visible = true;
            pnForgetPass.Visible = false;

            // Set enter key down event for buttons
            txtUsername.KeyDown += new KeyEventHandler(_enterPress);
            txtPass.KeyDown += new KeyEventHandler(_enterPress);
            txtEmail.KeyDown += (object sen, KeyEventArgs ke) =>
            {
                if (ke.KeyCode == Keys.Enter)
                    btnSend_Click(sen, ke);
            };

            txtUsername.Clear();
            txtPass.Clear();
            txtUsername.Clear();
            error.Clear();
        }
    }
}
