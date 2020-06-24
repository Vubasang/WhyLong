using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhyLong.Users
{
    class UsersDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public UsersDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllUsers()
        {
            string sql = "select * from Users";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertUsers(Users users)
        {
            string sql = "INSERT INTO Users(FullName, Phone, Email, UserName, Password) VALUES(@FullName, @Phone, @Email, @UserName, @Password)";
            SqlConnection con = dc.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = users.FullName;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = users.Phone;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = users.Email;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = users.UserName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = users.Password;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindFullName(string admin)
        {
            string sql = "SELECT * from Users WHERE FullName like'%" + admin + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable FindPhone(string admin)
        {
            string sql = "SELECT * from Users WHERE Phone like'%" + admin + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable FindEmail(string admin)
        {
            string sql = "SELECT * from Users WHERE Email like'%" + admin + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
