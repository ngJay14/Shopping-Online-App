using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingApp.Classes
{
    internal class Order
    {
        public Order() { }
        public Order(int id, string username, DateTime date, int total, string payment, string shipAddress, string status) 
        {
            this.Id = id;
            this.Username = username;
            this.Date = date;
            this.Total = total;
            this.Payment = payment;
            this.ShipAddress = shipAddress;
            this.Status = status;
        }
        public int Id { get; set; }
        public string Username { get; set; }
        public DateTime Date { get; set; }
        public int Total { get; set; }
        public string Payment { get; set; }
        public string ShipAddress { get; set; } 
        public string Status { get; set; }

    }
}
