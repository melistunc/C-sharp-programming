using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _34_WinformAddingTwoNumbersReceivedFromtheUser
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);

            int toplam = 0;

            toplam = sayi1 + sayi2;

            label4.Text = toplam.ToString(); // text metodum string olduğu için int türündeki toplam değişkenini string'e çeviririz.
        }
    }
}
