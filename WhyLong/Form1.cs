﻿using System;
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
        public UserContext DB { get; set; }
        public Person User { get; set; }
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

        private void РегистрацияToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registration f = new Registration();
            f.ShowDialog();
        }

        private void ВойтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Authorization f = new Authorization();
            f.ShowDialog();
        }

        private void КонтактыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contacts f = new contacts();
            f.ShowDialog();
        }

        private void НашиСотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ourEmployees f = new ourEmployees();
            f.ShowDialog();
        }

        private void ПоддержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            support f = new support();
            f.ShowDialog();
        }

        private void РекламаНаСайтеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            advertisement f = new advertisement();
            f.ShowDialog();
        }

        private void ТехподдержкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            technicalSupport f = new technicalSupport();
            f.ShowDialog();
        }

        private void ЕстьИдеяИлиПредложениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idea f = new Idea();
            f.ShowDialog();
        }

        private void ЧтотоНеРаботаетИлиНайденаОшибкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SomethingIsNotWorking f = new SomethingIsNotWorking();
            f.ShowDialog();
        }

        private void ВойтиДляСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForEmployees f = new LoginForEmployees();
            f.ShowDialog();
        }

        private void ЯкутскToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtExhibitions_Yakutsk f = new ArtExhibitions_Yakutsk();
            f.ShowDialog();
        }

        private void МоскваToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ArtExhibitions_Moscow f = new ArtExhibitions_Moscow();
            f.ShowDialog();
        }

        private void СанктПетербургToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArtExhibitions_Peterburg f = new ArtExhibitions_Peterburg();
            f.ShowDialog();
        }

        private void КакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PostInformationOnThePoster f = new PostInformationOnThePoster();
            f.ShowDialog();
        }

        private void АвишаВыставокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PosterExhibition f = new PosterExhibition();
            f.ShowDialog();
        }

        private void КонкурсыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contests f = new Contests();
            f.ShowDialog();
        }

        private void ЛондонToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Museums.London.Lodon f = new Museums.London.Lodon();
            f.ShowDialog();
        }

        private void списокСотрудниковToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.DB = this.DB;
            f.User = this.User;
            f.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void РусскиеХудожникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Artists.ArtistsRussia.Русские_художники f = new Artists.ArtistsRussia.Русские_художники();
            f.ShowDialog();
        }

        private void МоскваToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Museums.Moscow.Moscow f = new Museums.Moscow.Moscow();
            f.ShowDialog();
        }

        private void АРТКЛУToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListOfArtists f = new ListOfArtists();
            f.ShowDialog();
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ListsOfArt f = new ListsOfArt();
            f.ShowDialog();
        }
    }
}
