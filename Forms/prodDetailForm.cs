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
using static Guna.UI2.Native.WinApi;
using static System.Net.Mime.MediaTypeNames;
using TheArtOfDevHtmlRenderer.Adapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Guna.UI2.WinForms;
using shoppingApp.Properties;
using System.Security.Cryptography;
using shoppingApp.UserControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace shoppingApp.Forms
{

    public partial class prodDetailForm : Form
    {
        public prodDetailForm()
        {
            InitializeComponent();
        }

        public mainForm parentForm { get; set; }
        public int prodId { get; set; }

        sqlAdapter sql = new sqlAdapter();
        message mess = new message();
        common comm = new common();

        Product prod;
        int quantity;

        // Load data of product for controls
        private void loadData()
        {
            quantity = int.Parse(lbChoosenQuan.Text);

            prod = sql.getProductById(prodId);

            int priceWithDis;
            if (prod.Discount != 0)
                priceWithDis = prod.Price - (prod.Price * prod.Discount / 100);
            else
                priceWithDis = prod.Price;

            lbProdName.Text = prod.Name;
            lbPrice.Text = comm.splitMoneyStr(prod.Price.ToString());
            lbPriceWithDis.Text = comm.splitMoneyStr(priceWithDis.ToString());
            lbCate.Text = prod.Category;
            rchTxtDesc.Text = prod.Description.Replace("\n", "\n\n");

            setRatingControls();

            if (prod.Quantity < 10)
                lbQuantity.Text = $"Only {prod.Quantity} left";
            else
                lbQuantity.Text = "Still in stock";

            // Set deal time label
            if (prod.End_day != "")
            {
                TimeSpan timeSpan = DateTime.Parse(prod.End_day) - DateTime.Now;
                if (timeSpan.TotalHours > 24)
                {
                    if (timeSpan.TotalDays > 1)
                        lbEndDay.Text = $"Deal time: {(int)timeSpan.TotalDays} days left";
                    else
                        lbEndDay.Text = $"Deal time: {(int)timeSpan.TotalDays} day left";
                }
                else
                    if (timeSpan.TotalHours > 1)
                    lbEndDay.Text = $"Deal time: {(int)timeSpan.TotalHours} hour left";
                else
                    lbEndDay.Text = $"Deal time: {(int)timeSpan.TotalHours} hours left";
            }
            else
                lbEndDay.Visible = false;


            BindingSource bs = new BindingSource();
            bs.DataSource = prod.Size.Replace(" ", "").Split(',').ToList();
            cbSize.DataSource = bs;

            List<string> imagesUrl = prod.ImagesUrl.Split(',').ToList();

            pcMain.Image = comm.getImage(imagesUrl[0]);

            foreach (var image in imagesUrl)
            {
                PictureBox pc = new PictureBox();
                pc.Size = new Size(60, 60);
                pc.SizeMode = PictureBoxSizeMode.StretchImage;
                pc.Click += (s, e) =>
                {
                    var ima = s as PictureBox;

                    pcMain.Image = ima.Image;

                };

                System.Drawing.Image temp;
                using (var stream = File.OpenRead(image.Trim()))
                {
                    temp = new Bitmap(stream);
                }

                pc.Image = temp;

                flPnImages.Controls.Add(pc);
            }

        }

        // Form load event
        private void prodDetailForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        // Button add to cart click event
        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (!sql.checkExistCartItemByUsernameAndProdIdAndSize(parentForm.user.Username, prodId, cbSize.SelectedValue.ToString()))
            {
                sql.insertCartItem(parentForm.user.Username, prodId, 1, cbSize.SelectedValue.ToString());
            }
            else
            {
                sql.updateQuantityCartItemByUsernameAndProdIdAndSize(parentForm.user.Username, prodId, cbSize.SelectedValue.ToString(), true);
            }

            MessageBox.Show(mess.prodDetailMess1);
        }

        // Fill star fuction
        private void fillStarBtn(int length)
        {
            foreach (Control ctl in pnStar.Controls)
            {
                if (ctl is Guna2ImageButton)
                {
                    var btn = (Guna2ImageButton)ctl;

                    int index = Int32.Parse(btn.Tag.ToString());

                    if (index <= length)
                        btn.Image = Resources.star_filled_30px;
                    else
                        btn.Image = Resources.star_not_fill_30px;
                }

            }
        }

        // Button star click event
        private void btnStar_Click(object sender, EventArgs e)
        {
            if (!sql.checkExistReviewByUsernameAndProId(parentForm.user.Username, prodId))
            {
                var btn = (Guna2ImageButton)sender;

                int index = Int32.Parse(btn.Tag.ToString());

                switch (index)
                {
                    case 1:
                        fillStarBtn(1);
                        break;
                    case 2:
                        fillStarBtn(2);
                        break;
                    case 3:
                        fillStarBtn(3);
                        break;
                    case 4:
                        fillStarBtn(4);
                        break;
                    case 5:
                        fillStarBtn(5);
                        break;
                }

                if (sql.insertReview(parentForm.user.Username, prodId, index))
                    MessageBox.Show(mess.prodDetailMess4);

                setRatingControls();
            }
            else
                MessageBox.Show(mess.prodDetailMess3);

        }

        // Set value of rating controls
        private void setRatingControls()
        {
            fillStarBtn(sql.getRatingOfProductByProdID(prodId));

            int numReviews = sql.getNumOfRatingOfProductByProdId(prodId);
            if (numReviews < 2)
                lbNumOfReviews.Text = $"( {numReviews} review )";
            else
                lbNumOfReviews.Text = $"( {numReviews} reviews )";
        }

        // Button plus click event
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (quantity == 10)
            {
                MessageBox.Show(mess.ucCartItemMess1);
            }
            else
            {
                quantity += 1;
                lbChoosenQuan.Text = quantity.ToString();
            }
        }

        // Button minus click event
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (quantity == 1)
                return;
            else
            {
                quantity -= 1;
                lbChoosenQuan.Text = quantity.ToString();
            }
        }

        // Button buy now click event
        private void btnBuyNow_Click(object sender, EventArgs e)
        {
            string flow = "Transaction";
            parentForm.setTxtFlows(flow);

            ucCartItem item = new ucCartItem();
            item.ProdId = prod.Id;
            item.ProdName = prod.Name;
            item.ProdSize = cbSize.SelectedValue.ToString();
            item.ImageUrl = prod.ImagesUrl.ToString().Split(',').ToList()[0];
            item.Discount = prod.Discount;
            item.Price = prod.Price;
            item.Quantity = quantity;
            item.Transacting = true;

            transactionForm transFrm = new transactionForm();
            transFrm.parentForm = parentForm;
            transFrm.username = parentForm.user.Username;
            transFrm.transacting = false;
            transFrm.cartItem = item;

            transFrm.MdiParent = parentForm;
            transFrm.Dock = DockStyle.Fill;
            transFrm.Show();
        }
    }
}
