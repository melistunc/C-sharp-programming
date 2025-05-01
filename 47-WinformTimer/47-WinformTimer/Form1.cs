using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _47_WinformTimer
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0; // her seferinde sayac 0'lanmasın diye metıt dışında tanımladık.
        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac++;

            label1.Text =sayac.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // form yüklendiğinde timer başlasın dedik. metot başlatılması.
        }
    }
}
