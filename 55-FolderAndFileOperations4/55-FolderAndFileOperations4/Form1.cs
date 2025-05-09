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

namespace _55_FolderAndFileOperations4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(); // klasör gösterir.
            Directory.Delete(folderBrowserDialog1.SelectedPath + @"\Yeni", true); // klasördeki seçilen dosyanın yolunu alarak git bunu sil.Yeni klasörünü sil. // Bu dosya boşsa siler fakat boş değilse hata verir der ki bu klasörün içinde dosya var ben bunu silemem der. Ben bunun içinde ne var ne yok hepsini sil istiyorsam ikinci parametre veririm yani True dersek her şeyi siler.
        }
    }
}
