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

namespace _56_FolderAndFileOperations5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // klasör taşıma
            folderBrowserDialog1.ShowDialog(); // folderbroser bize klasörlerin yerileirni gösterir başta açılan pencere secim penceresi.
            Directory.Move(folderBrowserDialog1.SelectedPath+ @"\Yeni", folderBrowserDialog1.SelectedPath+ @"\Yeni2"); // Move nereden nereye olacagını söyler yani klasörü nerden nereye taşıyacaksın der.  Yeni klasöründen Yeni2 klasörüne taşı.
        }
    }
}
