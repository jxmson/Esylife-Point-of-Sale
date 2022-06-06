using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esylife_POS
{
    public partial class frmRole : Form
    {
        UserRole r = new UserRole();
        SqlCommand cmd = new SqlCommand();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstring);

        DataTable dt;
        public frmRole()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            dt = r.RoleData();
            dgvRoles.DataSource = dt;

            txtRoleID.Enabled = false;
        }

        private void btnSaveNewRole_Click(object sender, EventArgs e)
        {

            string query = "Select Count(*) from Role where (RoleName = @RoleN)";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@RoleN", txtRoleName.Text);

            conn.Open();

            int RoleExists = (int)cmd.ExecuteScalar();

            
            if (String.IsNullOrEmpty(txtRoleName.Text))
            {
                MessageBox.Show("Please enter a role name.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (RoleExists > 0) // if it for sure exist
            {
                MessageBox.Show("This Role already exists.", "Role Exists", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                r.RoleName = txtRoleName.Text;
                if (r.InsertData(r))
                {
                    MessageBox.Show("Successfully added");

                }
                else
                {
                    MessageBox.Show("Not saved.");
                }
              
            }

            conn.Close();

            dt = r.RoleData();
            dgvRoles.DataSource = dt;
        }
  

        private void btnEditRole_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtRoleID.Text))
            {
                MessageBox.Show("Please select a role to edit.\nDouble click on a record to auto-fill the roles information. You may not enter the role details manually.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                r.RoleID = int.Parse(txtRoleID.Text);
                r.RoleName = txtRoleName.Text;

                bool editsuccess = r.Update(r);

                if (editsuccess)
                    MessageBox.Show(r.RoleName + " edited successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to edit " + r.RoleName + ". " + "\nTry again. If the problem persists, contact your administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            DataTable dt = r.RoleData();
            dgvRoles.DataSource = dt;

            ClearRoleTextBoxes();
        }
        private void ClearRoleTextBoxes()
        {
            txtRoleID.Clear();
            txtRoleName.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            this.Hide();
            frm.ShowDialog();
        }


        private void btnClear_Click_1(object sender, EventArgs e)
        {
            ClearRoleTextBoxes();
        }

        private void btnDeleteRole_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRoleID.Text))
                MessageBox.Show("Please select a role to delete. Double click a record to auto-fill the role information.", "Nothing to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                r.RoleID = int.Parse(txtRoleID.Text);
                r.RoleName = txtRoleName.Text;

                bool deletesuccess;

                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete " + r.RoleName + "?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deletesuccess = r.Delete(r);

                    if (deletesuccess)
                        MessageBox.Show(r.RoleName + " deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to delete " + r.RoleName + ". \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                DataTable dt = r.RoleData();
                dgvRoles.DataSource = dt;

                ClearRoleTextBoxes();
            }
        }

        private void dgvRoles_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtRoleID.Text = dgvRoles.Rows[rowIndex].Cells[0].Value.ToString();
            txtRoleName.Text = dgvRoles.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}
