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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace shoppingApp.Forms
{
    public partial class addProdsForm : Form
    {
        public addProdsForm()
        {
            InitializeComponent();
        }

        sqlAdapter sql = new sqlAdapter();
        message mess = new message();
        common comm = new common();

        int prod_id = -1;

        private void addProdsForm_Load(object sender, EventArgs e)
        {
            // Set Width of rich text box fit the form
            rchTxtProdDes.Width = panel1.Width - 37;

            clearCtrl();
            filComboBox();

            DataTable dt = sql.getAllProducts();

            grViewProducts.DataSource = dt;
        }

        // Clear data of controls
        private void clearCtrl()
        {
            txtProdName.Clear();
            txtSubText.Clear();
            txtPrice.Clear();
            txtDiscount.Clear();
            txtQuantity.Clear();
            radBtnSta1.Checked = false;
            radBtnSta2.Checked = false;
            radBtnSex1.Checked = false;
            radBtnSex2.Checked = false;
            rchTxtProdDes.Clear();
            flPnImages.Controls.Clear();

            prod_id = -1;
        }

        // Check validated informations
        private bool checkValInfo()
        {
            // Check empty value of product name textbox
            if (string.IsNullOrEmpty(txtProdName.Text.Trim()))
            {
                error.SetError(txtProdName, mess.addProdsMess2);
                return false;
            }
            else
                error.SetError(txtProdName, string.Empty);


            // Check empty value of subtext textbox
            if (string.IsNullOrEmpty(txtSubText.Text.Trim()))
            {
                error.SetError(txtSubText, mess.addProdsMess3);
                return false;
            }
            else
                error.SetError(txtSubText, string.Empty);


            // Check empty value of category combobox
            if (cbBoxCates.SelectedIndex == -1)
            {
                error.SetError(cbBoxCates, mess.addProdsMess4);
                return false;
            }
            else
                error.SetError(cbBoxCates, string.Empty);


            // Check empty status radian buttons
            if (radBtnSta1.Checked == false && radBtnSta2.Checked == false)
            {
                error.SetError(pnStatus, mess.addProdsMess5);
                return false;
            }
            else
                error.SetError(pnStatus, string.Empty);


            // Check empty value of price textbox
            if (string.IsNullOrEmpty(txtPrice.Text.Trim()))
            {
                error.SetError(txtPrice, mess.addProdsMess6);
                return false;
            }
            else
                error.SetError(txtPrice, string.Empty);


            // Check empty value of size textbox
            if (string.IsNullOrEmpty(txtSize.Text.Trim()))
            {
                error.SetError(txtSize, mess.addProdsMess7);
                return false;
            }
            else
                error.SetError(txtSize, string.Empty);


            // Check empty value of discount textbox
            if (string.IsNullOrEmpty(txtDiscount.Text.Trim()))
            {
                error.SetError(txtDiscount, mess.addProdsMess8);
                return false;
            }
            else
                error.SetError(txtDiscount, string.Empty);


            // Check empty value of quantity textbox
            if (string.IsNullOrEmpty(txtQuantity.Text.Trim()))
            {
                error.SetError(txtQuantity, mess.addProdsMess9);
                return false;
            }
            else
                error.SetError(txtQuantity, string.Empty);


            // Check empty sex radian buttons
            if (radBtnSex1.Checked == false && radBtnSex2.Checked == false)
            {
                error.SetError(pnSex, mess.addProdsMess10);
                return false;
            }
            else
                error.SetError(pnSex, string.Empty);


            // Check empty images of product
            if (flPnImages.Controls.Count == 0)
            {
                error.SetError(flPnImages, mess.addProdsMess11);
                return false;
            }
            else
                error.SetError(flPnImages, string.Empty);


            // Check empty value of description richtextbox
            if (string.IsNullOrEmpty(rchTxtProdDes.Text.Trim()))
            {
                error.SetError(rchTxtProdDes, mess.addProdsMess12);
                return false;
            }
            else
                error.SetError(rchTxtProdDes, string.Empty);


            return true;
        }

        // Fill categories combo Box
        private void filComboBox()
        {
            try
            {
                sql = new sqlAdapter();
                DataTable dt = sql.getAllCategories();

                cbBoxCates.DisplayMember = "name";
                cbBoxCates.ValueMember = "id";
                cbBoxCates.DataSource = dt;

                cbBoxCates.SelectedIndex = -1;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Button clear click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCtrl();
        }

        // Button update click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkValInfo())
            {

            }
        }

        // Button insert click event
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkValInfo())
            {
                bool status = false, sex = false;

                // Published => status = true, Draft => status = false
                if (radBtnSta1.Checked)
                    status = true;

                // Male => sex = true, Female => sex = false
                if (radBtnSex1.Checked)
                    sex = true;

                List<string> files = ofd.FileNames.Cast<string>().ToList();
                List<string> listImages = new List<string>();

                // Create image folder and copy images of product

                Product prod = sql.getProdOrderByDesc();
                string foldPath = $"prod_images//prod_{prod.Id + 1}";
                Directory.CreateDirectory(foldPath);
                int i = 0;

                foreach (var f in files)
                {
                    string imaPath = getProdImageUrl(foldPath, prod.Id + 1, i);
                    listImages.Add(imaPath);
                    File.Copy(f, imaPath);
                    i++;
                }
                string imagesUrl = string.Join(", ", listImages);


                if (sql.insertProduct(txtProdName.Text, txtSubText.Text, rchTxtProdDes.Text, int.Parse(txtPrice.Text), int.Parse(txtDiscount.Text),
                    int.Parse(txtQuantity.Text), txtSize.Text, sex, imagesUrl, status, int.Parse(cbBoxCates.SelectedValue.ToString()), dateTimePicker1.Value))
                {
                    MessageBox.Show(mess.addProdsMess1);

                    addProdsForm_Load(sender, e);
                }
            }
        }

        // Button delete click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (prod_id != -1)
            {
                DialogResult dialogResult = MessageBox.Show(mess.addProdsMess13, "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (sql.deleteProductById(prod_id))
                    {
                        MessageBox.Show(mess.addCateMess3);

                        addProdsForm_Load(sender, e);
                    }
                }
            }
            else
                MessageBox.Show(mess.addCateMess5);
        }

        // Button choose images click event
        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                foreach (String filePath in ofd.FileNames)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Size = new Size(40, 40);
                    pictureBox.Image = comm.getImage(filePath);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                    flPnImages.Controls.Add(pictureBox);
                }
            }
        }

        // Get image url to save image in bin\\Debug folder of solution
        private string getProdImageUrl(string foldPath, int pro_id, int index)
        {
            string extension = Path.GetExtension(ofd.FileName);

            var assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var assemblyParentPath = Path.GetDirectoryName(assemblyPath);
            var imageDirRel = $"{foldPath}\\prod_{pro_id}_{index}{extension}";
            var imageDirAbs = Path.Combine(assemblyParentPath, imageDirRel);

            return imageDirRel;
        }

        // Row header of datagridview click event
        private void grViewProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tabControl1.SelectedIndex = 0;

            prod_id = (int)grViewProducts.CurrentRow.Cells[0].Value;
            txtProdName.Text = grViewProducts.CurrentRow.Cells[1].Value.ToString();
            txtSubText.Text = grViewProducts.CurrentRow.Cells[2].Value.ToString();
            rchTxtProdDes.Text = grViewProducts.CurrentRow.Cells[3].Value.ToString();
            cbBoxCates.SelectedValue = (int)grViewProducts.CurrentRow.Cells[11].Value;

            if ((bool)grViewProducts.CurrentRow.Cells[9].Value)
                radBtnSta1.Checked = true;
            else
                radBtnSta2.Checked = true;

            txtPrice.Text = grViewProducts.CurrentRow.Cells[4].Value.ToString();
            txtDiscount.Text = grViewProducts.CurrentRow.Cells[5].Value.ToString();
            txtSize.Text = grViewProducts.CurrentRow.Cells[11].Value.ToString();
            txtQuantity.Text = grViewProducts.CurrentRow.Cells[6].Value.ToString();

            if ((bool)grViewProducts.CurrentRow.Cells[7].Value)
                radBtnSex1.Checked = true;
            else
                radBtnSex2.Checked = true;

            List<string> list = grViewProducts.CurrentRow.Cells[8].Value.ToString().Replace(" ", "").Split(',').ToList();

            flPnImages.Controls.Clear();
            foreach (string s in list)
            {
                PictureBox pictureBox = new PictureBox();
                pictureBox.Size = new Size(40, 40);
                pictureBox.Image = comm.getImage(s);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                flPnImages.Controls.Add(pictureBox);
            }
        }
    }
}

