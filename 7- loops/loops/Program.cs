using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // while
            int sayac = 1;
            while (sayac <=10) // buradaki şart true gelirse içerisindeki çalışmalar çalışmaya devam eder. bu kısımda her zaman true olursa sonsuz döngüde çalışır.bu yüzden bu örnekte bir sayac koymuşuz yani 1,2,3,4,5,6,7,8,9,10 sayıları sayac değerinde döner 11 olduğu zaman döngü çalışmaz ve while döngüsünden çıkılır.
            {
                Console.WriteLine($"{sayac}.yazı");
                sayac++;
            } // false olursa döngü hüç çalışmaz buraya gelinir. döngüden çıkılır.





            // do while
            // while şart sağlanmazsa hiç çalışmaz fakat do while'da şart sağlanmazsa bile bir defa çalışır.
            bool durum=false;

            while (durum) {
                Console.WriteLine("Çalıştı.");
            }


            do // bu kısımda şart sağlanmazsa bile en az 1 kere çalışır.
            {
                Console.WriteLine("Çalıştı2.");
            }
            while (durum);





            // for
            for (int i = 1; i < 10; i++) // baslangıc-sart-artıs. ekranda 1-2-3-4-5-6-7-8-9. burası şu şekilde çalışır; ilk önce tanımladığımız değişken ataması olur sonra şarta gelinir şart uygun mu değil mi diye eğer değilse for döngüsünden çıkılır eğer şart sağlanıyorsa for döngüsü içine girilir for döngüsü içindeki kod çalışır sonra tekrar for döngüsüne gidilir ve değişkenin değeri bir arttırılır sonra tekrar şarta gidilir şart kontrolü yapılır bu şekilde şartın uymadığı zamana kadar aynı olay devam edilir.
            {
                Console.WriteLine(i);
            }





            // break
            int sayacc = 0;
            while (sayacc <=6)
            {
                if (sayacc == 5)
                {
                    break; // eğer sayacım 5 olursa 5'te döngüden çık döngüyü kapa. ekrana 0 1 2 3 4 yazar. 
                }
                else
                    sayacc++;                
            }




            // continue
            int sayaccc = 0;
            while (sayacc <= 10)
            {
                if (sayaccc == 5)
                {
                    sayaccc++;
                    continue; // eğer sayacım 5 olursa 5'te 5'i döngüye koyma ama sonra devam et yani sadece 5'i es gec. ekrana 0 1 2 3 4 6 7 8 9 10 yazar. 
                }
                Console.WriteLine();
                sayaccc++;
            }





            // faktöriyel hesaplama

            Console.WriteLine("Sayı giriniz.");
            int sayiii = int.Parse(Console.ReadLine());
            int factwhile = 1;
            int j = 1;

            //while ile
            while (j <= sayiii)
            {
                factwhile*=j;
                j++;
            }
            Console.WriteLine("Fakötriyeli: "+factwhile);


            // do while ile
            int factdowhile = 1;
            int k = 1;

            do
            {
                factdowhile *=k;
                k++;
            }
            while (k <= sayiii);
            Console.WriteLine("faköriyeli: "+factdowhile);



            // for ile
            int factfor = 1;
            for (int i = 1; i < sayiii; i++)
            {
                factfor = factfor * i;
            }
            Console.WriteLine("Faktöriyeli: "+sayiii);
            Console.Read();
        }
    }
}
