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
    public partial class orderForm : Form
    {
        public orderForm()
        {
            InitializeComponent();
        }

        sqlAdapter sql = new sqlAdapter();

        public string username { get; set; }
        public mainForm parentForm { get; set; }

        public void loadData()
        {
            DataTable dt = sql.getAllOrdersByUsername(username);

            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    ucOrder order = new ucOrder();
                    order.OrderId = (int)dr["id"];
                    order.ShipAddress = dr["ship_address"].ToString();
                    order.Payment = (int)dr["payment"];
                    order.Total = (int)dr["total"];
                    order.Date = (DateTime)dr["date"];
                    order.Status = (int)dr["status"];
                    order.AddEventInfoBtnClick += (sender, e) =>
                        {
                            string flow = "Your orders > Order details";
                            parentForm.setTxtFlows(flow);

                            transactionForm orderDetailFrm = new transactionForm();
                            orderDetailFrm.username = username;
                            orderDetailFrm.order_id = order.OrderId;
                            orderDetailFrm.transacting = false;

                            orderDetailFrm.MdiParent = parentForm;
                            orderDetailFrm.Dock = DockStyle.Fill;
                            orderDetailFrm.Show();
                        };

                    DataTable orderItems = sql.getOrderItemsByOrderId(order.OrderId);

                    if (orderItems.Rows.Count > 0)
                    {
                        foreach(DataRow orItem in orderItems.Rows)
                        {
                            order.ImageUrl = orItem["image_url"].ToString();
                            order.ProdName = orItem["name"].ToString();
                            order.ProdSize = orItem["size"].ToString();
                            order.Quantity = (int)orItem["quantity"];
                            order.Price = (int)orItem["price"] * (100 - (int)orItem["discount"]) / 100;

                            break;
                        }
                    }

                    flPnOrders.Controls.Add(order);
                }
            }
            else
            {
                this.Controls.Add(lbEmptyOrder);
                lbEmptyOrder.Location = new Point(308, 265);
                lbEmptyOrder.Visible = true;
                lbEmptyOrder.BringToFront();
            }
        }

        // Form load event
        private void orderForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
