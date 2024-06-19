using Guna.UI2.WinForms;
using shoppingApp.Classes;
using shoppingApp.Forms;
using shoppingApp.Properties;
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

namespace shoppingApp
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }
        public User user {  get; set; }

        int togMove;
        int mValx;
        int mValy;

        bool productsExpanded = false;
        bool adminExpanded = false;
        bool sidebarExpanded = true;

        message mess = new message();
        sqlAdapter sql = new sqlAdapter();
        common comm = new common();

        // Child forms
        aboutForm aboutFrm;
        productForm prodsFrm;
        addProdsForm addProdsFrm;
        addCatesForm addCatesFrm;
        manageUsersForm manageUsersFrm;
        cartForm cartFrm;
        orderForm orderFrm;
        profileForm profileFrm;
        dealForm dealFrm;
        chatForm chatFrm;
        manageOrderForm manageOrderFrm;


        // Admin, Product and Sidebar timer tick events
        private void productsTransaction_Tick(object sender, EventArgs e)
        {
            if (!productsExpanded)
            {
                flPnProducts.Height += 5;
                pcChevron1.Image = Resources.chevron_under_30px;

                if (flPnProducts.Height >= 122)
                {
                    productsTransaction.Stop();
                    productsExpanded = true;
                }
            }
            else
            {
                flPnProducts.Height -= 5;
                pcChevron1.Image = Resources.chevron_right_30px;

                if (flPnProducts.Height <= 40)
                {
                    productsTransaction.Stop();
                    productsExpanded = false;
                }
            }
        }
        private void adminTransaction_Tick(object sender, EventArgs e)
        {
            if (!adminExpanded)
            {
                pcChevron2.Image = Resources.chevron_under_30px;

                if (flPnAdmin.Height >= 242)
                {
                    adminTransaction.Stop();
                    adminExpanded = true;
                }
                else
                    flPnAdmin.Height += 5;

            }
            else
            {
                pcChevron2.Image = Resources.chevron_right_30px;

                if (flPnAdmin.Height <= 40)
                {
                    adminTransaction.Stop();
                    adminExpanded = false;
                }
                else
                    flPnAdmin.Height -= 5;
            }
        }
        private void sidebarTransaction_Tick(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {

                if (sideBar.Width <= 50)
                {
                    sidebarExpanded = false;
                    sidebarTransaction.Stop();
                }
                else
                {
                    sideBar.Width -= 10;
                }
            }
            else
            {
                if (sideBar.Width >= 250)
                {
                    sidebarExpanded = true;
                    sidebarTransaction.Stop();
                }
                else
                {
                    sideBar.Width += 10;
                }
            }
        }

        // Button product click event
        private void bntProducts_Click(object sender, EventArgs e)
        {
            productsTransaction.Start();
        }

        // Button admin click event
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            adminTransaction.Start();
        }

        // Mouse Hover event
        private void bntParent_MouseHover(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Name == "btnProducts")
                pcChevron1.BackColor = Color.FromArgb(38, 38, 38);
            else
                pcChevron2.BackColor = Color.FromArgb(38, 38, 38);

        }

        private void bntParent_MouseLeave(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            if (btn.Name == "btnProducts")
                pcChevron1.BackColor = Color.Black;
            else
                pcChevron2.BackColor = Color.Black;

        }

        // Button nav bar click event
        private void btnNavbar_Click(object sender, EventArgs e)
        {
            sidebarTransaction.Start();
        }
        
        // Button exit click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(mess.mainMess1, "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        // Button logout click event
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();

            loginForm login = new loginForm();
            login.ShowDialog();
        }

        // Button product click events
        private void btnProds_Click(object sender, EventArgs e)
        {
            var btn = (Guna2Button)sender;
            bool sex;

            if(btn.Name == "btnForHim")
            {
                lbFlows.Text = "Products > For Him";
                sex = true;
            }
            else
            {
                lbFlows.Text = "Products > For Her";
                sex = false;
            }

            if (prodsFrm == null)
            {
                prodsFrm = new productForm();
                prodsFrm.male = sex;

                prodsFrm.parentForm = this;
                prodsFrm.FormClosed += ChildForm_FormClosed;
                prodsFrm.MdiParent = this;
                prodsFrm.Dock = DockStyle.Fill;
                prodsFrm.Show();
            }
            else
            {
                clearChildForm();
                btnProds_Click(sender, e);
            }
        }

        // Child form closed event
        private void ChildForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sender = null;
        }

        // Clear child from
        private void clearChildForm()
        {
            aboutFrm = null;
            prodsFrm = null;
            addProdsFrm = null;
            addCatesFrm = null;
            manageUsersFrm = null;
            cartFrm = null;
            orderFrm = null;
            profileFrm = null;
            dealFrm = null;
            chatFrm = null;
            manageOrderFrm = null;
        }

        // Button About us click event
        private void btnAboutUs_Click(object sender, EventArgs e)
        {
            if (aboutFrm == null)
            {
                lbFlows.Text = "About us";

                aboutFrm = new aboutForm();
                aboutFrm.FormClosed += ChildForm_FormClosed;
                aboutFrm.MdiParent = this;
                aboutFrm.Dock = DockStyle.Fill;
                aboutFrm.Show();
            }
            else
            {
                clearChildForm();
                btnAboutUs_Click(sender, e);
            }
        }

        // Button Insert products us click event
        private void btnInsertProds_Click(object sender, EventArgs e)
        {
            if (addProdsFrm == null)
            {
                lbFlows.Text = "Admin > Insert products";

                addProdsFrm = new addProdsForm();
                addProdsFrm.FormClosed += ChildForm_FormClosed;
                addProdsFrm.MdiParent = this;
                addProdsFrm.Dock = DockStyle.Fill;
                addProdsFrm.Show();
            }
            else
            {
                clearChildForm();
                btnInsertProds_Click(sender, e);
            }
        }

        // Button Insert categories us click event
        private void btnInsertCates_Click(object sender, EventArgs e)
        {
            if (addCatesFrm == null)
            {
                lbFlows.Text = "Admin > Insert categories";

                addCatesFrm = new addCatesForm();
                addCatesFrm.FormClosed += ChildForm_FormClosed;
                addCatesFrm.MdiParent = this;
                addCatesFrm.Dock = DockStyle.Fill;
                addCatesFrm.Show();
            }
            else
            {
                clearChildForm();
                btnInsertCates_Click(sender, e);
            }
        }

        // Button Manage users us click event
        private void btnManageUsers_Click(object sender, EventArgs e)
        {
            if (manageUsersFrm == null)
            {
                lbFlows.Text = "Admin > Manage users";

                manageUsersFrm = new manageUsersForm();
                manageUsersFrm.FormClosed += ChildForm_FormClosed;
                manageUsersFrm.MdiParent = this;
                manageUsersFrm.Dock = DockStyle.Fill;
                manageUsersFrm.Show();
            }
            else
            {
                clearChildForm();
                btnManageUsers_Click(sender, e);
            }
        }

        // Button Cart click event
        private void btnCart_Click(object sender, EventArgs e)
        {
            if (cartFrm == null)
            {
                lbFlows.Text = "Cart";

                cartFrm = new cartForm();
                cartFrm.FormClosed += ChildForm_FormClosed;
                cartFrm.MdiParent = this;
                cartFrm.Dock = DockStyle.Fill;

                cartFrm.parentForm = this;
                cartFrm.username = user.Username;

                cartFrm.Show();
            }
            else
            {
                clearChildForm();
                btnCart_Click(sender, e);
            }
        }

        // Button Your orders click event
        private void btnOrders_Click(object sender, EventArgs e)
        {
            if (orderFrm == null)
            {
                lbFlows.Text = "Your orders";

                orderFrm = new orderForm();
                orderFrm.FormClosed += ChildForm_FormClosed;
                orderFrm.MdiParent = this;
                orderFrm.Dock = DockStyle.Fill;

                orderFrm.parentForm = this;
                orderFrm.username = user.Username;

                orderFrm.Show();
            }
            else
            {
                clearChildForm();
                btnOrders_Click(sender, e);
            }
        }

        // Button Search click event
        private void btnHotDeal_Click(object sender, EventArgs e)
        {
            if (dealFrm == null)
            {
                lbFlows.Text = "Hot deals";

                dealFrm = new dealForm();
                dealFrm.FormClosed += ChildForm_FormClosed;
                dealFrm.MdiParent = this;
                dealFrm.Dock = DockStyle.Fill;

                dealFrm.parentForm = this;

                dealFrm.Show();
            }
            else
            {
                clearChildForm();
                btnHotDeal_Click(sender, e);
            }
        }

        // Button Profile click event
        private void btnProfile_Click(object sender, EventArgs e)
        {
            if (profileFrm == null)
            {
                lbFlows.Text = "Search";

                profileFrm = new profileForm();
                profileFrm.FormClosed += ChildForm_FormClosed;
                profileFrm.MdiParent = this;
                profileFrm.Dock = DockStyle.Fill;

                profileFrm.username = user.Username;

                profileFrm.Show();
            }
            else
            {
                clearChildForm();
                btnProfile_Click(sender, e);
            }
        }

        // Button Manage orders click event
        private void btnManageOrders_Click(object sender, EventArgs e)
        {
            if (manageOrderFrm == null)
            {
                lbFlows.Text = "Manage orders";

                manageOrderFrm = new manageOrderForm();
                manageOrderFrm.FormClosed += ChildForm_FormClosed;
                manageOrderFrm.MdiParent = this;
                manageOrderFrm.Dock = DockStyle.Fill;

                manageOrderFrm.parentForm = this;
                manageOrderFrm.username = user.Username;

                manageOrderFrm.Show();
            }
            else
            {
                clearChildForm();
                btnManageOrders_Click(sender, e);
            }
        }

        private void btnChat_Click(object sender, EventArgs e)
        {
            if (chatFrm == null)
            {
                lbFlows.Text = "Chat";

                chatFrm = new chatForm();
                chatFrm.FormClosed += ChildForm_FormClosed;
                chatFrm.MdiParent = this;
                chatFrm.Dock = DockStyle.Fill;

                chatFrm.parentForm = this;
                chatFrm.username = user.Username;

                chatFrm.Show();
            }
            else
            {
                clearChildForm();
                btnChat_Click(sender, e);
            }
        }

        // Form activated event
        private void mainForm_Activated(object sender, EventArgs e)
        {
            user = sql.getUserByUsername(user.Username);
            lbHelloMess.Text = $"Hi, {user.Lastname}";

            Image img;
            using (var stream = File.OpenRead(user.AvaUrl))
            {
                img = new Bitmap(stream);
            }
            pcAva.Image = img;
        }

        // Set flow text from child form
        public void setTxtFlows(string str)
        {
            lbFlows.Text = str;
        }

        // Set visual of buttons due to role
        private void setVisualBtns()
        {
            if (user.Role == "admin")
                return;
            else
            {
                this.Controls.Remove(flPnAdmin);
                flPnAdmin.Visible = false;
            }
        }

        // Form loadS event
        private void mainForm_Load(object sender, EventArgs e)
        {
            // Set interval time for timers
            sidebarTransaction.Interval = 10;
            productsTransaction.Interval = 10;
            adminTransaction.Interval = 10;

            lbHelloMess.Text = $"Hi, {user.Lastname}";

            pcAva.Image = comm.getImage(user.AvaUrl);

            setVisualBtns();

            btnHotDeal_Click(sender, e);
        }

        private void navBar_MouseDown(object sender, MouseEventArgs e)
        {
            togMove = 1;
            mValx = e.X;
            mValy = e.Y;
        }

        private void navBar_MouseUp(object sender, MouseEventArgs e)
        {
            togMove = 0;
        }

        private void navBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (togMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mValx, MousePosition.Y - mValy);
            }
        }
    }
}
