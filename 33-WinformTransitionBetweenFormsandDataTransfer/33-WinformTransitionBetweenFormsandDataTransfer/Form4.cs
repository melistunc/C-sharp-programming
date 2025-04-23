using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _33_WinformTransitionBetweenFormsandDataTransfer
{
    public partial class Form4: Form
    {
        public string kimden; // değişken oluşturduk. Bunlara form1'den erişeceğiz.
        public string mesaj;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // form yüklendiğinde label3 ve label4'e form3'te textboxlara girilen verileri yazdır.

            label3.Text = kimden; // label3'e kimden değişkenine atanan verileri yazdır.
            label4.Text = mesaj;
        }
    }
}
