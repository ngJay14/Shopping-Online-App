using Microsoft.Reporting.Map.WebForms.BingMaps;
using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Interfaces;
using shoppingApp.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shoppingApp.Forms
{
    public partial class invoiceForm : Form
    {
        public invoiceForm()
        {
            InitializeComponent();
        }

        public string username {  get; set; }
        public int order_id { get; set; }

        sqlAdapter sql = new sqlAdapter();
        common comm = new common();
        message mess = new message();

        // Form load event
        private void invoiceForm_Load(object sender, EventArgs e)
        {

            invoice.SetDisplayMode(DisplayMode.Normal);

            PageSettings page = new PageSettings();
            page.Margins = new Margins(0, 0, 0, 0);

            PrintDocument printDoc = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            IEnumerable<PaperSize> paperSizes = ps.PaperSizes.Cast<PaperSize>();
            PaperSize sizeA4 = paperSizes.First<PaperSize>(size => size.Kind == PaperKind.A4);
            page.PaperSize = sizeA4;

            invoice.SetPageSettings(page);

            LoadData();

            this.invoice.RefreshReport();

            capture();
            sendInvoiceToEmail();
        }

        private void sendInvoiceToEmail()
        {
            // Send confirm message to email of user
            string email = sql.getEmailByUsername(username);
            if (email != null)
            {
                comm.sendEmail(email, mess.subjectEmail1, mess.bodyEmail1, getProdImageUrl());

            }
            else
                MessageBox.Show(mess.transactionMess1);
        }

        // Convert report to image
        private void capture()
        {
            var byts = invoice.LocalReport.Render("Image", "");
            File.WriteAllBytes(getProdImageUrl(), byts);
        }

        // Load data funtion
        public void LoadData()
        {
            DataTable orderItems = sql.getOrderItemsByOrderId(order_id);

            orderItems.Columns.Add("unit_price", typeof(string));
            orderItems.Columns.Add("amount", typeof(string));

            invoice.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            string soluPath = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            var path = $@"{soluPath}\Invoice\invoice.rdlc";
            invoice.LocalReport.ReportPath = path;

            int total = 0;
            foreach(DataRow row in orderItems.Rows)
            {
                int price = (int)row["price"];
                int discount = (int)row["discount"];

                int amount = price - (price * discount / 100);
                total += amount * (int)row["quantity"];

                row["unit_price"] = comm.splitMoneyStr(amount.ToString());
                row["amount"] = comm.splitMoneyStr((amount * (int)row["quantity"]).ToString());

            }


            ReportDataSource dts = new ReportDataSource();
            dts.Name = "Orders";
            dts.Value = orderItems;
            invoice.LocalReport.DataSources.Clear();
            invoice.LocalReport.DataSources.Add(dts);

            ReportParameter para1 = new ReportParameter();
            para1.Name = "date";
            para1.Values.Add(orderItems.Rows[0]["date"].ToString());
            invoice.LocalReport.SetParameters(new ReportParameter[] { para1 });

            ReportParameter para2 = new ReportParameter();
            para2.Name = "total";
            para2.Values.Add(comm.splitMoneyStr(total.ToString()));
            invoice.LocalReport.SetParameters(new ReportParameter[] { para2 });

            User user = sql.getUserByUsername(orderItems.Rows[0]["username"].ToString());


            ReportParameter para3 = new ReportParameter();
            para3.Name = "cus_name";
            para3.Values.Add(user.Firstname + " " + user.Lastname);
            invoice.LocalReport.SetParameters(new ReportParameter[] { para3 });

            ReportParameter para4 = new ReportParameter();
            para4.Name = "phone";
            para4.Values.Add(user.PhoneNum);
            invoice.LocalReport.SetParameters(new ReportParameter[] { para4 });

            ReportParameter para5 = new ReportParameter();
            para5.Name = "address";
            para5.Values.Add(user.Address);
            invoice.LocalReport.SetParameters(new ReportParameter[] { para5 });

        }

        // Get image url to save image in bin\\Debug folder of solution
        private string getProdImageUrl()
        {
            var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
            var imageDirRel = $"order_images\\order_{username}_{order_id}.jpeg";
            var imageDirAbs = Path.Combine(assemblyParentPath, imageDirRel);

            return imageDirRel;
        }
    }
}
