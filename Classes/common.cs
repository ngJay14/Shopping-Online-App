using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using System.IO;

namespace shoppingApp.Classes
{
    public static class Extensions
    {
        public static IEnumerable<string> SplitByLength(this string str, int maxLength)
        {
            str = string.Concat(Enumerable.Reverse(str));
            for (int index = 0; index < str.Length; index += maxLength)
            {
                yield return str.Substring(index, Math.Min(maxLength, str.Length - index));
            }
        }
    }
    internal class common
    {
        private message mess = new message();
        // Check valid email
        public bool ValidateEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                return false;
            }

            string[] parts = email.Split('@');
            if (parts.Length != 2)
            {
                return false; // email must have exactly one @ symbol
            }

            string localPart = parts[0];
            string domainPart = parts[1];
            if (string.IsNullOrWhiteSpace(localPart) || string.IsNullOrWhiteSpace(domainPart))
            {
                return false; // local and domain parts cannot be empty
            }

            // check local part for valid characters
            foreach (char c in localPart)
            {
                if (!char.IsLetterOrDigit(c) && c != '.' && c != '_' && c != '-')
                {
                    return false; // local part contains invalid character
                }
            }

            // check domain part for valid format
            if (domainPart.Length < 2 || !domainPart.Contains(".") || domainPart.Split('.').Length != 2 || domainPart.EndsWith(".") || domainPart.StartsWith("."))
            {
                return false; // domain part is not a valid format
            }

            return true;
        }

        // Check valid phone number
        public bool IsPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^\(?([0-9]{10})$");
        }

        // Split money string
        public string splitMoneyStr(string money)
        {
            IEnumerable<string> s = money.SplitByLength(3);

            money = String.Join(",", s);
            return string.Concat(Enumerable.Reverse(money)) + " đ";
        }

        // Send email
        public bool sendEmail(string email, string subject, string body, string filePath)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("kkirigaza76@gmail.com");
                SmtpClient smtp = new SmtpClient();
                smtp.Port = 587;
                smtp.EnableSsl = true;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(mail.From.Address, "zzrggqqrtdqhrnnk");
                smtp.Host = "smtp.gmail.com";

                //recipient
                mail.To.Add(new MailAddress(email));
                mail.IsBodyHtml = true;
                mail.Subject = subject;
                mail.Body = body;
                mail.Attachments.Add(new Attachment(filePath));

                smtp.Send(mail);
                MessageBox.Show(mess.sendEmailMess, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }

            return true;
        }

        // Convert payment method from bool to string
        public string getPayment(int payment)
        {
            if (payment == 1)
                return "Digital Payments";

            return "Cash on Delivery (COD)";
        }

        // Create image from image url
        public Image getImage(string url)
        {
            Image img;
            using (var stream = File.OpenRead(url))
            {
                img = new Bitmap(stream);
            }
            return img;

        }
    }
}
