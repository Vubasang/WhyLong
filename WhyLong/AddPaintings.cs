using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhyLong
{
    public partial class AddPaintings : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAL0KGO\SQLEXPRESS;Initial Catalog=WhyLong;Integrated Security=True");
        public AddPaintings()
        {
            InitializeComponent();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(open.FileName);
                this.Text = open.FileName;
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(pictureBox1.Image);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Paintings values(@NameOfThePicture, @Picture, @Resolution, @Author, @WhereIs)", conn);
            cmd.Parameters.Add("@NameOfThePicture", txtNameOfThePicture.Text);
            cmd.Parameters.Add("@Picture", b);
            cmd.Parameters.Add("@Resolution", txtResolution.Text);
            cmd.Parameters.Add("@Author", txtAuthor.Text);
            cmd.Parameters.Add("@WhereIs", txtWhereIs.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Спасибо, вы добавили картинку!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        byte[] ImageToByteArray(Image img)
        {
            MemoryStream m = new MemoryStream();
            img.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            return m.ToArray();
        }
    }
}
