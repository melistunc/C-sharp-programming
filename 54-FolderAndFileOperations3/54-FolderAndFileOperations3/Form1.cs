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

namespace _54_FolderAndFileOperations3
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(); // tıkladıgımda dosya klasörleri açılacak. Benim seçtiğim dosya yoluna git -->
            bool durum = Directory.Exists(folderBrowserDialog1.SelectedPath + @"\Yeni"); // nereye kaydedeceksem onun yolunu tutmamız lazım. Bu exist diyor ki bana bir dosya yolu ver ben o dosya yoluna bakayım var mı yok mu sana söyleyeyim bool olarak true-false. yol olarak klasörde seçtiğimiz klasörün yolunu aldık. --> yeni diye bir dosya var mı yok mu kontrol et. -->

            if (durum) // eğer durum true ise
            {
                label1.Text = "Klasör var."; //--> varsa label'a yazdır.
            }
            else
            {
                label1.Text = "Klasör yok.";
            }
        }
    }
}
