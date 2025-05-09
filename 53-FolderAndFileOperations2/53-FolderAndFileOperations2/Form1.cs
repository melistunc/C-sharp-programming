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

namespace _53_FolderAndFileOperations2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // seçtiğimiz konuma klasör ekleme örneği
        private void button1_Click(object sender, EventArgs e)
        {
            DirectoryInfo klasorum =  Directory.CreateDirectory(textBox1.Text + @"\yeni"); // yeni bir dosya oluşturuyoruz. Kullanıcıdan aldığımız bilgi (textbox1.text) ile nereye kuracaksak onun bilgisini. Createdirectory, directoryinfo adı altında tutulur. Bu sayede klasörün bir sürü özelliğine erişebiliriz. CreateDirectory path yolu ister.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(); // folderbrowserdialog'u göster.
            textBox1.Text = folderBrowserDialog1.SelectedPath; // bu sayede seçilen dosya yolunu textbox'ta gösteririz.
        }
    }
}
