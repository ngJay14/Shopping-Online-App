using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace shoppingApp.Classes
{
    public class Product
    {
        private int id;
        private string name;
        private string subText;
        private string description;
        private int price;
        private int discount;
        private int quantity;
        private bool sex;
        private string imagesUrl;
        private bool status;
        private string size;
        private string category;
        private string end_day;

        public Product() { }

        public Product(int id, string name, string subText, string description, int price, int discount, int quantity, 
            bool sex, string imagesUrl, bool status, string size, string category, string end_day)
        {
            this.id = id;
            this.name = name;
            this.subText = subText;
            this.description = description;
            this.price = price;
            this.discount = discount;
            this.quantity = quantity;
            this.sex = sex;
            this.imagesUrl = imagesUrl;
            this.status = status;
            this.size = size;
            this.category = category;
            this.end_day = end_day;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string SubText { get => subText; set => subText = value; }
        public string Description { get => description; set => description = value; }
        public int Price { get => price; set => price = value; }
        public int Discount { get => discount; set => discount = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public bool Sex { get => sex; set => sex = value; }
        public string ImagesUrl { get => imagesUrl; set => imagesUrl = value; }
        public bool Status { get => status; set => status = value; }
        public string Size { get => size; set => size = value; }
        public string Category { get => category; set => category = value; }
        public string End_day { get => end_day; set => end_day = value; }
    }
}
