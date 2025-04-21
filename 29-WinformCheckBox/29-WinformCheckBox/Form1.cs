using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _29_WinformCheckBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // checkbox1'de işaretleme değiştiğinde burası çalışır.

            if (checkBox1.Checked) { // checkbox1 işaretli ise

                label1.BackColor = Color.HotPink; // checkbox check olduğu zaman arkaplan pembe olsun
            }
            else
            {
                label1.BackColor= Color.Transparent; // check değilse arka plan transparan olsun yani hiçbir şey olmasın.
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) // eğer checkbox2 seçilirse
            {
                label1.ForeColor = Color.White; //yazı rengi beyaz olsun.
            }
            else // işaretli değilse
            {
                label1.ForeColor= Color.Black; // yazı rengi siyah olsun.
            }
        }
    }
}
