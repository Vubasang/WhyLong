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
using System.IO;

namespace WhyLong
{
    public partial class AddArtists : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-TAL0KGO\SQLEXPRESS;Initial Catalog=WhyLong;Integrated Security=True");
        public AddArtists()
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
        private void Button2_Click(object sender, EventArgs e)
        {
            byte[] b = ImageToByteArray(pictureBox1.Image);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Artists values(@FullName,@YearOfBirth, @PlaceOfBirth, @Biography, @Image," +
                "@ExhibitionList, @ProjectList, @ListOfPublications)", conn);
            cmd.Parameters.Add("@FullName", txtFullName.Text);
            cmd.Parameters.Add("@YearOfBirth", dttYearOfBirth.Value.Date.ToString());
            cmd.Parameters.Add("@PlaceOfBirth", txtPlaceOfBirth.Text);
            cmd.Parameters.Add("@Biography", txtBiography.Text);
            cmd.Parameters.Add("@Image", b);
            cmd.Parameters.Add("@ExhibitionList", txtExhibitionList.Text);
            cmd.Parameters.Add("@ProjectList", txtProjectList.Text);
            cmd.Parameters.Add("@ListOfPublications", txtListOfPublications.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Спасибо, вы добавили информацию худождника!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
