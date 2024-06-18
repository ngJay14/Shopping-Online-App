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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace shoppingApp.Forms
{
    public partial class addCatesForm : Form
    {
        public addCatesForm()
        {
            InitializeComponent();
        }

        message mess = new message();
        sqlAdapter sql = new sqlAdapter();

        int cate_id = -1;

        // Button Delete click event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (cate_id != -1)
            {
                DialogResult dialogResult = MessageBox.Show(mess.addCateMess4, "Confirm", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    if (sql.deleteCategoryById(cate_id))
                    {
                        MessageBox.Show(mess.addCateMess3);

                        addCatesForm_Load(sender, e);
                    }
                }
            }
            else
                MessageBox.Show(mess.addCateMess5);
        }

        // Button Insert click event
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (checkValInfo())
            {
                if (sql.insertCategory(txtCategoryName.Text, rchTxtCateDes.Text))
                {
                    MessageBox.Show(mess.addCateMess1);

                    addCatesForm_Load(sender, e);
                }
            }
        }

        // Button Update click event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (checkValInfo())
            {
                if (sql.updateCategoryById(cate_id, txtCategoryName.Text, rchTxtCateDes.Text))
                {
                    MessageBox.Show(mess.addCateMess2);

                    addCatesForm_Load(sender, e);
                }
            }
        }

        // Button Clear click event
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearCtrl();
        }

        // Clear data in control
        private void clearCtrl()
        {
            txtCategoryName.Clear();
            rchTxtCateDes.Clear();

            cate_id = -1;
        }

        // Check validated informations
        private bool checkValInfo()
        {
            // Check empty value of category name textbox
            if (string.IsNullOrEmpty(txtCategoryName.Text.Trim()))
            {
                error.SetError(txtCategoryName, mess.addCateMess5);
                return false;
            }
            else
                error.SetError(txtCategoryName, string.Empty);



            // Check empty value of category description richtextbox
            if (string.IsNullOrEmpty(rchTxtCateDes.Text.Trim()))
            {
                error.SetError(rchTxtCateDes, mess.addCateMess6);
                return false;
            }
            else
                error.SetError(rchTxtCateDes , string.Empty);

            return true;
        }

        // Row header of datagridview click event
        private void categoriesView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cate_id = int.Parse(categoriesView.CurrentRow.Cells[0].Value.ToString());

            txtCategoryName.Text = categoriesView.CurrentRow.Cells[1].Value.ToString();
            rchTxtCateDes.Text = categoriesView.CurrentRow.Cells[2].Value.ToString();
        }

        // Form load event
        private void addCatesForm_Load(object sender, EventArgs e)
        {
            clearCtrl();

            DataTable dt = sql.getAllCategories();

            categoriesView.DataSource = dt;
        }


    }
}
