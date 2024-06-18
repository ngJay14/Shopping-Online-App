using shoppingApp.Classes;
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
    public partial class ucOrder : UserControl
    {
        public ucOrder()
        {
            InitializeComponent();
        }

        common comm = new common();

        // Order
        private int orderId;
        private string shipAddress;
        private int payment;
        private int total;
        private DateTime date;

        public int OrderId
        {
            get { return  orderId; }
            set { orderId = value; }
        }

        public string ShipAddress
        {
            get { return shipAddress; }
            set { shipAddress = value; lbAddress.Text = shipAddress; }
        }

        public int Payment
        {
            get { return payment; }
            set {  payment = value; lbPayment.Text = comm.getPayment(payment); }
        }

        public int Total
        {
            get { return total; }
            set { total = value; lbTotal.Text = comm.splitMoneyStr(total.ToString()); }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; lbDate.Text = date.ToString(); }
        }

        // Product
        private int proId;
        private string imageUrl;
        private string prodName;
        private string prodSize;
        private int discount;
        private int price;
        private int quantity;

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
            set { quantity = value; lbQuantity.Text = "X" + quantity.ToString(); }
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

        public event EventHandler AddEventInfoBtnClick
        {
            add { btnInfo.Click += value; }
            remove { btnInfo.Click -= value; }
        }
    }
}
