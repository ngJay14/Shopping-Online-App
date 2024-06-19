using shoppingApp.Classes;
using shoppingApp.UserControls;
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
    public partial class manageOrderForm : Form
    {
        public manageOrderForm()
        {
            InitializeComponent();
        }

        public mainForm parentForm {  get; set; }
        public string username { get; set; }

        private message mess = new message();
        private common comm = new common();
        private sqlAdapter sql = new sqlAdapter();

        private int order_id = -1;

        // Form load event
        private void manageOrderForm_Load(object sender, EventArgs e)
        {
            clearCtrl();

            DataTable dt = sql.getAllOrders();

            usersView.DataSource = dt;
        }

        // Clear data in control
        private void clearCtrl()
        {
            txtUsername.Clear();
            txtDate.Clear();
            txtPhoneNum.Clear();
            txtTotal.Clear();
            txtShipAddress.Clear();
            rchTxtNote.Clear();
            cbBoxPayMethod.SelectedIndex = -1;
            cbBoxStatus.SelectedIndex = -1;

            flPnOrderItems.Controls.Clear();

            order_id = -1;
        }

        // Row header of datagridview click event
        private void usersView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            order_id = (int)usersView.CurrentRow.Cells[0].Value;

            txtUsername.Text = usersView.CurrentRow.Cells[1].Value.ToString();
            txtDate.Text = usersView.CurrentRow.Cells[2].Value.ToString();
            txtTotal.Text = usersView.CurrentRow.Cells[3].Value.ToString();
            txtShipAddress.Text = usersView.CurrentRow.Cells[5].Value.ToString();
            rchTxtNote.Text = usersView.CurrentRow.Cells[7].Value.ToString();

            User user = sql.getUserByUsername(txtUsername.Text);
            txtPhoneNum.Text = user.PhoneNum;

            cbBoxPayMethod.SelectedIndex = (int)usersView.CurrentRow.Cells[4].Value;
            cbBoxStatus.SelectedIndex = (int)usersView.CurrentRow.Cells[6].Value;


            // Set order items in flow layout panel
            DataTable dt = sql.getOrderItemsByOrderId(order_id);

            foreach (DataRow dr in dt.Rows)
            {
                ucCartItem item = new ucCartItem();

                item.ProdId = (int)dr["order_id"];
                item.ProdName = dr["name"].ToString();
                item.ProdSize = dr["size"].ToString();
                item.ImageUrl = dr["image_url"].ToString();
                item.Discount = int.Parse(dr["discount"].ToString());
                item.Price = int.Parse(dr["price"].ToString());
                item.Quantity = int.Parse(dr["quantity"].ToString());
                item.Transacting = true;

                flPnOrderItems.Controls.Add(item);
            }

            // Move to the first tab in tabcontrol
            tabControl1.SelectedIndex = 0;
        }

        // Button update click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (order_id == -1)
            {
                MessageBox.Show(mess.manaOrderMess2);
                return;
            }

            if (cbBoxStatus.SelectedIndex == -1)
            {
                MessageBox.Show(mess.manaOrderMess1);
                return;
            }

            if (sql.updateStatusOrderById(order_id, cbBoxStatus.SelectedIndex))
            {
                MessageBox.Show(mess.manaOrderMess3);
                manageOrderForm_Load(sender, e);
            }

        }

        // Button delete click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (order_id == -1)
            {
                MessageBox.Show(mess.manaOrderMess2);
                return;
            }

            if (sql.deleteOrderById(order_id))
            {
                MessageBox.Show(mess.manaOrderMess4);
                manageOrderForm_Load(sender, e);
            }
        }

        // Button clear click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCtrl();
        }
    }
}
