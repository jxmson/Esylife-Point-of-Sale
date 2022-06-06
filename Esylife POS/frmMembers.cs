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
    public partial class frmMembers : Form
    {
        Member member = new Member();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstring);

        public frmMembers()
        {
            InitializeComponent();
            dgvMembers.DataSource = member.SelectAllData();
            txtMemberNum.Enabled = false;
        }

        private void btnViewAllProduct_Click(object sender, EventArgs e)
        {
            dgvMembers.DataSource = member.SelectAllData();
            txtMemberSearch.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberSearch.Text))
                MessageBox.Show("Please enter a keyword to search for.", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt = member.Search(txtMemberSearch.Text);
                dgvMembers.DataSource = dt;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBMNum.Text))
                MessageBox.Show("Please add a BM Number for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtIDNum.Text))
                MessageBox.Show("Please add an ID Number for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtFName.Text))
                MessageBox.Show("Please add a Name for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtSurname.Text))
                MessageBox.Show("Please add a Surname for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtContactNum.Text))
                MessageBox.Show("Please add a Contact for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtSponsor.Text))
                MessageBox.Show("Please add a Sponsor for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtBMNum.Text.Substring(0, 2) == "BM" || txtBMNum.Text.Substring(0, 2) == "NF" || txtBMNum.Text.Substring(0, 2) == "bm" || txtBMNum.Text.Substring(0, 2) == "nf")
            {
                string sql = "select BM_Number from Member where BM_Number = '" + txtSponsor.Text + "'";
                SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ad.Fill(ds);

                SqlConnection conn1 = new SqlConnection(myconnstring);

                string sql1 = "select BM_Number from Member where BM_Number = '" + txtBMNum.Text + "'";
                SqlDataAdapter a = new SqlDataAdapter(sql1, conn1);
                DataSet d = new DataSet();
                a.Fill(d);


                if (d.Tables[0].Rows.Count == 0)
                {

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        try
                        {
                            member.BM_Number = txtBMNum.Text.ToUpper();
                            member.ContactNum = int.Parse(txtContactNum.Text);
                            member.IDNumber = txtIDNum.Text.ToUpper();
                            member.FirstName = txtFName.Text;
                            member.Surname = txtSurname.Text;
                            member.Sponsor = txtSponsor.Text.ToUpper();

                            bool insertSuccess = member.InsertData(member);

                            if (insertSuccess)
                            {
                                MessageBox.Show("Member added successfully.", "Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                dgvMembers.DataSource = member.SelectAllData();
                                ClearTextBoxes();
                            }
                            else
                                MessageBox.Show("Failed to add member. \nTry again. If the problem persists, contact your administrator.", "Not added!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Please make sure the format of each entry field is correct. \nContact number may not contain any letters", "Incorrect format detected.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sponsor BM does not exist", "BM does not exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show("This BM Number already exists", "BM exists", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else
            {
                MessageBox.Show("Please make sure that the Member's BM or NF number is valid. A valid BM number is prefixed by 'BM' and an NF Number by 'NF' ", "Invalid sponsor BM Number", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvMembers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DialogResult r = MessageBox.Show("Select this member?", "Member", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
            {
                txtMemberNum.Text = dgvMembers.Rows[rowIndex].Cells[0].Value.ToString();
                txtBMNum.Text = dgvMembers.Rows[rowIndex].Cells[1].Value.ToString();
                txtFName.Text = dgvMembers.Rows[rowIndex].Cells[2].Value.ToString();
                txtSurname.Text = dgvMembers.Rows[rowIndex].Cells[3].Value.ToString();
                txtContactNum.Text = dgvMembers.Rows[rowIndex].Cells[5].Value.ToString();
                txtIDNum.Text = dgvMembers.Rows[rowIndex].Cells[4].Value.ToString();
                txtSponsor.Text = dgvMembers.Rows[rowIndex].Cells[6].Value.ToString();
            }
        }
        private void ClearTextBoxes()
        {
            txtBMNum.Clear();
            txtContactNum.Clear();
            txtFName.Clear();
            txtIDNum.Clear();
            txtSponsor.Clear();
            txtSurname.Clear();
            txtMemberNum.Clear();
        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int rowIndex = e.RowIndex;

            //DialogResult r = MessageBox.Show("Add this member as a sponsor?", "Sponsor", MessageBoxButtons.YesNo);

            //if (r == DialogResult.Yes)
            //    txtSponsor.Text = dgvMembers.Rows[rowIndex].Cells[1].Value.ToString();

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberNum.Text))
            {
                MessageBox.Show("Please select a member to edit.\nDouble click on a record to auto-fill the member information. You may not enter the members details manually.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                member.MemberNumber = int.Parse(txtMemberNum.Text);
                member.FirstName = txtFName.Text;
                member.IDNumber = txtIDNum.Text;
                member.Surname = txtSurname.Text;
                member.ContactNum = int.Parse(txtContactNum.Text);
                member.Sponsor = txtSponsor.Text;
                member.BM_Number = txtBMNum.Text;

                bool editsuccess = member.UpdateData(member);

                if (editsuccess)
                    MessageBox.Show(member.FirstName + " edited successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to edit " + member.FirstName + ". " + "\nTry again. If the problem persists, contact your administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            dgvMembers.DataSource = member.SelectAllData();

            ClearTextBoxes();
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
                    deletesuccess = member.DeleteData(txtBMNum.Text);

                    if (deletesuccess)
                        MessageBox.Show("Member deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to delete " + txtFName.Text + " " + txtSurname.Text + ". \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }

                dgvMembers.DataSource = member.SelectAllData();

                ClearTextBoxes();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dgvMembers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;

            DialogResult r = MessageBox.Show("Add this member as a sponsor?", "Sponsor", MessageBoxButtons.YesNo);

            if (r == DialogResult.Yes)
                txtSponsor.Text = dgvMembers.Rows[rowIndex].Cells[1].Value.ToString();
        }
    }
}


