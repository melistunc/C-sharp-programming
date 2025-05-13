using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _61_SpecialFormDesign
{
    public partial class Form1: Form
    {
        // formun üstündeki pembe yere basıp formu suruklemek için kullanılan kod
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // kapatma olayı
            // close();
            Environment.Exit(0); // bu bir çıkış kodudur buna 0 verirsek her halükarda kapatacak. close bazen kapatmayabiliyor hata veriyor ama bu kod her zaman ne olursa olsun kapatıyor.
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // küçültme olayı
            this.WindowState = FormWindowState.Minimized; // pencerenin durumu formun durumu. Formu küçült kodu dedik.
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // büyütme olayı
            this.WindowState |= FormWindowState.Maximized; // windows formunu büyüt.
        }

        // formun üstündeki pembe yere basıp formu suruklemek için kullanılan kod
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        } //

        private void button1_Click(object sender, EventArgs e)
        {
            // buton1'e bastığımızda panel2 aktif olsun. panel4 aktif olmasın.
            panel2.Visible = true;
            panel4.Visible = false;
        }
    }
}
