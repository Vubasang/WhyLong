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
    public partial class siteManagement : Form
    {
        public siteManagement()
        {
            InitializeComponent();
        }

        private void СписокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfEmployees f = new ListOfEmployees();
            f.ShowDialog();
        }

        private void СписокПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Users.ListOfUsers f = new Users.ListOfUsers();
            f.ShowDialog();
        }

        private void ДобавитьХудожниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddArtists f = new AddArtists();
            f.ShowDialog();
        }

        private void ДобавитьКартинToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPaintings f = new AddPaintings();
            f.ShowDialog();
        }
    }
}
