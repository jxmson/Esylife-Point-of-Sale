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
    public partial class frmAssignBM : Form
    {
        Member member =  new Member();

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstring);
        public frmAssignBM()
        {
            InitializeComponent();
            txtContact.Enabled = txtFirstName.Enabled = txtIDNum.Enabled = txtSponsor.Enabled = txtSurname.Enabled = txtMemberNum.Enabled = false;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBM.Text))
                MessageBox.Show("Please add a BM Number for the member", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            string sql = "select BM_Number from Member where BM_Number = '" + txtBM.Text + "'";
            SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
            DataSet ds = new DataSet();
            ad.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                MessageBox.Show("This BM Number already exists.", "Member already exists.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtBM.Text.Substring(0, 2) == "BM" || txtBM.Text.Substring(0, 2) == "NF" || txtBM.Text.Substring(0, 2) == "nf" || txtBM.Text.Substring(0, 2) == "bm")
                {
                    try
                    {
                        member.BM_Number = txtBM.Text;
                        member.ContactNum = int.Parse(txtContact.Text);
                        member.IDNumber = txtIDNum.Text;
                        member.FirstName = txtFirstName.Text;
                        member.Surname = txtSurname.Text;
                        member.Sponsor = txtSponsor.Text;
                        member.MemberNumber = int.Parse(txtMemberNum.Text);

                        bool assignSuccess = member.UpdateData(member);

                        if (assignSuccess)
                        {
                            MessageBox.Show("Member successfully registered.", "Successfully added.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmUnregisteredMembers frm = new frmUnregisteredMembers();
                            this.Hide();
                            frm.ShowDialog();
                        }
                        else
                            MessageBox.Show("Member not added", "Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
                else
                {
                    MessageBox.Show("Please make sure that the BM or NF number is valid. A valid BM number is prefixed by 'BM' and an NF Number by 'NF' ", "Invalid BM Number", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
        }
    }
}