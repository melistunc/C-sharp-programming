using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _44_WinformMovingToObject
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5; // fotoğraf yani picturebox butona basılınca 5 birim sola kaysın dedik.
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pictureBox1.Left += 5; // 5 birim sağa kaydırma.sola 5 ekleyip.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5; // üste gider.
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Top += 5; // alta gider. üste 5 ekleyip.
        }
    }
}
