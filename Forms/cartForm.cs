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
    public partial class cartForm : Form
    {
        public cartForm()
        {
            InitializeComponent();
        }

        public mainForm parentForm { get; set; }
        public string username {  get; set; }

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
            DataTable dt = sql.getCartItemByUsername(username);

            if (dt != null )
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ucCartItem item = new ucCartItem();

                    List<string> listImahges = dr["images_url"].ToString().Split(',').ToList();

                    item.cartFrm = this;
                    item.ProdId = (int) dr["id"];
                    item.ProdName = dr["name"].ToString();
                    item.ProdSize = dr["size"].ToString();
                    item.ImageUrl = listImahges[0];
                    item.Discount = int.Parse(dr["discount"].ToString());
                    item.Price = int.Parse(dr["price"].ToString());
                    item.Quantity = int.Parse(dr["quantity"].ToString());
                    item.Transacting = false;

                    flPnItems.Controls.Add(item);
                }

            }
            else
            {
                this.Controls.Add(lbEmptyCart);
                lbEmptyCart.Location = new System.Drawing.Point(337, 222);
                lbEmptyCart.Visible = true;
                lbEmptyCart.BringToFront();

                return;
            }
        }

        // Caculate total price
        public void calToltal()
        {
            int total = 0;

            foreach (ucCartItem item in flPnItems.Controls)
            {
                total += item.getTotal();
            }

            lbTotal.Text = comm.splitMoneyStr(total.ToString());
        }

        // Button discharge click event
        private void btnDischarge_Click(object sender, EventArgs e)
        {
            if (flPnItems.Controls.Count > 0)
            {
                string flow = "Transaction";
                parentForm.setTxtFlows(flow);

                transactionForm transFrm = new transactionForm();
                transFrm.parentForm = parentForm;
                transFrm.username = username;
                transFrm.transacting = true;
                transFrm.cartItem = null;

                transFrm.MdiParent = parentForm;
                transFrm.Dock = DockStyle.Fill;
                transFrm.Show();
            }
            else
                MessageBox.Show(mess.cartMess1);
        }

        // Form load event
        public void cartForm_Load(object sender, EventArgs e)
        {
            clearControls();
            loadData();
            calToltal();
        }
    }
}
