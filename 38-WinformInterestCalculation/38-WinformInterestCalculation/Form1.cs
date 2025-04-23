using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _38_WinformInterestCalculation
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double anapara = Convert.ToDouble(textBox1.Text);
            double faizorani = Convert.ToDouble(textBox2.Text) / 100; // yüzdelik olarak vermesi için 100'e böldük.
            int sure = int.Parse(textBox3.Text);

            double toplamfaiz = FaizHesapla(anapara, faizorani, sure);
            double odenecektutar = anapara + toplamfaiz;

            label5.Text = toplamfaiz.ToString();
            label7.Text = odenecektutar.ToString();
        }
        private double FaizHesapla (double anapara, double faizorani, int sure)
        {
            return anapara * faizorani * sure;
        }
    }
}
