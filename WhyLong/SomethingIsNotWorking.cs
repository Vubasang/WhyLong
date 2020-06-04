using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
namespace WhyLong
{
    public partial class SomethingIsNotWorking : Form
    {
        string conStr = "Data Source = DESKTOP-TAL0KGO\\SQLEXPRESS; Initial Catalog = WhyLong; Integrated Security=true";
        DataTable dtNewThread;
        NewThreadBLL bllNewThread;
        public SomethingIsNotWorking()
        {
            InitializeComponent();
            bllNewThread = new NewThreadBLL();
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("topicTitle");
            dt.Columns.Add("Topic");
            dt.Columns.Add("Answer");
            return dt;
        }
        public void ShowAllNewThread()
        {
            DataTable dt = bllNewThread.getAllNewThread();
            dataGridView1.DataSource = dt;
        }
        private void SomethingIsNotWorking_Load(object sender, EventArgs e)
        {
            dtNewThread = createTable();
            ShowAllNewThread();
        }
        private void Panel1_Click(object sender, EventArgs e)
        {
            newThread f = new newThread();
            f.ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            newThread f = new newThread();
            f.ShowDialog();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            newThread f = new newThread();
            f.ShowDialog();
        }
    }
}
