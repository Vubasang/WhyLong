using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WhyLong
{
    class AdminsDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public AdminsDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllAdmins()
        {
            string sql = "select * from Admins";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public bool InsertAdmins(Admins admins)
        {
            string sql = "INSERT INTO Admins(CodeEmployee, FullName, YearOfBirth, Gender, Email, Phone, UserName, Password, Address, Position) VALUES(@CodeEmployee, @FullName, @YearOfBirth, @Gender, @Email, @Phone, @UserName, @Password, @Address, @Position)";
            SqlConnection con = dc.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@CodeEmployee", SqlDbType.NVarChar).Value = admins.CodeEmployee;
                cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = admins.FullName;
                cmd.Parameters.Add("@YearOfBirth", SqlDbType.DateTime).Value = admins.YearOfBirth;
                cmd.Parameters.Add("@Gender", SqlDbType.Char).Value = admins.Gender;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = admins.Email;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = admins.Phone;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = admins.UserName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = admins.Password;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = admins.Address;
                cmd.Parameters.Add("@Position", SqlDbType.NVarChar).Value = admins.Position;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool UpdateAdmins(Admins admins)
        {
            string sql = "update Admins set CodeEmployee = @CodeEmployee, FullName = @FullName, YearOfBirth = @YearOfBirth, Gender = @Gender, " +
                "Email = @Email, Phone = @Phone, UserName = @UserName, Password = @Password, Address = @Address, Position = @Position where ID = @ID";
            SqlConnection con = dc.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = admins.ID;
                cmd.Parameters.Add("@CodeEmployee", SqlDbType.NVarChar).Value = admins.CodeEmployee;
                cmd.Parameters.Add("@FullName", SqlDbType.NVarChar).Value = admins.FullName;
                cmd.Parameters.Add("@YearOfBirth", SqlDbType.DateTime).Value = admins.YearOfBirth;
                cmd.Parameters.Add("@Gender", SqlDbType.Char).Value = admins.Gender;
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = admins.Email;
                cmd.Parameters.Add("@Phone", SqlDbType.NVarChar).Value = admins.Phone;
                cmd.Parameters.Add("@UserName", SqlDbType.VarChar).Value = admins.UserName;
                cmd.Parameters.Add("@Password", SqlDbType.VarChar).Value = admins.Password;
                cmd.Parameters.Add("@Address", SqlDbType.NVarChar).Value = admins.Address;
                cmd.Parameters.Add("@Position", SqlDbType.NVarChar).Value = admins.Position;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public bool DeleteAdmins(Admins admins)
        {
            string sql = "delete Admins where ID = @ID";
            SqlConnection con = dc.getConnect();

            try
            {
                cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.Parameters.Add("@ID", SqlDbType.BigInt).Value = admins.ID;
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e)
            {
                return false;
            }
            return true;
        }
        public DataTable FindCode(string admin)
        {
            string sql = "SELECT * from Admins WHERE CodeEmployee like'%" + admin + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable FindFullName(string admin)
        {
            string sql = "SELECT * from Admins WHERE FullName like'%" + admin + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable FindYearOfBirth(string admin)
        {
            string sql = "SELECT * from Admins WHERE YearOfBirth like'%" + admin + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable FindGender(string admin)
        {
            string sql = "SELECT * from Admins WHERE Gender like'%" + admin + "%'";
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
            string sql = "SELECT * from Admins WHERE Email like'%" + admin + "%'";
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
            string sql = "SELECT * from Admins WHERE Phone like'%" + admin + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable FindAddress(string admin)
        {
            string sql = "SELECT * from Admins WHERE Address like'%" + admin + "%'";
            SqlConnection con = dc.getConnect();
            da = new SqlDataAdapter(sql, con);
            con.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public DataTable FindPosition(string admin)
        {
            string sql = "SELECT * from Admins WHERE Position like'%" + admin + "%'";
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
