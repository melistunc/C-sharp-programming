using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeConversionAndGettingInputFromTheUser
{
    class Program
    {
        static void Main(string[] args)
        {
            // convert
            // convert, bir türü diğer türe dönüştürmeye yarar.
            string ad = "melis";
            string strNum = "34";
            double sayi = 10.5;
            int sayi2 = 10;
            Console.Write(ad + " " + ad); // + ile stringleri birleştiririz. araya boşluk koyduk.
            Console.Write(ad + " " + ad.GetType()); // gettype ile ad'ın hangi türde olacağını söyler. ekrana string olacağını söyler.
            Console.Write(sayi + " " + sayi.GetType()); //ekrana 10.5 double yazar.
            Console.Write(sayi2 + " " + sayi2.GetType());
            Console.Read();


            // ----------Int to Str-----------------
            string yeni = Convert.ToString(sayi); // sayi değişkenini string'e dönüştür. convert ile tür dönüşümü yaparız.tostring ile string'e dönüştüreceğimizi belirtiriz. sayi double'dan string'e dönüşmüş olur.
            Console.WriteLine(yeni + " " + yeni.GetType());


            // ----------Str to Int-----------------
            int yeni2 = Convert.ToInt32(strNum); // convert ile tür dönüşümü yaptığımızı belirtiriz. toınt16 sort, toınt32 int, toınt64 long belirtir. biz burada string değişkenini toınt32 ile integer'a dönüştürürüz. yanında mor simge olanların yanına parantez açıp kapatmak zorundayız.
            Console.WriteLine(yeni2 + " " + yeni2.GetType());





            // parse
            // parse tür dönüşümü için kullanılır.
            string num = "4";
            Console.WriteLine(num + " " + num.GetType());
            Console.ReadLine();

            // --------Str to Int--------------
            int yeniSayi = int.Parse(num); //parse ile dönüştüreceğimiz belirtiriz. içine dönüştüreceğimiz değişkeni yazarız. ve int yazark inte'a dönüştüreceğimizi belirtiriz. string'i int'e çevirmiş olduk.



            //---------Convert ve Parse farkı---------
            string sayi1 = null; // değişkenin içinde boş atadık demektir.
            int yeniSayi2 = Convert.ToInt32(sayi1);
            int yeniSayi3 = int.
                Parse(sayi1); // parse'lar null değerleri kontrol edemezler.

            Console.WriteLine(yeniSayi2);
            Console.WriteLine(yeniSayi3);
            Console.Read();










            // Kullanıcıdan inpu almak

            // console.raedline ile kullanıcının girdiği değeri alabiliriz. Bu bize string verir.
            Console.WriteLine("Değer girin....:" );
            string gelenDeger = Console.ReadLine(); // console'da satırı oku demektir. string türünde döndürür. bu satırla writeline'da ne yazılırsa o veriyi string türünde tutar ve saklar.

            Console.WriteLine("Girdiğiniz değer: " +gelenDeger);

            Console.WriteLine("Sayı girin: ");
            int gelensayii = Convert.ToInt32(Console.ReadLine()); // burada dışarıdan int türünde veri almak istiyorduk fakar readline sadece string türüünü saklıyorduk bu yüzden burada tür dönüşümü uygularız. 

            Console.WriteLine(gelensayii+ " "+ gelensayii.GetType());

            Console.Read();



            // kullanıcıdan ad, soyad, yas alın. Ekrana hosgeldin ad soyad ve yas'ı yazdırınız.

            Console.WriteLine("Adınız: ");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyadınız: ");
            string soyad = Console.ReadLine();

            Console.WriteLine("Yaşınız: ");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hoşgeldin " + ad + " " + soyad + " " + "yaş " + yas);
            Console.Read();


            // kullanıcıdan iki tane sayı alınız. bu iki sayı ile ilgili toplama, çıkarma, bölme ve çarpma yapınız. ve her sonucu ekrana yazınız.

            Console.WriteLine("1.sayıyı giriniz: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.sayıyı giriniz: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double toplam = num1 + num2;
            double fark = num1 - num2;
            double carpim = num1 * num2;
            double bolum = num1 / num2;

            Console.WriteLine("Toplam= "+toplam+ " "+ "Fark= "+fark+" "+ "Çarpım= "+carpim+" "+ "Bölüm= "+bolum.ToString("0.00")); // tostring ile bölümde oluşan sonucun virgülden sonra iki basamak olarak görünsün diye belirtiyoruz.
            Console.Read();
        }
    }
}
