using shoppingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shoppingApp.Forms
{
    public partial class manageUsersForm : Form
    {
        public manageUsersForm()
        {
            InitializeComponent();
        }

        message mess = new message();
        common comm = new common();
        sqlAdapter sql = new sqlAdapter();

        string username = null;

        // Button Delete click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (username != null)
            {
                DialogResult dialogResult = MessageBox.Show(mess.manaUsersMess3, "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (sql.deleteUserByUsername(username))
                    {
                        MessageBox.Show(mess.manaUsersMess2);
                        manageUsers_Load(sender, e);
                    }
                }
            }
            else
                MessageBox.Show(mess.manaUsersMess4);
        }

        // Button Update click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkValInfo())
            {
                string oldImage = usersView.CurrentRow.Cells[5].Value.ToString();
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
                   txtEmail.Text, txtPassword.Text, cmBxRole.SelectedItem.ToString(), newImage))
                {
                    MessageBox.Show(mess.manaUsersMess1);

                    manageUsers_Load(sender, e);
                    this.ParentForm.Activate();
                }
            }            
        }

        // Button Clear click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCtrl();
        }

        // Clear data in control
        private void clearCtrl()
        {
            txtUsername.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            txtPhoneNum.Clear();
            cmBxRole.SelectedIndex = -1;
            pcAva.Image = null;

            username = null;
        }

        // Row header of datagridview click event
        private void categoriesView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            username = usersView.CurrentRow.Cells[0].Value.ToString();

            txtUsername.Text = usersView.CurrentRow.Cells[0].Value.ToString();
            txtFirstname.Text = usersView.CurrentRow.Cells[1].Value.ToString();
            txtLastname.Text = usersView.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = usersView.CurrentRow.Cells[3].Value.ToString();
            txtPhoneNum.Text = usersView.CurrentRow.Cells[4].Value.ToString();
            txtPassword.Text = usersView.CurrentRow.Cells[6].Value.ToString();

            if (string.Equals(usersView.CurrentRow.Cells[7].Value.ToString(), "admin"))
                cmBxRole.SelectedIndex = 1;
            else
                cmBxRole.SelectedIndex = 0;

            Image img;
            using (var stream = File.OpenRead(usersView.CurrentRow.Cells[5].Value.ToString()))
            {
                img = new Bitmap(stream);
            }
            pcAva.Image = img;

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

        // Check validated informations
        private bool checkValInfo()
        {
            // Check empty value of username textbox
            if (string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                MessageBox.Show(mess.manaUsersMess2);
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


            /// Check empty value of phone number textbox
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
            else
                error.SetError(txtEmail, string.Empty);


            // Check empty value of password textbox
            if (string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                error.SetError(txtPassword, mess.logupMess10);
                return false;
            }
            else
                error.SetError(txtPassword, string.Empty);

            if (cmBxRole.SelectedIndex == -1)
            {
                error.SetError(cmBxRole, mess.manaUsersMess5);
                return false;
            }
            else
                error.SetError(cmBxRole, string.Empty);


            // Check empty ava pic
            if (pcAva.Image == null)
            {
                MessageBox.Show(mess.logupMess1);
                return false;
            }


            return true;
        }

        // Picture box ava click event
        private void pcAva_Click(object sender, EventArgs e)
        {
            ofd.Filter = "select image(*.jpg; *.png; *.gif|*.jpg; *.png; *.gif)";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcAva.Image = Image.FromFile(ofd.FileName);
            }
        }

        // Form load event
        private void manageUsers_Load(object sender, EventArgs e)
        {
            clearCtrl();

            DataTable dt = sql.getAllUsers();

            usersView.DataSource = dt;
        }


    }
}
