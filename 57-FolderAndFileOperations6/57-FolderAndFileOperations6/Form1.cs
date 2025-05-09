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

namespace _57_FolderAndFileOperations6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string dosyakonum;
        string dosyadi;

        private void button1_Click(object sender, EventArgs e)
        {
            
            dosyakonum = folderBrowserDialog1.SelectedPath; // seçilen dosya yolunu al.
            
            dosyadi = textBox2.Text;

            FileStream dosya = File.Create(dosyakonum + @"\" + dosyadi + ".txt"); // nereye ne oluşturucam. Dosya oluşturacak. dosyakonumuna dosyadından adını aldıgın bir txt dosyası oluştur. Baglantı açılır. dosya değişkenine atıyoruz filestream turunde.
            dosya.Close(); // sonra dosyayı kapatırız ki dosyayı oluşturduktan sonra artık txt başka bi işlem için kullanılmasın diye.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            textBox1.Text = folderBrowserDialog1.SelectedPath ; // aldıgımız konumu textbox1'e yazdır.
        }
    }
}
