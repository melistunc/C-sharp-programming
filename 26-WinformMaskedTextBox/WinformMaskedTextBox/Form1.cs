﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformMaskedTextBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // formatlı textbox'tır yani phone number, date, time gibi formatlı bilgi girişlerinin yazılıp alınmasını sağlar.

            string telefon = maskedTextBox1.Text;
            string tarih = maskedTextBox2.Text;
            string tc = maskedTextBox3.Text;
            string saat = maskedTextBox4.Text;

            listBox1.Items.Add(telefon +" "+ tarih+ " "+ tc + " " + saat);
        }
    }
}
