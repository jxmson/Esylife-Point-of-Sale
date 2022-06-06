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
    public partial class frmDashboard : Form
    {
        Product product = new Product();
        public frmDashboard()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            DataTable dt = product.DashboardData();
            dgvDashboardProducts.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDashboardProductSearch.Text))
                MessageBox.Show("Please enter a keyword to search for.", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt = product.Search(txtDashboardProductSearch.Text);
                dgvDashboardProducts.DataSource = dt;
            }
        }

        private void btnViewAllDashboard_Click(object sender, EventArgs e)
        {
            DataTable dt = product.ProductData();
            dgvDashboardProducts.DataSource = dt;
            txtDashboardProductSearch.Clear();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (this.Name == "frmDashboard")
                return;
            else
            {
                frmDashboard frm = new frmDashboard();
                frm.ShowDialog();
            }
        }

        private void btnPaymentMethods_Click(object sender, EventArgs e)
        {

        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            this.Hide();
            frm.ShowDialog();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMembers_Click(object sender, EventArgs e)
        {
            frmDashboardMembers frm = new frmDashboardMembers();
            frm.ShowDialog();
        }

        private void btnNewMem_Click(object sender, EventArgs e)
        {

        }

        private void dgvDashboardProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tmrTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm tt");
        }

        public string GetTransactionNumber()
        {
            string date = DateTime.Now.ToString("yyyyMMdd");
            int increment = 1001;
            string transnum = date + increment.ToString();

            return transnum;
        }
    }
}
