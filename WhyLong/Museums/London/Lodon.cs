﻿using System;
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

        private void Label6_Click(object sender, EventArgs e)
        {
            Музей_Шерлока_Холмса f = new Музей_Шерлока_Холмса();
            f.ShowDialog();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Музей_Шерлока_Холмса f = new Музей_Шерлока_Холмса();
            f.ShowDialog();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            Музей_Виктории_и_Альберта f = new Музей_Виктории_и_Альберта();
            f.ShowDialog();
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            Музей_Виктории_и_Альберта f = new Музей_Виктории_и_Альберта();
            f.ShowDialog();
        }

        private void Label16_Click(object sender, EventArgs e)
        {
            Национальная_галерея f = new Национальная_галерея();
            f.ShowDialog();
        }

        private void Label15_Click(object sender, EventArgs e)
        {
            Национальная_галерея f = new Национальная_галерея();
            f.ShowDialog();
        }

        private void Label14_Click(object sender, EventArgs e)
        {
            Музей_игрушек_Поллока f = new Музей_игрушек_Поллока();
            f.ShowDialog();
        }

        private void Label13_Click(object sender, EventArgs e)
        {
            Музей_игрушек_Поллока f = new Музей_игрушек_Поллока();
            f.ShowDialog();
        }

        private void Label12_Click(object sender, EventArgs e)
        {
            Музей_детства f = new Музей_детства();
            f.ShowDialog();
        }

        private void Label11_Click(object sender, EventArgs e)
        {
            Музей_детства f = new Музей_детства();
            f.ShowDialog();
        }

        private void Label10_Click(object sender, EventArgs e)
        {
            Галерея_Тейт f = new Галерея_Тейт();
            f.ShowDialog();
        }

        private void Label9_Click(object sender, EventArgs e)
        {
            Галерея_Тейт f = new Галерея_Тейт();
            f.ShowDialog();
        }
    }
}
