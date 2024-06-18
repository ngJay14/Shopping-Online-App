﻿using shoppingApp.Classes;
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
    public partial class ucProductMain : UserControl
    {
        public ucProductMain()
        {
            InitializeComponent();
        }

        common comm = new common();

        private int prodId;
        private string imageUrl;
        private string prodName;
        private int discount;
        private int price;
        private bool sex;

        public int ProdId
        {
            get { return prodId; }
            set { prodId = value; }
        }
        public string ImageUrl
        {
            get { return imageUrl; }
            set { imageUrl = value; pcProdImage.Image = Image.FromFile(imageUrl); }
        }
        public string ProdName
        {
            get { return prodName; }
            set { prodName = value; lbProdName.Text = prodName; }
        }
        public int Discount
        {
            get { return discount; }
            set { discount = value; setDeal(); }
        }
        public int Price
        {
            get { return price; }
            set { price = value; lbPrice.Text = comm.splitMoneyStr(setPrice().ToString()); }
        }
        public bool Sex
        {
            get { return sex; }
            set { sex = value; }
        }

        private int setPrice()
        {
            int priceWithDis;
            if (discount != 0)
            {
                priceWithDis = price - (price * discount / 100);

                lbDisPrice.Visible = true;
                lbDisPrice.Text = comm.splitMoneyStr(price.ToString());
            }
            else
            {
                priceWithDis = price;
                lbDisPrice.Visible = false;
            }

            return priceWithDis;
        }

        private void setDeal()
        {
            if (discount != 0)
            {
                lbDeal.Visible = true;
                lbDeal.Text = $"-{discount}%";
            }
            else
                lbDeal.Visible = false;

        }
    }
}