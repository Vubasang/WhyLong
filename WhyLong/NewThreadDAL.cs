using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WhyLong
{
    class NewThreadDAL
    {
        DataConnection dc;
        SqlDataAdapter da;
        SqlCommand cmd;
        public NewThreadDAL()
        {
            dc = new DataConnection();
        }
        public DataTable getAllNewThread()
        {
            string sql = "select * from newThread";
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
