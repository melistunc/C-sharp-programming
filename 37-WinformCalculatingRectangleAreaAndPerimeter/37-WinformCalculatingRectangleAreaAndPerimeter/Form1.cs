using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _37_WinformCalculatingRectangleAreaAndPerimeter
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int kisakenar = int.Parse(textBox1.Text);
            int uzunkenar = int.Parse(textBox2.Text);

            double cevre = CevreHesapla(kisakenar, uzunkenar);
            double alan = AlanGesapla(kisakenar,uzunkenar);

            label4.Text = cevre.ToString();
            label6.Text = alan.ToString();
        }

        private double CevreHesapla (double kisakenar, double uzunkenar)
        {
            return 2 * (kisakenar + uzunkenar);
        }

        private double AlanGesapla(double kisakenar, double uzunkenar)
        {
            return kisakenar * uzunkenar;
        }
    }
}
