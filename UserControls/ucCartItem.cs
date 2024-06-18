using shoppingApp.Classes;
using shoppingApp.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingApp.UserControls
{
    public partial class ucCartItem : UserControl
    {
        public ucCartItem()
        {
            InitializeComponent();
        }

        public cartForm cartFrm { get; set; }

        private sqlAdapter sql = new sqlAdapter();
        private message mess = new message();
        private common comm = new common();

        private int proId;
        private string imageUrl;
        private string prodName;
        private string prodSize;
        private int discount;
        private int price;
        private int quantity;
        private bool transacting;

        public int ProdId
        {
            get { return proId; }
            set { proId = value; }
        }

        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; pcProdImage.Image = comm.getImage(imageUrl); }
        }

        public string ProdName
        {
            get { return prodName; }
            set { prodName = value; lbProdName.Text = prodName; }
        }
        public string ProdSize
        {
            get { return prodSize; }
            set { prodSize = value; lbSize.Text = "Size " + prodSize; }
        }
        public int Discount
        {
            get { return discount; }
            set { discount = value; }
        }

        public int Price
        {
            get { return price; }
            set { price = value; lbProdPrice.Text = comm.splitMoneyStr(setPrice().ToString()); }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; lbQuantity.Text = quantity.ToString(); setAmoutPrice(); }
        }

        public bool Transacting
        {
            get { return transacting; }
            set { transacting = value; setBtnVisual(transacting); }
        }

        public int getTotal()
        {
            return (price - (price * discount / 100)) * quantity;
        }

        private int setPrice()
        {
            int priceWithDis;
            if (discount != 0)
                priceWithDis = price - (price * discount / 100);
            else
                priceWithDis = price;

            return priceWithDis;
        }

        private void setAmoutPrice()
        {
            int amountPrice = setPrice() * quantity;
            lbAmountPrice.Text = comm.splitMoneyStr(amountPrice.ToString());
        }

        private void setBtnVisual(bool checkTransacting)
        {
            if (checkTransacting)
            {
                btnMinus.Visible = false;
                btnPlus.Visible = false;
                btnDelete.Visible = false;
            }
            else
            {
                btnMinus.Visible = true;
                btnPlus.Visible = true;
                btnDelete.Visible = true;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (quantity == 1)
            {
                DialogResult dialogResult = MessageBox.Show(mess.ucCartItemMess2, "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (sql.deleteCartItemByUsernameAndProIdAndSize(cartFrm.username, proId, prodSize))
                    {
                        cartFrm.cartForm_Load(cartFrm, e);
                        return;
                    }
                }
                else
                    return;
            }
            this.Quantity -= 1;
            sql.updateQuantityCartItemByUsernameAndProdIdAndSize(cartFrm.username, proId, prodSize, false);

            cartFrm.calToltal();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            // Can not choose over 10 items of this product
            if (quantity == 10)
            {
                MessageBox.Show(mess.ucCartItemMess1);
                return;
            }
            this.Quantity += 1;
            sql.updateQuantityCartItemByUsernameAndProdIdAndSize(cartFrm.username, proId, prodSize, true);

            cartFrm.calToltal();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show(mess.ucCartItemMess2, "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                if (sql.deleteCartItemByUsernameAndProIdAndSize(cartFrm.username, proId, prodSize))
                {
                    cartFrm.cartForm_Load(cartFrm, e);
                    return;
                }
            }
            else
                return;
        }

        private void lbQuantity_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
