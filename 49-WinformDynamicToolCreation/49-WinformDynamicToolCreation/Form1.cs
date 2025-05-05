using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _49_WinformDynamicToolCreation
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //// form çalıştığında bir buton dinamik şekilde oluşsun.
            //Button btn = new Button();
            //btn.Name = "buton1";
            //btn.Text = "button 1";
            //btn.Width = 100;
            //btn.Height = 50;
            //btn.Location = new Point(5, 100); // koordinat ayarı.
            //this.Controls.Add(btn); // this ile bu form'a (class ile) btn nesnemiz ile oluşturduğumuz button'umuzu oluştururuz.


            //TextBox txb = new TextBox();
            //txb.Name = "textbox1";
            //txb.Text = "textbox 1";
            //txb.Width = 100;
            //txb.Height = 50;
            //txb.Location = new Point(50, 150);
            //this.Controls.Add(txb);

            //// bu şekilde tools'ları kendimiz dinamik olarak oluşturabiliriz.
            ///
            // dinamik şekilde 1'den 50'ye kadar buttonlar ekleriz.
            int formwidth = 792;
            int btnwidth = 40;
            int btnhegight = 40;
            int startX = 0;
            int startY = 150;
            int padding = 5;

            int maxButtonPerRow = (formwidth-startX) / (btnwidth + padding);

            for (int i = 0; i <50; i++)
            {
                Button btn = new Button();
                btn.Name = $"btn{i+1}";
                btn.Text = $"button{i+1}";
                btn.Width = btnwidth;
                btn.Height = btnhegight;

                int row = i/maxButtonPerRow; // kaçıncı satırda olduğmuzu buluyor.
                int col = i%maxButtonPerRow; // kaçıncı sütunda olduğmuzu bulur.
                btn.Location = new Point(startX + col * (btnwidth+padding), startY + row *(btnhegight+padding));

                btn.Click += Btn_Click; // buttonlara btn_click metodumuzu eklettik. yani böylece herhangi bir butona tıkladığımızda o butonun bilgisi verilir. (alttaki metod oluşturulduktan sonra burası yazılır.)
                this.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e) // biz buton tıklamasını otomatik oluşturduk.
        {
            Button tiklananbtn = sender as Button; // yeni buton oluşturduk bu sender bize o anki objenin değerini veriyor. bu sender bir button olacak diyoruz. bu sender bana ilgili objeniin değerini verir burada tıklanan butonu alıyoruz aslında.

            if (tiklananbtn !=null)
            {
                MessageBox.Show($"Tıklanan buton {tiklananbtn.Text}"); // tıkladığımızda tıklananın bilgidini gösteriyor.
            }
        }
    }
}
