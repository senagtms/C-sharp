﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurcyukselenHesabı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gun;
        int ay;
        
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
            gun = Convert.ToInt16( dateTimePicker1.Value.Day);
            ay = Convert.ToInt16(dateTimePicker1.Value.Month);
            if ((ay == 1 && gun > 20) || (ay == 2 && gun < 20))
                textBox1.Text = "Kova";
            else if ((ay == 2 && gun > 18) || (ay == 3 && gun < 21))
                textBox1.Text = "Balık";
            else if ((ay == 3 && gun > 20) || (ay == 4 && gun < 21))
                textBox1.Text = "Koç";
            else if ((ay == 4 && gun > 20) || (ay == 5 && gun < 22))
                textBox1.Text = "Boğa";
            else if ((ay == 5 && gun > 21) || (ay == 6 && gun < 22))
                textBox1.Text = "İkizler";
            else if ((ay == 6 && gun > 21) || (ay == 7 && gun < 24))
                textBox1.Text = "Yengeç";
            else if ((ay == 7 && gun > 23) || (ay == 8 && gun < 24))
                textBox1.Text = "Aslan";
            else if ((ay == 8 && gun > 23) || (ay == 9 && gun < 24))
                textBox1.Text = "Başak";
            else if ((ay == 9 && gun > 23) || (ay == 10 && gun < 24))
                textBox1.Text = "Terazi";
            else if ((ay == 10 && gun > 23) || (ay == 11 && gun < 23))
                textBox1.Text = "Akrep";
            else if ((ay == 11 && gun > 22) || (ay == 12 && gun < 23))
                textBox1.Text = "Yay";
            else if ((ay == 12 && gun > 22) || (ay == 1 && gun < 21))
                textBox1.Text = "Oğlak";

        }
    }
}
