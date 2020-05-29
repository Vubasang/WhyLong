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
    public partial class technicalSupport : Form
    {
        public technicalSupport()
        {
            InitializeComponent();
        }

        private void TextBox1_Enter(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Введите Ваше ФИО")
            {
                txtFullName.Text = "";
                txtFullName.ForeColor = Color.Black;
            }
        }

        private void TextBox1_Leave(object sender, EventArgs e)
        {
            if (txtFullName.Text == "")
            {
                txtFullName.Text = "Введите Ваше ФИО";
                txtFullName.ForeColor = Color.Silver;
            }
        }

        private void TextBox2_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "Введите Ваш номер телефона")
            {
                txtPhone.Text = "";
                txtPhone.ForeColor = Color.Black;
            }
        }

        private void TextBox2_Leave(object sender, EventArgs e)
        {
            if (txtPhone.Text == "")
            {
                txtPhone.Text = "Введите Ваш номер телефона";
                txtPhone.ForeColor = Color.Silver;
            }
        }

        private void TextBox3_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Введите Ваш E-mail")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void TextBox3_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Введите Ваш E-mail";
                txtEmail.ForeColor = Color.Silver;
            }
        }

        private void TextBox4_Enter(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "Опишите Ваш вопрос")
            {
                txtQuestion.Text = "";
                txtQuestion.ForeColor = Color.Black;
            }
        }

        private void TextBox4_Leave(object sender, EventArgs e)
        {
            if (txtQuestion.Text == "")
            {
                txtQuestion.Text = "Опишите Ваш вопрос";
                txtQuestion.ForeColor = Color.Silver;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtFullName.Text == "Введите Ваше ФИО")
            {
                MessageBox.Show("Пожадуйста, укажите ваше ФИО", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtPhone.Text == "Введите Ваш номер телефона")
                {
                    MessageBox.Show("Пожадуйста, укажите ваш номер телефона", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (txtEmail.Text == "Введите Ваш E-mail")
                    {
                        MessageBox.Show("Пожалуйста, укажите Вашу почту", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (txtQuestion.Text == "Опишите Ваш вопрос")
                        {
                            MessageBox.Show("Пожалуйста, укажите Ваш вопрос", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            try
                            {
                                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAL0KGO\SQLEXPRESS;Initial Catalog=WhyLong;Integrated Security=True");
                                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[technicalSupport]
                        ([FullName]
                        ,[Phone]
                        ,[Email]
                        ,[userQuestion])
                    VALUES
                        ('" + txtFullName.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtQuestion.Text + "' )", conn);
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("Ваш вопрос отправлен! Наш специалист свяжется с вами в ближайшее время.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                //Clear();
                                this.Close();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Ошибка подключения", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }
        void Clear()
        {
            txtFullName.Text = txtPhone.Text = txtEmail.Text = txtQuestion.Text = "";
        }
    }
}
