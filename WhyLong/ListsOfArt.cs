using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhyLong
{
    public partial class ListsOfArt : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAL0KGO\SQLEXPRESS;Initial Catalog=WhyLong;Integrated Security=True");
        public ListsOfArt()
        {
            InitializeComponent();
            LoadData();
        }
        void LoadData()
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Paintings", conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
