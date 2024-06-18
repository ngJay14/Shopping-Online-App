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
    public partial class productForm : Form
    {
        public productForm()
        {
            InitializeComponent();
        }

        public mainForm parentForm { get; set; }
        public bool male {  get; set; }

        sqlAdapter sql = new sqlAdapter();

        // Form load event
        private void productForm_Load(object sender, EventArgs e)
        {
            filComboBox();
            setProdItems();
        }

        // Create Product item
        private ucProductMain createProdItem(int prodId, string imageUrl, string prodName, int discount, int price)
        {
            ucProductMain prod = new ucProductMain();
            prod.ProdId = prodId;
            prod.ImageUrl = imageUrl;
            prod.ProdName = prodName;
            prod.Discount = discount;
            prod.Price = price;

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

        // Set Product items
        private void setProdItems()
        {
            DataTable dt = sql.getProductsBySex(male);

            if (dt.Rows.Count > 0 ) 
            {
                flPnProds.Controls.Clear();

                foreach (DataRow dr in dt.Rows)
                {
                    List<string> imageList = dr["images_url"].ToString().Split(',').ToList();

                    ucProductMain prod = createProdItem((int)dr["id"], imageList[0].ToString(), 
                        dr["name"].ToString(), (int)dr["discount"], (int)dr["price"]);

                    flPnProds.Controls.Add(prod);
                }
            }
        }

        // Fill categories combo Box
        private void filComboBox()
        {
            try
            {
                sql = new sqlAdapter();
                DataTable dt = sql.getAllCategories();

                cbBoxCategories.DisplayMember = "name";
                cbBoxCategories.ValueMember = "id";
                cbBoxCategories.DataSource = dt;
                cbBoxCategories.SelectedIndex = -1;

                cbBoxCategories.SelectedValueChanged += cbBoxCategories_SelectedValueChanged;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Selected value changed event of combobox categories
        private void cbBoxCategories_SelectedValueChanged(object sender, EventArgs e)
        {
            flPnProds.Controls.Clear();

            DataTable dt = sql.getProductsBySexAndCateId(male, (int)cbBoxCategories.SelectedValue);

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

        // Key down event of texbox Search
        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtSearch.Text == string.Empty)
                {
                    setProdItems();
                }
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
