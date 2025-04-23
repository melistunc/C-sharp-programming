using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_WinformTransitionBetweenFormsandDataTransfer
{
    public partial class Form3: Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 frm3 = new Form4();

            frm3.kimden = textBox1.Text; // form4'te oluşturduğumuz değişkenlere erişerek bu değişkenlere textbox'larımızı atadık. Böylece texbox'lara bir şeyler yazarsak form4 değişkenlerine atanır.
            frm3.mesaj = textBox2.Text;

            frm3.ShowDialog();
        }
    }
}
