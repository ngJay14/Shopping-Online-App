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
    public partial class searchForm : Form
    {
        public searchForm()
        {
            InitializeComponent();
        }

        public mainForm parentForm { get; set; }
        public bool male { get; set; }

        sqlAdapter sql = new sqlAdapter();

        // Create Product item
        private ucProductMain createProdItem(int prodId, string imageUrl, string prodName, int discount, int price)
        {
            ucProductMain prod = new ucProductMain();
            prod.ProdId = prodId;
            prod.ImageUrl = imageUrl;
            prod.ProdName = prodName;
            prod.Discount = discount;
            prod.Price = price;

            bool male = sql.getProductSexById(prod.ProdId);

            prod.Click += (sender, e) =>
            {
                if (male)
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

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if(txtSearch.Text == string.Empty)
                    return;
                else
                {
                    flPnProds.Controls.Clear();

                    DataTable dt = sql.findProductsByNameAndSex(txtSearch.Text, male);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow dr in dt.Rows)
                        {
                            List<string> imageList = dr["images_url"].ToString().Split(',').ToList();

                            ucProductMain prod = createProdItem((int)dr["id"], imageList[0].ToString(),
                                dr["name"].ToString(), (int)dr["discount"], (int)dr["price"]);

                            flPnProds.Controls.Add(prod);
                        }
                    }
                }
            }

        }
    }
}
