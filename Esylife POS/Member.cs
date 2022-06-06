using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esylife_POS
{
    class Member
    {
        public Member()
        {

        }

        public string BM_Number { get; set; }
        public int MemberNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public int ContactNum { get; set; }
        public string Sponsor { get; set; }
        public string IDNumber { get; set; }

        static string myconnstring = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;
        SqlConnection conn = new SqlConnection(myconnstring);

        public DataTable SelectUnregisteredMembers()
        {

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT MemberNumber, ID_Number, Name, Surname, Contact_Number, Sponsor, BM_Number FROM Member WHERE BM_Number = 'BM0'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable SelectAllData()
        {

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Member";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public bool InsertData(Member m)
        {
            bool isSuccess = false;

            try
            {
                string sql = "INSERT INTO Member (BM_Number, Name, Surname, ID_Number, Contact_Number, Sponsor)" +
                    "VALUES (@BM_Number, @Name, @Surname, @ID_Number, @Contact_Number, @Sponsor)";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BM_Number", m.BM_Number);
                cmd.Parameters.AddWithValue("@Name", m.FirstName);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@ID_Number", m.IDNumber);
                cmd.Parameters.AddWithValue("@Contact_Number", m.ContactNum);
                cmd.Parameters.AddWithValue("@Sponsor", m.Sponsor);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }

        public bool UpdateData(Member m)
        {
            bool isSuccess = false;

            try
            {
                string sql = "UPDATE Member SET BM_Number = @BM_Number, Name = @Name, Surname = @Surname, ID_Number = @ID_Number, Contact_Number = @Contact_Number, Sponsor = @Sponsor " +
                    "WHERE MemberNumber = @MemberNum";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BM_Number", m.BM_Number);
                cmd.Parameters.AddWithValue("@Name", m.FirstName);
                cmd.Parameters.AddWithValue("@Surname", m.Surname);
                cmd.Parameters.AddWithValue("@ID_Number", m.IDNumber);
                cmd.Parameters.AddWithValue("@Contact_Number", m.ContactNum);
                cmd.Parameters.AddWithValue("@Sponsor", m.Sponsor);
                cmd.Parameters.AddWithValue("@MemberNum", m.MemberNumber);


                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }

        public bool DeleteData(string bm)
        {
            bool isSuccess = false;
            try
            {
                string sql = "DELETE FROM Member WHERE BM_Number = @BM_Number";

                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@BM_Number", bm);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
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
            return isSuccess;
        }

        public DataTable Search(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "select * from Member where Name like '%' + @keyword + '%' or Surname like '%' + @keyword + '%' or BM_Number like '%' + @keyword + '%'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable SelectMemberInfoSummary()
        {

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT BM_Number, Name, Surname, Sponsor FROM Member";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }

        public DataTable SearchMemberSummary(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "select BM_Number, Name, Surname, Sponsor from Member where Name like '%' + @keyword + '%' or Surname like '%' + @keyword + '%' or BM_Number like '%' + @keyword + '%'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public DataTable SearchUnregisteredMember(string keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                string sql = "select MemberNumber, ID_Number, Name, Surname, Contact_Number, Sponsor, BM_Number from Member where Name like '%' + @keyword + '%' or Surname like '%' + @keyword + '%' or BM_Number like '%' + @keyword + '%'";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@keyword", keyword);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
    }
}
