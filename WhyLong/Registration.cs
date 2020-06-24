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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization newForm = new Authorization();
            newForm.Show();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            privacyPolicy f = new privacyPolicy();
            f.ShowDialog();
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            Authorization f = new Authorization();
            f.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Пожадуйста, заполните поле Логин", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtPassword.Text == "")
                {
                    MessageBox.Show("Пожадуйста, заполните поле Пароль", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtPassword.Text != txtConfirmPassword.Text)
                    {
                        MessageBox.Show("Введённые пароли не совпадают", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        try
                        {
                            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAL0KGO\SQLEXPRESS;Initial Catalog=WhyLong;Integrated Security=True");
                            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Users]
                        ([FullName]
                        ,[Phone]
                        ,[Email]
                        ,[UserName]
                        ,[Password])
                    VALUES
                        ('" + txtName.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtUserName.Text + "', '" + txtPassword.Text + "' )", conn);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("регистрация прошла успешно!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Clear();
                            Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ошибка подключения", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }
        void Clear()
        {
            txtName.Text = txtPhone.Text = txtEmail.Text = txtUserName.Text = txtPassword.Text = txtConfirmPassword.Text = "";
        }
    }
}
