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

namespace WhyLong.Users
{
    public partial class ListOfUsers : Form
    {
        string conStr = "Data Source = DESKTOP-TAL0KGO\\SQLEXPRESS; Initial Catalog = WhyLong; Integrated Security=true";
        DataTable dtUsers;
        UsersBLL bllUsers;
        public ListOfUsers()
        {
            InitializeComponent();
            bllUsers = new UsersBLL();
        }
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("FullName");
            dt.Columns.Add("Phone");
            dt.Columns.Add("Email");
            dt.Columns.Add("UserName");
            dt.Columns.Add("Password");
            return dt;
        }
        public void ShowAllUsers()
        {
            DataTable dt = bllUsers.getAllUsers();
            dataGridView1.DataSource = dt;
        }
        private void ListOfUsers_Load(object sender, EventArgs e)
        {
            dtUsers = createTable();
            ShowAllUsers();
        }
        public void load()
        {
            SqlConnection conn = new SqlConnection(conStr);
            try
            {
                conn.Open();
                string sql = "select *from Users";
                SqlDataAdapter dt = new SqlDataAdapter(sql, conn);
                DataTable tb = new DataTable();
                dt.Fill(tb);
                dataGridView1.DataSource = tb;
            }
            catch (Exception e)
            {
                MessageBox.Show("Произошла ошибка:" + e.Message);
            }
        }
        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = dataGridView1.CurrentRow.Index;
            if (Index >= 0)
            {
                txtFullName.Text = dataGridView1.Rows[Index].Cells["FullName"].Value.ToString();
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult notification;
            notification = MessageBox.Show("Вы хотите удалить этого пользователя?", "Сообщение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (notification == DialogResult.OK)
            {
                SqlConnection conn = new SqlConnection(conStr);
                conn.Open();
                string sql = "delete from Users where FullName like '%" + txtFullName.Text + "%'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Успешно удалить!");
                load();
                conn.Close();
            }
        }

        private void TxtFindFullName_TextChanged(object sender, EventArgs e)
        {
            string value = txtFindFullName.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllUsers.FindFullName(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllUsers();
        }

        private void TxtFindPhone_TextChanged(object sender, EventArgs e)
        {
            string value = txtFindPhone.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllUsers.FindPhone(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllUsers();
        }

        private void TxtFindEmail_TextChanged(object sender, EventArgs e)
        {
            string value = txtFindEmail.Text;
            if (!string.IsNullOrEmpty(value))
            {
                DataTable dt = bllUsers.FindEmail(value);
                dataGridView1.DataSource = dt;
            }
            else
                ShowAllUsers();
        }
    }
}
