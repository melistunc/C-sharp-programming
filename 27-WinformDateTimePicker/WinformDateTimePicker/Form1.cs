using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformDateTimePicker
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Text; // datetimepicker'dan seçtiğimiz tarihi label'a yazdırıyoruz.datetimepicker datemtime türündedir fakat label string türündedir. burada text string türünde olduğu için tür dönüşümüne gerek yoktur.

            //DateTime tarih = dateTimePicker1.Value;
            //label1.Text = tarih.ToString(); bu şekilde datetime'dan nesne oluşturup da picker ile tarih label'a atanabilir. burada string tür dönüşümü yapmamız lazım çünkü value string değildir.
        }
    }
}
