using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformComboBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text); // comboBox'a Items (ogeleri) Add (ekle). textBox1'den girilen veriyi comboBox'a ekle.
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Seçilenindexdeğiştiğinde burası çalışır.

            label3.Text = "Seçilen şehir: " +comboBox1.Text; // comboBox'ta seçilen şehir label3'e yazılacak.
        }
    }
}
