using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelandButton
{
    public partial class Form1: Form
    {
        public Form1() // kurucu metot. class'ta ilk burası çalışır.
        {
            InitializeComponent(); // bu kısım otomatik çalışır ilk çalışan yer burasıdır. burası gerekli çalıştırmaları başlangıçta sağlar.
        }

        private void button1_Click(object sender, EventArgs e) // butona basılınca çıkan metot. Buton'a basılınca yapılan işlemleri buraya yazarız.
        {
            label1.Text = "Butona tıkladın"; // text ile direkt atama yapabiliriz bir prop sunar (get set). text ile label1 tool'suna yazı yazarız. burada label'a "butona tıkladın" yazısını yazdık. burası buton tıklandığında çalışır. label  genel olarak bir yazı yazar.

            //button tıklandıgında bir eylemi gerçekleştirir.
        }

        private void label1_Click(object sender, EventArgs e)
        {
            button1.Text = "label'a tıkladın"; // label'a tıkladığımızda button'da "label'a tıkladınız" yazacak.
        }
    }
}
