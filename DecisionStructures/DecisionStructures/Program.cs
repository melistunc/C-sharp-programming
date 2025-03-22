using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 15;
            if (sayi1>sayi2)

            // if
            {// if true gelirse aşağısındaki kodlar çalışır fakat false gelirse bu kod kısmını atlayıp bu if döngü kısmından çıkar kodları çalıştırmaz.
                Console.WriteLine("sayi1, sayi2'den büyüktür."); // sayi1 sayi2'den büyükse bu kısım çalışır.
            }
            Console.WriteLine("sayi1, sayi2'den küçüktür."); // sayi1 sayi2'den küçükse bu kısım çalışır. if döngüsü içinden çıkar. burası if döngüsü dışı.
            Console.Read();







            // else
            int num1 = 10;
            int num2 = 15;

            if (num1 > num2) {

                Console.WriteLine("num1 büyüktür num2'den");
            }
            else // if kısmı çalışırsa else çalışmaz. else çalışırsa if çalışmamış demektir. else herhangi bir şart yazılmaz. else if'in tersi şarttır.
            {
                Console.WriteLine("num2 num1'den büyük.");
            }
                Console.Read(); // ikisi eşit olursa yani num1 = num2 olursa else kısmı çalışır çünkü if kısmı false olur yani if'in dışı çalışır.


            // iç içe if kullanımı
            int num3 = 10;

            //kötü yöntem
            if (num3>5) // num3 5'ten büyükse alt satır çalışır.
            {
                if (num3<10)
                {
                    Console.WriteLine("Sayı hem 5'ten büyük hem de 10'dan küçüktür. ");
                }
                else
                {
                    Console.WriteLine("Sayı 5'ten büyüktür.");
                }
                   
            }
            else
            {
                Console.WriteLine("Sayı 5'ten büyük değil ve 10'dan küçük değildir.");
            }

            //iyi yöntem
            if (num3>5 && num3<10 && num3<7 && num3<2 && num3>0 ) // aynı if içerisinde sonsuz şart koyabiliriz.
            {
                Console.WriteLine("Sayı hem 5'ten büyük hem de 10'dan küçüktür. ");
            }
            else
            {
                Console.WriteLine("Sayı 5'ten büyük değil ve 10'dan küçük değildir.");
            }

            if ((num3 >5 && num3<10) || (num3<7 && num3>0)) // şartları true veya false olarak karşılaştırır en son tüm işlemin true mu false mu olduğuna bakar.
            {
                Console.WriteLine();
            }





            // else-if
            int saat = 22;
            if (saat < 10) // eğer hepsini if-if-if-if olarak yazarsak tüm satırlara bakar fakat biz vakit kaybı ugramasını istemiyoruz yani şartı bulduğu if'i bulup çıkmasını istiyoruz. bu yüzden else if kullanırız böylece birçok if işini yapar ama bulduğu uygun şartı bulup hemen döngüden çıkar. diğer if'lere bakmaz uygun olanı bulup çıkar.
            {
                Console.WriteLine("Günaydın...");
            }
            else if (saat > 13.00)
            {
                Console.WriteLine("Uyanmak için geç bir vakit.");
            }
            else if (saat < 18.00)
            {
                Console.WriteLine("Yemek vakti!!");
            }
            else if (saat > 20.00) {

                Console.WriteLine("İyi akşamlar...");
            }
            else // hiçbir else if ve if çalışmazsa bu kısım çalışır. en son.
            {
                Console.WriteLine("Hiçbiri çalışmadı.");
            }



            int saat = 20;
            string sonuc = (saat > 18) ? "İyi günler" : "İyi akşamlar";// if ve else tek satırda yazılır. Bu if türü bir string'e atanmalıdır. iki nokta önü true, arkası false döndürür. bu string döndürür. ? ile bu şart sağlanıyor mu sağlanmıyor mu diye sorar. ekrana iyi akşamlar yazar çünkü şart sağlanmış olur.ternary if sadece tek durumda kullanılmalıdır. true veya false.





            // swtich
            // swtich birçok else-if'in kullanımına benzerdir. şartı switch içine yani case'lere yazılır. switch içine de işlem yapacağımız değişkeni yazarız.
            Console.WriteLine("1.sayı girin: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1.sayı girin: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sembol girin: (+ - * /)");
            string sembol = Console.ReadLine();

            switch (sembol) // sembol ile ilgil işlem yapıyıruz.
            {
                case "+": // birinci işlemimiz + yani toplama
                    int toplam = number + number2;
                    Console.WriteLine("toplamı: "+toplam);
                    break; // burası doğru ise işem yapılırsa döngüden çık buradan çık diğer case'lere bakma.
                case "-":
                    int fark = number - number2;
                    Console.WriteLine("fark: "+fark);
                    break;

                case "*":
                    int carpim = number * number2;
                    Console.WriteLine("carpim: "+carpim);
                    break;

                case "/":
                    int bolme = number / number2;
                    Console.WriteLine("bolum: "+bolme);
                    break;

                default: // bu kısım hiçbir case uygun değilse hiçbir case uymazsa çalışır.
                    Console.WriteLine("hatalı giriş");
                    break;
            }




            // kullanıcıdan bir sayı alın sayı çift mi tek mi olduguna karar verin.

            Console.WriteLine("Bir sayı giriniz: ");
            int sayisal = Convert.ToInt32(Console.ReadLine());

            if (sayisal%2==0)
            {
                Console.WriteLine("Girdiğiniz sayı çifttir.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı tektir.");
            }

            // kullanıcıdan bir sayı alın sayı negaitf mi pozitif mi olduguna karar verin.
            Console.WriteLine("Bir sayı giriniz: ");
            int sayisal2 = Convert.ToInt32(Console.ReadLine());

            if (sayisal2<0)
            {
                Console.WriteLine("Girdiğiniz sayı negaitf.");
            }
            else if (sayisal2>0)
            { 
                Console.WriteLine("Girdiğiniz sayı pozitif.");
            }
            else
            {
                Console.WriteLine("Girdiğiniz sayı sıfırdır.");
            }





            //kullanıcıdan bir not alın ve bu nota karşılık gelen bir harf notu yazdırınız.

            Console.WriteLine("Notunuzu giriniz:");
            int ntt = Convert.ToInt32(Console.ReadLine());

            if (ntt <=100 && ntt>=0)
            {
                if (ntt >= 90)
                {
                    Console.WriteLine("AA");
                }
                else if (ntt >= 80)
                {
                    Console.WriteLine("BB");
                }
                else if (ntt >= 70)
                {
                    Console.WriteLine("CC");
                }
                else if (ntt >= 60)
                {
                    Console.WriteLine("DD");
                }
                else
                {
                    Console.WriteLine("FF");
                }
            }
            else
            {
                Console.WriteLine("Hatalı not girişi.");
            }




            // kullanıcıdan bir ay numarası alın ve o aya karşı gelen ay ismini yazdırın.

            Console.WriteLine("Ay numarası giriniz (1 2 3 4 5 6 7 8 9 10 11 12)");
            string ay = Console.ReadLine();

            switch (ay)
            {
                case "1":
                    Console.WriteLine("Ocak");
                    break;
                case "2":
                    Console.WriteLine("Şubat");
                    break;
                case "3":
                    Console.WriteLine("Mart");
                    break;
                case "4":
                    Console.WriteLine("Nisan");
                    break;
                case "5":
                    Console.WriteLine("Mayıs");
                    break;
                case "6":
                    Console.WriteLine("Haziran");
                    break;
                case "7":
                    Console.WriteLine("Temmuz");
                    break;
                case "8":
                    Console.WriteLine("Ağustos");
                    break;
                case "9":
                    Console.WriteLine("Eylül");
                    break;
                case "10":
                    Console.WriteLine("Ekim");
                    break;
                case "11":
                    Console.WriteLine("Kasım");
                    break;
                case "12":
                    Console.WriteLine("Aralık");
                    break;
                default:
                    Console.WriteLine("Yanlış sayı girdiniz.");
                    break;
            }





            // kullanıcıdan alışveriş tutarını öğrenin. eğer  tutar 100 tl üzerindeyse %10 indirim yapın indirimli fiyatı gösterin. Eğer tutar 200 tl üzerindeyse bu sefer %20 indirim yapın ve gösterin.
            Console.WriteLine("Alışveriş tutarınız: ");
            decimal tutar = Convert.ToDecimal(Console.ReadLine());

            if (tutar >100)
            {
                decimal enson = tutar - ((tutar * 10) / 100);
                Console.WriteLine("İndirimli tutarınız: "+enson);
            }
            else if (tutar > 0 && tutar > 200)
            {
                decimal enson1 = tutar - ((tutar * 20) / 100);
                Console.WriteLine("İndirimli tutarınız: " + enson1);
            }
            else
            {
                Console.WriteLine("Tutarınız.");
            }
                Console.Read();
        }
    }
}
