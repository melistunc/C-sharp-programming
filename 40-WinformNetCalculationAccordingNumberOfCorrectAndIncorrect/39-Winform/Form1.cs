using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _39_Winform
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double matdogru, matyanlis, matnet;
            double turkcedogru, turkceyanlis, turkcenet;
            double biyodogru, biyoyanlis, biyonet;

            matdogru = Convert.ToDouble(textBox1.Text);
            matyanlis = Convert.ToDouble(textBox4.Text);

            turkcedogru = Convert.ToDouble(textBox2.Text);
            turkceyanlis = Convert.ToDouble(textBox6.Text);

            biyodogru = Convert.ToDouble(textBox3.Text);
            biyoyanlis = Convert.ToDouble(textBox5.Text);

            matnet = matdogru - (matyanlis / 4);
            turkcenet = turkcedogru - (turkceyanlis / 4);
            biyonet = biyodogru - (biyoyanlis / 4);

            textBox7.Text = matnet.ToString();
            textBox8.Text = turkcenet.ToString();
            textBox9.Text = biyonet.ToString();
        }
    }
}
