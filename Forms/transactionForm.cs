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
    public partial class transactionForm : Form
    {
        public transactionForm()
        {
            InitializeComponent();
        }

        public mainForm parentForm { get; set; }
        public string username { get; set; }
        public int order_id { get; set; }
        public bool transacting { get; set; }
        public ucCartItem cartItem { get; set; }

        sqlAdapter sql = new sqlAdapter();
        common comm = new common();
        message mess = new message();

        // Clear controls
        private void clearControls()
        {
            flPnItems.Controls.Clear();
            lbTotal.Text = "0 đ";
        }

        // Load data
        private void loadData()
        {
            if(transacting && cartItem == null)
            {
                DataTable dt = sql.getCartItemByUsername(username);

                foreach (DataRow dr in dt.Rows)
                {
                    ucCartItem item = new ucCartItem();

                    List<string> listImages = dr["images_url"].ToString().Split(',').ToList();

                    item.ProdId = (int)dr["id"];
                    item.ProdName = dr["name"].ToString();
                    item.ProdSize = dr["size"].ToString();
                    item.ImageUrl = listImages[0];
                    item.Discount = int.Parse(dr["discount"].ToString());
                    item.Price = int.Parse(dr["price"].ToString());
                    item.Quantity = int.Parse(dr["quantity"].ToString());
                    item.Transacting = true;
                        
                    flPnItems.Controls.Add(item);
                }

                // Fill address of user
                User user = sql.getUserByUsername(username);
                txtAddress.Text = user.Address;
            }
            else if (!transacting && cartItem != null)
            {
                ucCartItem item = cartItem;

                flPnItems.Controls.Add(item);

                // Fill address of user
                User user = sql.getUserByUsername(username);
                txtAddress.Text = user.Address;

            }
            else
            {
                btnConDischarge.Visible = false;

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

                    flPnItems.Controls.Add(item);
                }

                txtAddress.Text = dt.Rows[0]["ship_address"].ToString();
                txtAddress.ReadOnly = true;

                txtPhoneNum.Text = dt.Rows[0]["phone"].ToString();
                txtPhoneNum.ReadOnly = true;

                rchTxtNote.Text = dt.Rows[0]["note"].ToString();
                rchTxtNote.ReadOnly = true;

                cbBoxPayMethod.SelectedIndex = (int)dt.Rows[0]["payment"];
                cbBoxPayMethod.Enabled = false;

            }

        }

        // Caculate total price
        public int calToltal()
        {
            int total = 0;

            foreach (ucCartItem item in flPnItems.Controls)
            {
                total += item.getTotal();
            }

            return total;
        }

        // Check validated informations
        private bool checkValInfo()
        {
            // Check empty value of ship address textbox
            if (string.IsNullOrEmpty(txtAddress.Text.Trim()))
            {
                error.SetError(txtAddress, mess.transactionMess2);
                return false;
            }
            else
                error.SetError(txtAddress, string.Empty);


            // Check empty value of phone number textbox
            if (string.IsNullOrEmpty(txtPhoneNum.Text.Trim()))
            {
                error.SetError(txtPhoneNum, mess.transactionMess3);
                return false;
            }
            else
                error.SetError(txtPhoneNum, string.Empty);


            return true;
        }

        // Form load event
        public void orderForm_Load(object sender, EventArgs e)
        {
            clearControls();
            loadData();
            lbTotal.Text = comm.splitMoneyStr(calToltal().ToString());
        }

        private void btnConDischarge_Click(object sender, EventArgs e)
        {
            if (checkValInfo())
            {
                bool check = sql.insertOrder(username, DateTime.Now, calToltal(), cbBoxPayMethod.SelectedIndex, txtAddress.Text, rchTxtNote.Text);
                if (check)
                {
                    foreach (ucCartItem item in flPnItems.Controls)
                    {
                        if (!sql.insertOrderItem(sql.getOrderIdOrderByDesc(), item.ProdId, item.Quantity, item.ImageUrl, item.ProdSize))
                        {
                            MessageBox.Show(mess.transactionMess1);
                            return;
                        }
                    }

                    sql.deleteAllCartItemsById(username);
                }
                else
                {
                    MessageBox.Show(mess.transactionMess1);
                    return;
                }

                string flow = "Invoice";
                parentForm.setTxtFlows(flow);

                invoiceForm invoiceFrm = new invoiceForm();
                invoiceFrm.username = username;
                invoiceFrm.order_id = sql.getOrderIdOrderByDesc();

                invoiceFrm.MdiParent = parentForm;
                invoiceFrm.Dock = DockStyle.Fill;
                invoiceFrm.Show();
            }
        }
    }
}
