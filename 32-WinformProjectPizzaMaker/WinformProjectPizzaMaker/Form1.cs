using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformProjectPizzaMaker
{
    public partial class Form1: Form
    {
        int fiyat = 0; // bu fiyat değişkenine her yerden erişmek istdeğimiz için tüm metotların dışında tanımladık.
        string pizzacesidi;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                fiyat += 200;
            }
            else
            {
                fiyat -= 200;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                fiyat += 250;
            }
            else
            {
                fiyat -= 250;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                fiyat += 150;
            }
            else
            {
                fiyat -= 150;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                fiyat += 300;
            }
            else
            {
                fiyat -= 300;
            }

            label16.Text = fiyat.ToString() + "Prize";
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                fiyat += 10;
            }
            else
            {
                fiyat -= 10;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                fiyat += 20;
            }
            else
            {
                fiyat -=20;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                fiyat += 30;
            }
            else
            {
                fiyat -= 30;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                fiyat += 3;
            }
            else
            {
                fiyat -= 3;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                fiyat += 1;
            }
            else
            {
                fiyat -= 1;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                fiyat += 8;
            }
            else
            {
                fiyat -= 8;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                fiyat += 15;
            }
            else
            {
                fiyat -= 15;
            }
            label16.Text = fiyat.ToString() + "Prize";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string soyad = textBox5.Text;
            string telefon = textBox2.Text;
            string adresbasligi = textBox6.Text;
            string adres = richTextBox1.Text;

            if (ad != "" && soyad!= "" && adresbasligi != "" && adres != "")
            {
                MessageBox.Show("Siparişiniz alındı.");
            }
            else
            {
                MessageBox.Show("Boş bırakmayınız.");
            }
        }
    }
}
