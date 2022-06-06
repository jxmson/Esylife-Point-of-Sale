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
    public partial class frmCurrentUsers : Form
    {
        AccountUser user = new AccountUser();
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        SqlConnection conn = new SqlConnection(myconnstring);
        public frmCurrentUsers()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvUsers.DataSource = user.UserData();

            txtUserID.Enabled = false;

            ReadToRoleCmb();
        }

        private void ReadToRoleCmb()
        {
            SqlCommand sql = new SqlCommand("select RoleName from Role", conn);

            conn.Open();
            dr = sql.ExecuteReader();

            while (dr.Read())
            {
                cmbRole.Items.Add(dr[0]);

            }
            dr.Close();
            conn.Close();
        }
        private void dgvUsers_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;

            txtUserID.Text = dgvUsers.Rows[rowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[rowIndex].Cells[3].Value.ToString();
            txtFirstName.Text = dgvUsers.Rows[rowIndex].Cells[1].Value.ToString();
            txtSurname.Text = dgvUsers.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[rowIndex].Cells[4].Value.ToString();
            txtCellNum.Text = dgvUsers.Rows[rowIndex].Cells[5].Value.ToString();

            string query = "Select RoleName from Role where RoleID = @ID";
            cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@ID", dgvUsers.Rows[rowIndex].Cells[7].Value.ToString());

            conn.Open();


                dr = cmd.ExecuteReader();
                dr.Read();

                cmbRole.SelectedItem = dr[0].ToString();


            dr.Close();
            conn.Close();
        }

        private void btnUserUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUsername.Text) && String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please select a user to edit.\nDouble click on a record to auto-fill the users information. You may not enter the user details manually.", "Nothing to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                user.Username = txtUsername.Text;
                user.FirstName = txtFirstName.Text;
                user.Surname = txtSurname.Text;
                user.Email = txtEmail.Text;
                user.ContactNumber = txtCellNum.Text;

                string sql2 = "Select RoleID from Role where RoleName = @Name";
                cmd = new SqlCommand(sql2, conn);
                cmd.Parameters.AddWithValue("@Name", cmbRole.SelectedItem);

                conn.Open();
                dr = cmd.ExecuteReader();
                dr.Read();

                user.RoleID = int.Parse(dr[0].ToString());
                conn.Close();

                SqlCommand cmd2 = new SqlCommand();

                string sql3 = "Select UserPassword from AccountUser where UserID = @ID";
                cmd2 = new SqlCommand(sql3, conn);
                cmd2.Parameters.AddWithValue("@ID", txtUserID.Text);

                conn.Open();
                dr = cmd2.ExecuteReader();
                dr.Read();

                //figure out how to change
                //user.Password =dr[0].ToString();

                bool editsuccess = user.UpdateUser(user, int.Parse(txtUserID.Text));

                if (editsuccess)
                    MessageBox.Show(user.FirstName + " " + user.Surname + " edited successfully.", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("Failed to edit " + user.FirstName + " " +user.Surname + ". " + "\nTry again. If the problem persists, contact your administrator.", "Failed to edit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dr.Close();
                conn.Close();
                
                dgvUsers.DataSource = user.UserData();
                ClearTextBoxes();
            }
        }
        private void ClearTextBoxes()
        {
            txtUserID.Clear();
            txtUsername.Clear();
            txtFirstName.Clear();
            txtSurname.Clear();
            txtEmail.Clear();
            txtCellNum.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserID.Text))
                MessageBox.Show("Please select a user to delete. Double click a record to auto-fill the users information.", "Nothing to delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                user.Username = txtUsername.Text;
                user.FirstName = txtFirstName.Text;
                user.Surname = txtSurname.Text;

                bool deletesuccess;

                if (DialogResult.Yes == MessageBox.Show("Are you sure you want to delete " + user.FirstName + " " + user.Surname + "?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    deletesuccess = user.DeleteUser(int.Parse(txtUserID.Text));

                    if (deletesuccess)
                        MessageBox.Show(user.FirstName + " " + user.Surname + " deleted successfully", "Successfully deleted", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    else
                        MessageBox.Show("Failed to delete " + user.FirstName + " " + user.Surname + ". \nTry again. If the problem persists, contact your administrator.", "Failed to delete", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                }
                DataTable dt = user.UserData();
                dgvUsers.DataSource = dt;

                ClearTextBoxes();
            }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserSearch.Text))
                MessageBox.Show("Please enter a keyword to search for.", "Empty search", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DataTable dt = user.Search(txtUserSearch.Text);
                dgvUsers.DataSource = dt;
            }
        }

        private void btnViewAllUsers_Click(object sender, EventArgs e)
        {
            dgvUsers.DataSource = user.UserData();
        }
    }
}
