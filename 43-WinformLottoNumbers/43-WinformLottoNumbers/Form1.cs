using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _43_WinformLottoNumbers
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int s1, s2, s3, s4;

            s1 = rnd.Next(1,10);
            s2 = rnd.Next(1,10);
            s3 = rnd.Next(1,10);
            s4 = rnd.Next(1,10);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            int sayi1 = int.Parse(textBox1.Text);
            int sayi2 = int.Parse(textBox2.Text);
            int sayi3 = int.Parse(textBox3.Text);
            int sayi4 = int.Parse(textBox4.Text);

            if (sayi1 == s1)
            {
                label1.BackColor = Color.Green;
            }
            else
            {
                label1.BackColor= Color.Red;
            }

            if (sayi2 == s2)
            {
                label2.BackColor = Color.Green;
            }
            else
            {
                label2.BackColor = Color.Red;
            }
            if (sayi3 == s3)
            {
                label3.BackColor = Color.Green;
            }
            else
            {
                label3.BackColor = Color.Red;
            }
            if (sayi4 == s4)
            {
                label4.BackColor = Color.Green;
            }
            else
            {
                label4.BackColor = Color.Red;
            }

        }
    }
}
