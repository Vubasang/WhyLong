using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhyLong
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ГоллToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void МузейToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ОСайтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            aboutUs f = new aboutUs();
            f.ShowDialog();
        }

        private int i = 10;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            label1.Location = new Point(label1.Location.X + i, label1.Location.Y);
            if (label1.Location.X > 820 || label1.Location.X <= 0)
            {
                i = -i;
            }
        }
    }
}
