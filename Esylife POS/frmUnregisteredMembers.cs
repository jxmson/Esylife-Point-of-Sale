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
    public partial class frmUnregisteredMembers : Form
    {
        Member member = new Member();

        SqlCommand cmd = new SqlCommand();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstring);

        public frmUnregisteredMembers()
        {
            InitializeComponent();
            txtMemberNum.Enabled = txtBM.Enabled = false;
            dgvUnregisteredMembers.DataSource = member.SelectUnregisteredMembers();
        }

        private void btnAssignBM_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberNum.Text))
                MessageBox.Show("Please select a member to assign a BM. Double click on a member from the list to select the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                frmAssignBM frm = new frmAssignBM();
                frm.txtFirstName.Text = txtFirstName.Text;
                frm.txtSurname.Text = txtSurname.Text;
                frm.txtIDNum.Text = txtIDNum.Text;
                frm.txtContact.Text = txtContact.Text;
                frm.txtSponsor.Text = txtSponsor.Text;
                frm.txtMemberNum.Text = txtMemberNum.Text;

                this.Hide();
                frm.ShowDialog();
            }
        }

        private void dgvUnregisteredMembers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtMemberNum.Text = dgvUnregisteredMembers.Rows[rowIndex].Cells[0].Value.ToString();
            txtIDNum.Text = dgvUnregisteredMembers.Rows[rowIndex].Cells[1].Value.ToString();
            txtFirstName.Text = dgvUnregisteredMembers.Rows[rowIndex].Cells[2].Value.ToString();
            txtSurname.Text = dgvUnregisteredMembers.Rows[rowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvUnregisteredMembers.Rows[rowIndex].Cells[4].Value.ToString();
            txtSponsor.Text = dgvUnregisteredMembers.Rows[rowIndex].Cells[5].Value.ToString();
            txtBM.Text = dgvUnregisteredMembers.Rows[rowIndex].Cells[6].Value.ToString();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberNum.Text))
            {
                MessageBox.Show("Please select an unregistered member to edit.\nDouble click on a record to auto-fill the member information. You may not enter the members details manually.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                member.MemberNumber = int.Parse(txtMemberNum.Text);
                member.FirstName = txtFirstName.Text;
                member.IDNumber = txtIDNum.Text;
                member.Surname = txtSurname.Text;
                member.ContactNum = int.Parse(txtContact.Text);
                member.Sponsor = txtSponsor.Text;
                member.BM_Number = txtBM.Text;

                bool editsuccess = member.UpdateData(member);

                if (editsuccess)
                    MessageBox.Show(member.FirstName + " edited successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to edit " + member.FirstName + ". " + "\nTry again. If the problem persists, contact your administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvUnregisteredMembers.DataSource = member.SelectUnregisteredMembers();

            ClearTextBoxes();
        }
        private void ClearTextBoxes()
        {
            txtSurname.Clear();
            txtSponsor.Clear();
            txtMemberNum.Clear();
            txtIDNum.Clear();
            txtFirstName.Clear();
            txtContact.Clear();
            txtMemberNum.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtMemberNum.Text))
                MessageBox.Show("Please select a member to delete. Double click a record to auto-fill the members information.", "Nothing to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                bool deletesuccess;

                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete this member?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deletesuccess = member.DeleteData(txtBM.Text);

                    if (deletesuccess)
                        MessageBox.Show("Member deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to delete " + txtFirstName.Text + " " + txtSurname.Text + ". \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                dgvUnregisteredMembers.DataSource = member.SelectUnregisteredMembers();

                ClearTextBoxes();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberSearch.Text))
                MessageBox.Show("Please enter a keyword to search for.", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt = member.SearchMemberSummary(txtMemberSearch.Text);
                dgvUnregisteredMembers.DataSource = dt;
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvUnregisteredMembers.DataSource = member.SelectUnregisteredMembers();
            txtMemberSearch.Clear();
        }
    }
}
