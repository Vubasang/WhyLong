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
    public partial class newThread : Form
    {
        public newThread()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txttopicTitle.Text == "")
            {
                MessageBox.Show("Пожадуйста, введите заголовок темы", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtTopic.Text == "")
                {
                    MessageBox.Show("Пожадуйста, введите тему", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAL0KGO\SQLEXPRESS;Initial Catalog=WhyLong;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[newThread]
                        ([topicTitle]
                        ,[Topic])
                    VALUES
                        ('" + txttopicTitle.Text + "', '" + txtTopic.Text + "' )", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Ваша тема создана. Спасибо вам большое!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ошибка подключения", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        void Clear()
        {
            txttopicTitle.Text = txtTopic.Text = "";
        }
    }
}
