using Microsoft.Reporting.Map.WebForms.BingMaps;
using shoppingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingApp.Forms
{
    public partial class profileForm : Form
    {
        public profileForm()
        {
            InitializeComponent();
        }

        public string username { get; set; }

        private sqlAdapter sql = new sqlAdapter();
        private common comm = new common();
        private message mess = new message();


        private bool passVisible = false;
        private User user;

        // Form load event
        private void profileForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        // Load data for controls
        private void loadData()
        {
            user = sql.getUserByUsername(username);

            pcAva.Image = comm.getImage(user.AvaUrl);
            txtUsername.Text = user.Username;
            txtFirstname.Text = user.Firstname;
            txtLastname.Text = user.Lastname;
            txtEmail.Text = user.Email;
            txtPassword.Text = user.Password;
            txtPhoneNum.Text = user.PhoneNum;
            if ((object)user.Address != DBNull.Value)
                txtAddress.Text = user.Address;

            if (!passVisible)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;

            ofd.FileName = string.Empty;
        }

        // Button show pass click event
        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (!passVisible)
            {
                passVisible = true;
                txtPassword.PasswordChar = '\0';
                txtPassword.UseSystemPasswordChar = false;
                btnShowPass.Image = Properties.Resources.invisible_30px;
            }
            else
            {
                passVisible = false;
                txtPassword.PasswordChar = '*';
                txtPassword.UseSystemPasswordChar = true;
                btnShowPass.Image = Properties.Resources.eye_30px;
            }
        }

        // Save button click event
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkValInfo())
            {
                string oldImage = user.AvaUrl;
                string newImage = "";


                if (ofd.FileName != string.Empty)
                {
                    newImage = getAvaImageUrl();

                    // Delete old image and create new image in bin\\Debug folder
                    if (File.Exists(oldImage))
                    {
                        File.Delete(oldImage);
                    }

                    File.Copy(ofd.FileName, newImage);
                    ofd.FileName = string.Empty;
                }

                if (sql.updateUserByUsername(txtUsername.Text, txtFirstname.Text, txtLastname.Text, txtPhoneNum.Text,
                   txtEmail.Text, txtPassword.Text, user.Role, newImage, txtAddress.Text))
                {
                    MessageBox.Show(mess.manaUsersMess1);

                    profileForm_Load(sender, e);
                    this.ParentForm.Activate();
                }
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

        // Check valid data
        private bool checkValInfo()
        {
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


            // Check empty value of password textbox
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                error.SetError(txtPassword, mess.logupMess10);
                return false;
            }
            else
                error.SetError(txtPassword, string.Empty);


            // Check empty value of email textbox
            if (string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                error.SetError(txtEmail, mess.logupMess8);
                return false;
            }
            else if (!comm.ValidateEmail(txtEmail.Text.Trim()))
            {
                error.SetError(txtEmail, mess.logupMess9);
                return false;
            }
            else if (sql.checkExistEmail(txtEmail.Text.Trim()) && txtEmail.Text.Trim() != user.Email)
            {
                error.SetError(txtEmail, mess.logupMess12);
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
            else if (!comm.IsPhoneNumber(txtPhoneNum.Text.Trim()))
            {
                error.SetError(txtPhoneNum, mess.logupMess7);
                return false;
            }
            else
                error.SetError(txtPhoneNum, string.Empty);
            
            // Check empty value of address textbox
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                error.SetError(txtAddress, mess.logupMess13);
                return false;
            }
            else
                error.SetError(txtAddress, string.Empty);


            return true;
        }

        // Picture box ava click event
        private void pcAva_Click(object sender, EventArgs e)
        {
            ofd.Filter = "select image(*.jpg; *.png; *.gif|*.jpg; *.png; *.gif)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcAva.Image = comm.getImage(ofd.FileName);
            }
        }
    }
}
