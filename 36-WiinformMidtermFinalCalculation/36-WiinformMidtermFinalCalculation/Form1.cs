using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _36_WiinformMidtermFinalCalculation
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vize = Convert.ToDouble(textBox1.Text);
            double final = Convert.ToDouble(textBox2.Text);

            double ortalama = 0;

            ortalama = (vize *0.40) + (final * 0.60);

            label4.Text = ortalama.ToString();
        }
    }
}
