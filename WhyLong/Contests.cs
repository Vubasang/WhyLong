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
    public partial class Contests : Form
    {
        public Contests()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            ResultContest_1 f = new ResultContest_1();
            f.ShowDialog();
        }
    }
}
