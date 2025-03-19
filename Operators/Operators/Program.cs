using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            //// aritmetik operatörler
            //double sayi1 = 10;
            //double sayi2 = 29;

            //double toplam = sayi1 + sayi2;
            //double fark = sayi1 - sayi2;
            //double carpim = sayi1 * sayi2;
            //double bolum = sayi1 / sayi2;

            //Console.WriteLine("Toplam: " + toplam);
            //Console.WriteLine("Fark: " + fark);
            //Console.WriteLine("Çarpım: " + carpim);
            //Console.WriteLine("Bölüm: " + bolum.ToString("0.00")); // tostring(0.00) ile virgülden sonra iki basamağı aldık sadece.
            //Console.Read();


            //// mod alma % , bölmede bir kalandır.
            //int sayi3 = 30;
            //int sayi4 = 8;

            //double kalan = sayi3 % 6; // sayi3'ün 2 ile modunu aldık yani 2'ye bölüp kalanını bulduk. ekranda 6 verir.

            //double arttir = sayi1++; // bu şekilde yazılırsa ilk önce sayi1 yazılır ve arttıra atanır yani ilk önce sayıyı arttırmaz atadıktan sonra arttırır.
            //double arttr2 = ++sayi3; // bu şekilde yazarsak ilk önce sayi3'ü arttırır sonra arttr2'ye atar. yani ilk önce arttırır sonra atar.
            //double azalt = sayi2--;
            //double azalt2 = --sayi4;






            //// atama operatörleri
            //// += , arttırarak atama operatörü
            //// -= , azaltarak atama operatörü
            //// *= , çarparak atama operatörü
            //// /= , bölerek atama operatörü
            //// %= , kalanı bul ve atama operatörü

            //int sayi = 5;
            //sayi += 5; // sayi değerine 5 ekle ve tekrar kendine ata. yeni değeri 10 olur.
            //sayi -= 2; // sayi değerinden(10) 2 çıkar ve tekrar kendine atar.
            //sayi *= 2; // 16
            //sayi /= 2; // 8

            //sayi = sayi + 18; // sayi değerine 18 ekledik.sayi +=18; ile bu kod aynı işlevi görür. 






            //// Karşılaştırma operatörleri
            //// karşılaştırma operatörlerinde sonuçlar bool olarak gelir. True veya False. Bir şey doğruysa true, yanlışsa false çalışır. 
            //// 5 == 5 (5, 5'e eşit mi? ) diye sorar.
            //// == : eşitse
            //// != : eşit değilse

            //int num = 15;
            //int num1 = 20;

            //bool sonuc = num == num1; // num, num1'e eşit mi? false eşit mi.

            //sonuc = num != num1; // num, num1'e eşit değil mi? true eşit değil mi

            //sonuc = num > num1; // num büyüktür num1'den. false. büyük mü

            //sonuc = num < num1; // num küçüktür num1'den. true küçük mü

            //sonuc = num <= num1; // num1, num'dan büyük de eşit de olabilir.küçük veya eşit mi

            //sonuc = num >= num1; // num1, num'dan küçük ve eşit. bir tanesi de sağlandığı için true olur. büyük veya eşit mi





            //// Mantıksal operatörler
            //// and, ve, && sembolüyle gösterilir. iki şartın da doğru olması gerekir.
            //// or, veya, || işaretiyle gösterilir. en az bir şartın doğru olması yeterlidir.
            //// not, değil, ! işaretiyle gösterilir. tersini alır.
            //// == eşit mi
            //// != eşit değil mi

            //int num2 = 20;
            //bool kontrol = num > 2 && num < 21; // ekrana true yazar.

            //bool kontrol2 = num2 > 2 || num2 < 10; // ekrana true yazar bir şart true olması yeterlidir.

            //bool kontrol3 = !(num2 > 2); //"sayı ikiden büyük değil" mesajı verilir. içerisi true idi değilini aldığımız zaman false olur yani ekrana false yazar.

            //Console.WriteLine(kontrol);
            //Console.Read ();



            // kullanıcıdan kullanıcı adı ve şifre alın. Eğer kullanıcı adı "admin" ve şifre de "123" ise ekrana true veya false yazsın.

            string kadı = "admin";
            int sifree = 123;

            Console.Write("Kullanıcı adınız: ");
            string ad1 = Console.ReadLine ();

            Console.Write("Şifreniz: ");
            int sifre = int.Parse(Console.ReadLine ());

            var ksonuc = kadı == ad1 && sifree == sifre;

            Console.WriteLine("Bilgileriniz doğru mu? " +ksonuc);
            Console.Read();
        }
    }
}
