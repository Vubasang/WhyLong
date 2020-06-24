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
    public partial class Idea : Form
    {
        public Idea()
        {
            InitializeComponent();
        }

        private void Idea_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(850, 1002);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtIdeas.Text == "")
            {
                MessageBox.Show("Пожадуйста, укажите Ваши идеи и предложения", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (txtWishes.Text == "")
                {
                    MessageBox.Show("Пожадуйста, укажите Ваши пожелания", "Запрос", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    try
                    {
                        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAL0KGO\SQLEXPRESS;Initial Catalog=WhyLong;Integrated Security=True");
                        SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[Ideas]
                        ([FullName]
                        ,[Phone]
                        ,[Email]
                        ,[IdeasAndSuggestions]
                        ,[userWishes]
                        ,[NotesStudioWork])
                    VALUES
                        ('" + txtFullName.Text + "', '" + txtPhone.Text + "', '" + txtEmail.Text + "', '" + txtIdeas.Text + "', '" + txtWishes.Text + "', '" + txtNotes.Text + "' )", conn);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Идеи и предложения отправлены. Спасибо вам большое!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        void Clear()
        {
            txtFullName.Text = txtPhone.Text = txtEmail.Text = txtIdeas.Text = txtWishes.Text = txtNotes.Text = "";
        }
    }
}
