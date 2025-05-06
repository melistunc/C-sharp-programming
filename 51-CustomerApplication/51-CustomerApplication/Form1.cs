using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _51_CustomerApplication
{
    // Data Source=DESKTOP-LMB1F9K\SQLEXPRESS;Initial Catalog=MüsterilerDB;Integrated Security=True;Encrypt=False

    public partial class Form1: Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-LMB1F9K\SQLEXPRESS;Initial Catalog=MüsterilerDB;Integrated Security=True;Encrypt=False"); // Önceden oluşturduğumuz MsSql'imizdeki veritabanımızı bağladık. İçindeki tabloları alabiliriz.

        public Form1()
        {
            InitializeComponent();
        }
        string tarih;
        string saat;
        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start(); // tools'tan eklediğimiz sayaç.
            GuncelleSaatTarih();

            baglanti.Open(); // bağlantımızı aç.
            string sorgu = "select * from Musteriler"; // Musteriler tablosundaki tüm verileri çekecek sorguyu string olarak yazdık.
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti); // bize yazdığımız sorguyu getir. sorguyu olusturduğumuz baglantıdan getir. Verileri çektik. 
            DataTable dt = new DataTable(); // çektiğimiz verileri datagrid'e vermek için ilk önce datatable ile sanal bir tablo oluştururuz. Sanal tablo olusturuyoruz.
            adapter.Fill(dt); // adapterı datatable ile doldur. Verileri bu sanal tabloya dolduruyoruz.

            dataGridView1.DataSource = dt; // datagridview'in kaynagı dt'den gelecek.
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
          
        }

        void GuncelleSaatTarih()
        {
            label1.Text = (tarih = DateTime.Now.ToString("dd.MM.YYYY"));
            label2.Text = (saat = DateTime.Now.ToString("HH:mm"));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var tc = dataGridView1.Rows[e.RowIndex].Cells[4].Value; // datagridview'in satırlarından tıkladığım elemanın indexine indexini al hangi satıra tıkladığımı al daha sonra bu indexin içerisindeki 4.kolondaki (tc)valuesunu al değerini al .  
            //MessageBox.Show("Tıklanan satır tc: "+tc); (formphoto1) bu kısıma kadar aşağısı yok.

            string sorgular = "select * from Musteriler where TC = @tc"; // TC'si tc olanları musteriler tablosundan getir. @ işareti parametre demektir. 
            SqlDataAdapter adp= new SqlDataAdapter(sorgular, baglanti);
            adp.SelectCommand.Parameters.AddWithValue("@tc", tc); // adapterıma seçili komuta parametre value ile birlikte ekliyoruz. @id değeri id değişkeninden gelecek. Değeri vermiş olduk.

            DataTable dataTable = new DataTable();
            adp.Fill(dataTable); // adp'ımı oluşturduğum datatable'me doldur.

            if (dataTable.Rows.Count > 0) // tıkladığım datatable'ımın satırlarının adeti sıfırdan büyük mü yani bir satır var mı ? 
            {
                textBox7.Text = dataTable.Rows[0]["TC"].ToString(); // textbox7'ye datatable'daki sıfırncı satırın tc'sini yazdır.
                textBox11.Text = dataTable.Rows[0]["Name"].ToString();
                textBox10.Text = dataTable.Rows[0]["Surname"].ToString();
                textBox9.Text = dataTable.Rows[0]["Phone"].ToString();
                textBox8.Text = dataTable.Rows[0]["City"].ToString(); // (formphoto2 buraya kadar.)

            }
        }

        // temizle butonu kullanımı.
        private void button5_Click(object sender, EventArgs e)
        {
            textBox7.Clear(); // dolularsa textbox'ları temizler.
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox8.Clear(); 
        }

        // tabloya yeni kişi ekleme Kaydet butonu kullanımı.
        private void button1_Click(object sender, EventArgs e)
        {
            string Id = textBox12.Text; 
            string ad = textBox11.Text;
            string soyad = textBox10.Text;
            string telefon = textBox9.Text;
            string city = textBox8.Text;
            string Tc = textBox7.Text;

            string sorgu = "insert into Musteriler (Name, Surname, Phone, City, TC) values (@Name, @Surname, @Phone, @City, @TC)"; // Musteriler table'ına verdiğimiz değerlere valueste yazdığımız değerleri ekliyoruz.
            
            SqlCommand cmd = new SqlCommand(sorgu, baglanti); // yukarıdaki sorguyu calıstırır. baglantıda olan sorguyu çalıştır.
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Surname", Surname);
            cmd.Parameters.AddWithValue("@Phone", Phone);
            cmd.Parameters.AddWithValue("@City", City);
            cmd.Parameters.AddWithValue("@TC", TC);

            cmd.EndExecuteNonQuery(); // bu sorguyu çalıştır diyoruz.
            MessageBox.Show("Kayıt başarıyla eklendi");
        }

        // verileri, kişileri listeler. Listele butonu kullanımı.
        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open(); // bağlantımızı aç.
            string sorgu = "select * from Musteriler"; // Musteriler tablosundaki tüm verileri çekecek sorguyu string olarak yazdık.
            SqlDataAdapter adapter = new SqlDataAdapter(sorgu, baglanti); // bize yazdığımız sorguyu getir. sorguyu olusturduğumuz baglantıdan getir. Verileri çektik. 
            DataTable dt = new DataTable(); // çektiğimiz verileri datagrid'e vermek için ilk önce datatable ile sanal bir tablo oluştururuz. Sanal tablo olusturuyoruz.
            adapter.Fill(dt); // adapterı datatable ile doldur. Verileri bu sanal tabloya dolduruyoruz.

            dataGridView1.DataSource = dt; // datagridview'in kaynagı dt'den gelecek.
        }

        // tıkladığımız kaydı TC'ye göre sil. Sil butonunun kullanımı.
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "") // eğer dolu ise aşağısı çalışır.
            {
                string sorgu = "delete from Musteriler where TC = @TC";

                SqlCommand cmd = new SqlCommand(sorgu, baglanti); // buradan gelen sorguyu baglantıdaki veritabanından çalıştır.
                cmd.Parameters.AddWithValue(@"id", textBox7.Text); // cmd ile parametere veririz textboxt7'ye.

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt basarıyla silindi.");
            }
            else // textbox7 boşsa burası çalışır.
            {
                MessageBox.Show("Listeden bir müşteri seçin.");
            }
        }

        // Güncelleme butonu kullanımı. Burada nereden referans larak güncelleyeceksek o boş olmamalı.
        private void button3_Click(object sender, EventArgs e)
        {
            string Id = textBox12.Text;
            string ad = textBox11.Text;
            string soyad = textBox10.Text;
            string telefon = textBox9.Text;
            string city = textBox8.Text;
            string Tc = textBox7.Text;

            if (textBox7.Text != "") // TC textbox'ı boş değilse burası çalışsın.
            {
                string sorgu = "update Müsteriler set Name = @Name, Surname= @Surname, City= @City, Phone= @Phone where TC = @TC"; // güncelleyeceğimiz verileri belirttik. Bu verileri TC'ye göre güncelle dedik.
                SqlCommand cmd = new SqlCommand(sorgu, baglanti); // baglantıdaki veritabanına ait yukarıdaki sorguyu çalıştır.

                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Surname", Surname);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@City", City); // parametreleri cmd ile çalıştırdık.
                cmd.Parameters.AddWithValue("@TC", textBox7.Text); // texttbox7'den gelen değere göre çalıştır.

                cmd.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Listeden bir müşteri seçin.");           
            }
        }
    }
}
