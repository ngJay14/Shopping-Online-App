using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoppingApp.Classes
{
    internal class message
    {

        // Messages in Logup form
        public string logupMess1 = "Please select photo !";
        public string logupMess2 = "First name is required !";
        public string logupMess3 = "Last name is required !";
        public string logupMess4 = "Username is required !";
        public string logupMess5 = "Username has existed !";
        public string logupMess6 = "Phone number is required !";
        public string logupMess7 = "Invalid phone number !";
        public string logupMess8 = "Email is required !";
        public string logupMess9 = "Invalid email !";
        public string logupMess10 = "Password is required !";
        public string logupMess11 = "Sign up successfully !";
        public string logupMess12 = "Email has existed !";
        public string logupMess13 = "Address is required !";


        // Messages in login form
        public string loginMess1 = "Invalid user. Please check username and password !";
        public string loginMess2 = "Password has sent to your email address!";
        public string loginMess3 = "Email not found. Please check again !";
        public string loginMess4 = "Your password is ";
        public string loginMess5 = "SHON - FORGET PASSWORD";


        // Messages in main form
        public string mainMess1 = "Are you sure to exit this app ?";


        // Messages in add categories form
        public string addCateMess1 = "Category has been inserted !";
        public string addCateMess2 = "Category has been updated !";
        public string addCateMess3 = "Category has been deleted !";
        public string addCateMess4 = "Are you sure to delete this category ?";
        public string addCateMess5 = "Category is required !";
        public string addCateMess6 = "Category description is required !";


        // Messages in manage users form
        public string manaUsersMess1 = "User has been updated !";
        public string manaUsersMess2 = "User has been deleted !";
        public string manaUsersMess3 = "Are you sure to delete this user ?";
        public string manaUsersMess4 = "Please choose an user !";
        public string manaUsersMess5 = "Please choose a role for user !";


        // Messages in add product form
        public string addProdsMess1 = "Product has been inserted !";
        public string addProdsMess2 = "Product name is required !";
        public string addProdsMess3 = "Sub text is required !";
        public string addProdsMess4 = "Please choose a category !";
        public string addProdsMess5 = "Please choose status !";
        public string addProdsMess6 = "Price of product is required !";
        public string addProdsMess7 = "Size of product is required !";
        public string addProdsMess8 = "Discount is required !";
        public string addProdsMess9 = "Quantity of product is required !";
        public string addProdsMess10 = "Please choose sex of product !";
        public string addProdsMess11 = "Please choose images for product !";
        public string addProdsMess12 = "Description of product is required !";
        public string addProdsMess13 = "Are you sure to delete this product ?";
        public string addProdsMess14 = "Product has been updated !";
        public string addProdsMess15 = "Please choose a product !";
        public string addProdsMess16 = "Product has been deleted !";
        public string addProdsMess21 = "Please pick end time for discount !";

        public string addProdsMess17 = "You can insert or delete any image file in this folder. Syntax of filename must be 'prod_[product_id]_[sequence_of_image].'";
        public string addProdsMess18 = "Edit image files of product";
        public string addProdsMess19 = "Choose images for product.'";
        public string addProdsMess20 = "Select images";


        // Messages in product detail form
        public string prodDetailMess1 = "Product has been added into your cart !";
        public string prodDetailMess2 = "Please choose size !";
        public string prodDetailMess3 = "You has rated for this product before !";
        public string prodDetailMess4 = "Your rating has sended !";


        // Messages in uc Cart Item
        public string ucCartItemMess1 = "You can not choose over 10 this product !";
        public string ucCartItemMess2 = "Are you sure to delete this product out of your cart !";


        // Messages in cart form
        public string cartMess1 = "Please choose product to discharge !";


        // Messages in transaction form
        public string transactionMess1 = "Something wrong. Please try again !";
        public string transactionMess2 = "Ship address is required !";
        public string transactionMess3 = "Phone number is required !";


        // Message for manage order form
        public string manaOrderMess1 = "Please choose a status for this order !";
        public string manaOrderMess2 = "Please choose an order !";
        public string manaOrderMess3 = "Order has been updated !";
        public string manaOrderMess4 = "Order has been deleted !";


        // Message for email sending
        public string sendEmailMess = "We have sent you an email. Check your email to confirm your order !";
        public string subjectEmail1 = "SHON - CONFIRM YOUR ORDER";
        public string bodyEmail1 = "Your order has been confirmed. You can track the status of your order through the SHON app.";

    }
}
