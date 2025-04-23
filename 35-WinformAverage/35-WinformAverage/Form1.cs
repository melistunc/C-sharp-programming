using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _35_WinformAverage
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ders1 = int.Parse(textBox1.Text);
            int ders2 = int.Parse(textBox2.Text);

            int ortalama = 0;

            ortalama = (ders1 + ders2) / 2;

            label4.Text = ortalama.ToString();
        }
    }
}
