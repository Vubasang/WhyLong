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

namespace WhyLong
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 newForm = new Form1();
            newForm.Show();
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            Registration newForm = new Registration();
            newForm.Show();
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAL0KGO\SQLEXPRESS;Initial Catalog=WhyLong;Integrated Security=True");
            try
            {
                conn.Open();
                string login = txtLogin.Text;
                string password = txtPassword.Text;

                String Err = string.Empty;
                if(login == string.Empty)
                {
                    MessageBox.Show("Введите ваш логин", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (password == string.Empty)
                    {
                        MessageBox.Show("Введите ваш пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string sql = "select *from Users where UserName='" + login + "' and Password='" + password + "'";
                        SqlCommand cmd = new SqlCommand(sql, conn);
                        SqlDataReader data = cmd.ExecuteReader();
                        if (data.Read() == true)
                        {
                            Form1 newForm = new Form1();
                            newForm.Show();
                            txtLogin.Text = "";
                            txtPassword.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Неправильное имя пользователя или пароль", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка подключения", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
