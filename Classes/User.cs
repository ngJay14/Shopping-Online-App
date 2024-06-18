using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingApp.Classes
{
    public class User
    {
        private string username;
        private string firstname;
        private string lastname;
        private string email;
        private string password;
        private string phoneNum;
        private string role;
        private string avaUrl;
        private string address;

        public User() {}

        public User(string username, string firstname, string lastname, string email, string password, string phoneNum, string role, string avaUrl, string address)
        {
            this.username = username;
            this.firstname = firstname;
            this.lastname = lastname;
            this.email = email;
            this.password = password;
            this.phoneNum = phoneNum;
            this.role = role;
            this.avaUrl = avaUrl;
            this.address = address;
        }

        public string Username { get { return username; } set { username = value; } }
        public string Firstname { get { return firstname; } set { firstname = value; } }
        public string Lastname { get { return lastname; } set { lastname = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Password { get { return password; } set { password = value; } }
        public string PhoneNum { get { return phoneNum; } set { phoneNum = value; } }
        public string Role { get { return role; } set { role = value; } }
        public string AvaUrl { get { return avaUrl; } set { avaUrl = value; } }
        public string Address { get => address; set => address = value; }
    }
}
