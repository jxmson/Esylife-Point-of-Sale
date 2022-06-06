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
    public partial class frmDashboardMembers : Form
    {
        Member member = new Member();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstring);
        public frmDashboardMembers()
        {
            InitializeComponent();
            dgvMemberSummary.DataSource = member.SelectMemberInfoSummary();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMemberSearch.Text))
                MessageBox.Show("Please enter a keyword to search for.", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt = member.SearchMemberSummary(txtMemberSearch.Text);
                dgvMemberSummary.DataSource = dt;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            dgvMemberSummary.DataSource = member.SelectMemberInfoSummary();
            txtMemberSearch.Clear();
        }

        private void grpProductSearch_Enter(object sender, EventArgs e)
        {

        }
        private void ClearTextBoxes()
        {
            txtSurname.Clear();
            txtSponsor.Clear();
            txtID.Clear();
            txtFName.Clear();
            txtContactNum.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFName.Text))
                MessageBox.Show("Please add a Name for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtSurname.Text))
                MessageBox.Show("Please add a Surname for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtID.Text))
                MessageBox.Show("Please add an ID Number for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtContactNum.Text))
                MessageBox.Show("Please add a Contact for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (String.IsNullOrEmpty(txtSponsor.Text))
                MessageBox.Show("Please add a Sponsor for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (txtSponsor.Text == "BM0")
            {
                MessageBox.Show("The sponsor member is not yet registered. Please select a registered member as a sponsor.");
            }
            else
            {
                string sql = "select BM_Number from Member where BM_Number = '" + txtSponsor.Text + "'";
                SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                ad.Fill(ds);

                //SqlConnection conn1 = new SqlConnection(myconnstring);

                //string sql1 = "select BM_Number from Members where BM_Number = '" + txtBMNum.Text + "'";
                //SqlDataAdapter a = new SqlDataAdapter(sql1, conn1);
                //DataSet d = new DataSet();
                //a.Fill(d);
                
                if (ds.Tables[0].Rows.Count != 0)
                {
                    try
                    {
                        member.BM_Number = "BM0";
                        member.ContactNum = int.Parse(txtContactNum.Text);
                        member.IDNumber = txtID.Text.ToUpper();
                        member.FirstName = txtFName.Text;
                        member.Surname = txtSurname.Text;
                        member.Sponsor = txtSponsor.Text.ToUpper();

                        bool insertSuccess = member.InsertData(member);

                        if (insertSuccess)
                        {
                            MessageBox.Show("Member added successfully.", "Successfully added", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            dgvMemberSummary.DataSource = member.SelectAllData();
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
                    MessageBox.Show("Sponsor BM does not exist. Double click an existing member to add them as a sponsor.", "BM does not exist", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void dgvMemberSummary_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtSponsor.Clear();
            txtSponsor.Text = dgvMemberSummary.Rows[rowIndex].Cells[0].Value.ToString();
        }
    }
}
