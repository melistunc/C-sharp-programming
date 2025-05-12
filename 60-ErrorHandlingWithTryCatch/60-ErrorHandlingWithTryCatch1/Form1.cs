using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _60_ErrorHandlingWithTryCatch1
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // try-catch kullanıcıya hata mesajı göstermeye yarar. dene-yakala.

            try // hangi kodları çalıştıracaksak onları çalıştırırız. dene
            {
                int sayi = int.Parse(textBox1.Text);
                MessageBox.Show(sayi.ToString());
            }
            catch (FormatException fex) //formateception girilen değerin hangi formatta yazılması gerekiyorsa onunla ilgili bir hata olduğunu söylüyor.
            {
                MessageBox.Show($"Sayısal bir değer giriniz {fex.Message}"); // alttakine göre daha daralttık. alttaki exception tüm hataları içeriyor format, boşuk vs. Ama format exception sadece format ile hataları yakalar. Eğer önce alttaki exception'ı yazarsak hata alırız yani der ki zaten exception'da tüm hataları yakalıyorsun formatexception'a gerek yok der o yüzden bunu ilk yazarız.
            }
            catch (Exception ex) // hata bulma sonucunda hatayı buraya yazdırırız. hata yazdır. ex bizim veridğimiz isim. exception, hatalarımızın tümünü içeren sınıf. biz bu sınıftan mesaj diyerek hatanın mesajını alabiliyoruz.  
            {
                MessageBox.Show($"Sistemde bir hata oluştu. {ex.Message}"); // ex'ten gelen hatayı yazdır diyoruz.
                
            }
            finally // try'da da olsa catch'te de olsa düzgün çalışsa da hata alsa da almasa da buradaki finally'i bir kere çalışır.
            {
                MessageBox.Show("Finally Çalıştı");
            }
        }
    }
}
