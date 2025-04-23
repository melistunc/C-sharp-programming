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
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(); // form2'den (classından) bir nesne oluşturduk.
            this.Hide(); // nesneyi üret ve butona tıkladığımda form2'yi göstermeden hemen önce form1'i gizle kapat. this buradaki class'ı temsil eder yani form1 class'ını temsil eder.Hangi class'ın içindeysek o class'ı temsil eder this.

            frm.ShowDialog(); // bu şekilde form1 üzerindeki butona bastığımızda form2'ye geçiş yapar. show yaparsak butona her tıkladığımızda form ekranı görünür. Fakat showdialog yaptığımızda butona bastığımızda form2 bir defa görünür.
        }
    }
}
