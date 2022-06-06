using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esylife_POS
{
    
    public partial class frmProduct : Form
    {
        Product p = new Product();
        public frmProduct()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            DataTable dt = p.ProductData();
            dgvProducts.DataSource = dt;

            txtProductID.Enabled = false;
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductSearch.Text))
                MessageBox.Show("Please enter a keyword to search for.", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt = p.Search(txtProductSearch.Text);
                dgvProducts.DataSource = dt;
            }
        }

        private void btnViewAllProduct_Click(object sender, EventArgs e)
        {
            DataTable dt = p.ProductData();
            dgvProducts.DataSource = dt;
            txtProductSearch.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal price;

            if (string.IsNullOrEmpty(txtProductName.Text))
                MessageBox.Show("Name cannot be empty. Please enter a name.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                p.Name = txtProductName.Text;     
            
            if (decimal.TryParse(txtProductPrice.Text, out price))
            {
                p.Price = price;
            }
            else
            {
                MessageBox.Show("Please enter a decimal numerics with a point (.) separator.", "Format Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (nudProductQuantity.Value == 0)
                MessageBox.Show("Are you sure that quantity is 0?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            p.Quantity = int.Parse(nudProductQuantity.Value.ToString());

            p.Points = Math.Round(decimal.Parse(txtProductPoints.Text), 2);
            p.UplinePoints = Math.Round(decimal.Parse(txtUplinePoints.Text), 2);

            if (p.InsertData(p))
                MessageBox.Show("Product successfully added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Product not added", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ClearProductTxtBox();

            DataTable dt = p.ProductData();
            dgvProducts.DataSource = dt;
        }

        private void ClearProductTxtBox()
        {
            txtProductName.Clear();
            txtProductID.Clear();
            txtProductPrice.Clear();
            txtProductPoints.Clear();
            txtUplinePoints.Clear();
            nudProductQuantity.Value = 0;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductID.Text))
            {
                MessageBox.Show("Please select a product to edit.\nDouble click on a record to auto-fill the product information. You may not enter the product details manually.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                p.ProdID = int.Parse(txtProductID.Text);
                p.Name = txtProductName.Text;
                p.Price = decimal.Parse(txtProductPrice.Text);
                p.Quantity = int.Parse(nudProductQuantity.Value.ToString());
                p.Points = Math.Round(decimal.Parse(txtProductPoints.Text), 2);
                p.UplinePoints = Math.Round(decimal.Parse(txtUplinePoints.Text), 2);

                bool editsuccess = p.Update(p);

                if (editsuccess)
                    MessageBox.Show(p.Name + " edited successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to edit " + p.Name + ". "+"\nTry again. If the problem persists, contact your administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataTable dt = p.ProductData();
            dgvProducts.DataSource = dt;

            ClearProductTxtBox();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Double click on the far left of a record to select it for editing or deleting. You may not enter product details for both these actions manually. /nNote that once you delete a product, you cannot reverse the action. You will have to add it as a new product.");
        }

        private void dgvProducts_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtProductID.Text = dgvProducts.Rows[rowIndex].Cells[0].Value.ToString();
            txtProductName.Text = dgvProducts.Rows[rowIndex].Cells[1].Value.ToString();
            txtProductPrice.Text = dgvProducts.Rows[rowIndex].Cells[2].Value.ToString();
            nudProductQuantity.Value = decimal.Parse(dgvProducts.Rows[rowIndex].Cells[3].Value.ToString());
            txtProductPoints.Text = dgvProducts.Rows[rowIndex].Cells[4].Value.ToString();
            txtUplinePoints.Text = dgvProducts.Rows[rowIndex].Cells[5].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtProductID.Text))
                MessageBox.Show("Please select a member to delete. Double click a record to auto-fill the members information.", "Nothing to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                p.ProdID = int.Parse(txtProductID.Text);
                p.Name = txtProductName.Text;

                bool deletesuccess;

                if(DialogResult.Yes == MessageBox.Show("Are you sure you want to delete " + p.Name + "?","Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deletesuccess = p.Delete(p);

                    if (deletesuccess)
                        MessageBox.Show(p.Name + " deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to delete " + p.Name + ". \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                DataTable dt = p.ProductData();
                dgvProducts.DataSource = dt;

                ClearProductTxtBox();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearProductTxtBox();
        }

        private void btnBacktoDashboard_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            Hide();
            frm.ShowDialog();
            
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
