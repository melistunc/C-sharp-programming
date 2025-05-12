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

namespace _59_FolderAndFileOperations8
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // metin belgesi (txt)'yi açma.
            // openFileDialog ile bir belge, dosyayı açarız.
                openFileDialog1.ShowDialog(); // dosya klasör kısmını açarız.
            
                StreamReader sr = new StreamReader(openFileDialog1.FileName);// reader ile bir şeyi oku deriz. nesne oluşturuyoruz class'tan. openfiledialog'tan seçtiğim filename dosyasını oku dedik. okuma işlemi satır satır yapılır.
                string satir = sr.ReadLine(); // dosyanın her satırını oku ve bunu satir değişkenine ata.

                while (satir != null) // satir bitmeyene kadar ekle listbox'a bu verileri.
                {
                    listBox1.Items.Add(satir);
                    satir = sr.ReadLine(); // satiri okumaya devam et.
                }
            }
        }
    }

