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
    public partial class dealForm : Form
    {
        public dealForm()
        {
            InitializeComponent();
        }

        public mainForm parentForm { get; set; }

        sqlAdapter sql = new sqlAdapter();


        private ucProductMain createProdItem(int prodId, string imageUrl, string prodName, int discount, int price, bool sex)
        {
            ucProductMain prod = new ucProductMain();
            prod.ProdId = prodId;
            prod.ImageUrl = imageUrl;
            prod.ProdName = prodName;
            prod.Discount = discount;
            prod.Price = price;
            prod.Sex = sex;

            prod.Click += (sender, e) =>
            {
                if (prod.Sex)
                {
                    string flow = $"Products > For Him > {prod.ProdName}";
                    parentForm.setTxtFlows(flow);
                }
                else
                {
                    string flow = $"Products > For Her > {prod.ProdName}";
                    parentForm.setTxtFlows(flow);
                }


                prodDetailForm prodDetail = new prodDetailForm();
                prodDetail.parentForm = parentForm;
                prodDetail.prodId = prod.ProdId;

                prodDetail.MdiParent = parentForm;
                prodDetail.Dock = DockStyle.Fill;
                prodDetail.Show();
            };

            return prod;
        }

        private void loadData()
        {
            DataTable dt = sql.getAllDiscountProduct();

            if (dt.Rows.Count > 0)
            {
                flPnProds.Controls.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    List<string> imageList = dr["images_url"].ToString().Split(',').ToList();

                    ucProductMain prod = createProdItem((int)dr["id"], imageList[0].ToString(),
                        dr["name"].ToString(), (int)dr["discount"], (int)dr["price"], (bool)dr["sex"]);

                    flPnProds.Controls.Add(prod);
                }
            }
        }

        private void dealForm_Load(object sender, EventArgs e)
        {
            loadData();
        }
    }
}
