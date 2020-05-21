using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WhyLong
{
    class DataConnection
    {
        string conStr;
        public DataConnection()
        {
            conStr = "Data Source = DESKTOP-TAL0KGO\\SQLEXPRESS; Initial Catalog = WhyLong; Integrated Security=true";
        }
        public SqlConnection getConnect()
        {
            return new SqlConnection(conStr);
        }
    }
}
