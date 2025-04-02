using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormEntry2
{
    public partial class Form1: Form // form'dan kalıtım almış. Form1 isimli class.
    {
        public Form1() // yapıcı metot, compenentleri initilaze ediyor.
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ismi button1_click'tir. button1'e click olduğunda anlamında. button1, form üzerinde oluşturduğumuz button'un ismidir.


            // form çalıştırıldıktan sonra tıkla butonuna bastığımızda ekrana bir mesaj gelsin.
            MessageBox.Show("Butona tıkladım"); // messagebox cw gibi çalışır. yazdığımız metin vs ekranda gösterir.Mesaj kutusunu göster. Böylece form çalıştığında butona tıkladığında ekrana butona tıkladım mesajı gelecek.
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // form'un kodu yani Form'a çift tıkladığımızda gelen kod. Burası Form1 yüklendiğinde ne olacak anlamına gelir.

            MessageBox.Show("Form başarıyla yüklendi");//burada start yaptığımızda ilk önce ekrana "Form başarıyla yüklendi" kutucuğu gelir. "Tamam" dediğimizde bize Form ekranını getirir (button'lu olan). Burada Button'a bastığımız zaman da "Butona tıkladım" yazar. 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button2'ye tıkladım.");
        }
    }
}
