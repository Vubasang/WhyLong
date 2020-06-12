using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhyLong.Museums.London
{
    public partial class Lodon : Form
    {
        public Lodon()
        {
            InitializeComponent();
        }

        private void Lodon_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Национальный_морской_музей f = new Национальный_морской_музей();
            f.ShowDialog();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Национальный_морской_музей f = new Национальный_морской_музей();
            f.ShowDialog();
        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Музей_Чарльза_ДиккенсаForm1 f = new Музей_Чарльза_ДиккенсаForm1();
            f.ShowDialog();
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Музей_Чарльза_ДиккенсаForm1 f = new Музей_Чарльза_ДиккенсаForm1();
            f.ShowDialog();
        }
    }
}
