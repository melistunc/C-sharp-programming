using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformTextBox
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // textbox, kullanıcıdan girdi almaya yarar.

            string ad = textBox1.Text; // text bir string veri tipindedir yani oluşturduğumuz veri string türünde olmalıdır değilse tür dönüşümü yaparız.textbox ile dışarıdan girilen veriyi ad isimli değişkene atadık. textbox1.text diyerek kullanıcının girdiği yazıyı veriyi alırız.
            string sifre = textBox2.Text;

            if (ad == "admin" && sifre == "123") // eğer textbox ile girilen değerler yani ad admin, şifre 123 ise "Şifre" label'ına giriş başarılı yazsın.
            {
                label4.Text = "Giriş başarılı.";
                label4.ForeColor = Color.Green; // eğer giriş başarılı ise label4'un rengi yeşil olsun. Color sınıfı ile renklere ulaşırız. ForeColor ile label'ın rengini değiştiririz.
            }
            else // eğer admin ve 123 yerine başka bir şey yazarsak giriş başarısız yazsın.
            {
                label4.Text = "Giriş başarısız";
                label4.ForeColor = Color.Red; // giriş başarısızsa label kırmızı olsun.
            }

            label3.Text = textBox1.Text; // button'a tıklandığında label3'e; textbox içine yazılan yazıyı veririz yani ekrana kullanıcının textbox'a yazdığı veri yazar. 

            // textbox properties'inde usesystempassword özelliğini true yaparsak textbox'a yazılan veri gizli görünür.

        }
    }
}
