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
    public partial class frmAdmin : Form
    {
        UserRole r = new UserRole();
        AccountUser user = new AccountUser();

        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        SqlConnection s;

        public frmAdmin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ReadToRoleCmb();
        }
        private void ReadToRoleCmb()
        {
            s = new SqlConnection(myconnstring);

            SqlCommand sql = new SqlCommand("select RoleName from Role", s);

            s.Open();
            dr = sql.ExecuteReader();

            while (dr.Read())
            {
                cmbRole.Items.Add(dr[0]);

            }
            dr.Close();
            s.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFName.Text))
            {
                MessageBox.Show("Please enter a First Name.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtSurname.Text))
            {
                MessageBox.Show("Please enter a Surname.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtUsername.Text))
            {
                MessageBox.Show("Please enter a Userame.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Are you sure you want to leave an Email out?", "Empty field", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtContact.Text))
            {
                MessageBox.Show("Please enter a Contact Number.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please enter a Password.", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (String.IsNullOrEmpty(txtConfirmPassword.Text) || txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Passwords do not match", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cmbRole.SelectedItem == null)
            {
                MessageBox.Show("Please select a user Role", "Empty field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                user.FirstName = txtFName.Text;
                user.Surname = txtSurname.Text;
                SqlConnection conn = new SqlConnection(myconnstring);

                try
                {
                    string sql = "select Username from AccountUser where Username = '" + txtUsername.Text + "'";
                    SqlDataAdapter ad = new SqlDataAdapter(sql, conn);
                    DataSet ds = new DataSet();
                    ad.Fill(ds);

                    if (ds.Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Username already taken. Please choose a unique username", "Usename taken.");
                    }
                    else
                    {
                        user.Username = txtUsername.Text;

                        user.Email = txtEmail.Text;
                        user.ContactNumber = txtContact.Text;
                        user.Password = txtPassword.Text;

                        string sql2 = "Select RoleID from Role where RoleName = @Name";
                        cmd = new SqlCommand(sql2, conn);
                        cmd.Parameters.AddWithValue("@Name", cmbRole.SelectedItem);

                        conn.Open();
                        dr = cmd.ExecuteReader();
                        dr.Read();
                        user.RoleID = int.Parse(dr[0].ToString());

                        if (user.InsertData(user))
                            MessageBox.Show("User successfully added", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ClearUserTextBoxes();

                        DataTable dt = user.UserData();
                        conn.Close();
                    }
                   
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                
            }

        }

        private void btnUserClear_Click(object sender, EventArgs e)
        {
            ClearUserTextBoxes();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


         private void btnUsers_Click(object sender, EventArgs e)
        {
            frmCurrentUsers u = new frmCurrentUsers();
            this.Hide();
            u.ShowDialog();
        }

        private void ClearUserTextBoxes()
        {
            txtEmail.Clear();
            txtFName.Clear();
            txtSurname.Clear();
            txtContact.Clear();
            txtConfirmPassword.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
        }

        private void ClearPasswordTextBoxes()
        {
            txtNewPassword.Clear();
            txtCurrPassword.Clear();
            txtUsernameNew.Clear();
            txtConfirmNewPass.Clear();
        }

        private void btnClearPasswords_Click(object sender, EventArgs e)
        {
            ClearPasswordTextBoxes();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            frmDashboard d = new frmDashboard();
            d.Show();

        }

        private void btnSaveNewPassword_Click(object sender, EventArgs e)
        {
            s = new SqlConnection(myconnstring);

            string query = "Select Count(*) from AccountUser where (Username = @User)";
            cmd = new SqlCommand(query, s);
            cmd.Parameters.AddWithValue("@User", txtUsernameNew.Text);

            s.Open();

            int UserExist = (int)cmd.ExecuteScalar();

            if(UserExist > 0) // if they for sure exist
            {

                string query2 = "Select UserPassword from AccountUser where Username = @User";
                cmd = new SqlCommand(query2, s);
                cmd.Parameters.AddWithValue("@User", txtUsernameNew.Text);

                
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr[0].ToString() != txtCurrPassword.Text)
                    MessageBox.Show("Incorrect Password.");
                else
                {
                    if(txtNewPassword.Text == txtConfirmNewPass.Text)
                    {
                        user.UpdatePassword(txtUsernameNew.Text, txtConfirmNewPass.Text);
                        MessageBox.Show("Password changed successfully.");
                    }
                    else
                    {
                        MessageBox.Show("New passwords do not match.");                           
                    }
                }
            }
            else
            {
                MessageBox.Show("This username does not exist.", "Record not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearPasswordTextBoxes();

            }
            s.Close();

        }

        private void btnCreateRole_Click(object sender, EventArgs e)
        {
            frmRole frm = new frmRole();
            this.Hide();
            frm.ShowDialog();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmProduct f = new frmProduct();
            this.Hide();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers();
            this.Hide();
            frm.ShowDialog();
        }

        private void btnUnregisteredMembers_Click(object sender, EventArgs e)
        {
            frmUnregisteredMembers frm = new frmUnregisteredMembers();
            this.Hide();
            frm.ShowDialog();
        }
    }
}
