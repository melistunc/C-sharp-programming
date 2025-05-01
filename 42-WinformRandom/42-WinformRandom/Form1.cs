using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _42_WinformRandom
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random(); // random sınıfından nesne ürettik.
            int rastgelesayi1 = rnd.Next(1, 5); // 1 ile 5 arasında bir sayı ver rastegele olarak burada 5 dahil değil.
            label1.Text = rastgelesayi1.ToString();
        }
    }
}
