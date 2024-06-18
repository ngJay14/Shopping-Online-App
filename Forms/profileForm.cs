using Microsoft.Reporting.Map.WebForms.BingMaps;
using shoppingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        common comm = new common();

        private bool passVisible = false;
        private User user;

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
            txtAddress.Text = user.Address;

            if (!passVisible)
                txtPassword.UseSystemPasswordChar = true;
            else
                txtPassword.UseSystemPasswordChar = false;

        }

        private void profileForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            if (!passVisible)
            {
                passVisible = true;
                txtPassword.UseSystemPasswordChar = true;
                btnShowPass.Image = Properties.Resources.eye_30px;
            }
            else
            {
                passVisible = false;
                txtPassword.UseSystemPasswordChar = false;
                btnShowPass.Image = Properties.Resources.invisible_30px;
            }

            txtPassword.Text = user.Password;
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtLastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
