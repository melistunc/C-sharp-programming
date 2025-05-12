using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _58_FolderAndFileOperations7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // metin belgesi (txt) veri kaydetme

            //saveFildeDialog dosyayı kaydettiğimiz zamanlar kullanırız.

            saveFileDialog1.Filter = "Metin Dosyaları |*.txt "; // filtreleme yapıyoruz. uzantısı txt olan tüm programlamları getir diyoruz. İlk önce filtreleme işini yapıp daha sonra dosyaları göster diyoruz. Böylece sadece txt uzantılarını görürüz dosya klasörlerinde.
            saveFileDialog1.Title = "Metin dosyası kaydet";
            saveFileDialog1.ShowDialog(); // dosya kısmı yani dosya pencerelerini görüntemek için açıyoruz.

            // burada richboxtext içine yazacaklarımızı txt'ye vermemiz gerekiyor.
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName); // bu class ile text'leri okuyup yazdırtabiliyoruz. nesne türetiyoruz bu class'tan. parametre olarak hangi dosyayı kullanacağımızı istiyor. buraya savefiledilogtan gelen dosya adını veriyoruz parametreye.
            sw.WriteLine(richTextBox1.Text); // richboxtext'ten gelen text'i buraya yazdır.
            sw.Close(); // ile bu işlemi kapatıyoruz ki sonradan kullanabilelim.

            MessageBox.Show("Kaydedildi.");

        }
    }
}
