using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Series
{
    class Program
    {
        static void Main(string[] args)
        {
            //// dizi, aynı türdeki verileri toplayabildiğimiz sepettir.
            //// type [] arrayName; 

            //int[] skorlar = new int[5]; // skorlar isimli dizi tanımladık diz boyutunu da 5 yaptık yani 5 elemanlı skorlar isimli bir dizidir. 0 1 2 3 4 index elemanlar.

            //// dizilerin ilk elemanı her zaman 0'dan başlar.

            //skorlar[0] = 1; // skorlar dizisinin ilk elamanına 1 değerini atadık.
            //skorlar[1] = 12;
            //skorlar[2] = 13;
            //skorlar[3] = 14;
            //skorlar[4] = 15;

            //Console.WriteLine(skorlar[2]); // skorlar dizisindeki üçüncü elemanının değerini yazdırdı.



            //int[] skorlar2 = new int[5] { 1, 3, 4, 6, 7 }; // bu şekilde de eleman aktarımı yapabiliriz. sıra ile değerleri atar yani sıfırıncıya 1, birinciye 3, ikinciye 4... Burada kaç eleman varsa o kadar yeni değer ataması yapmak zorundayız yani tü elemanları doldurmak zorundayız.
            //Console.WriteLine(skorlar2[2]); // ekrana 4 yazar.



            //int[] skorlar3 = { 1, 2, 4, 5, 6, 7, 8, 9 }; // bu şekilde eleman sayısı belirtmeden direkt eleman ataması yapabiliriz. dizi boyutu belirtilmez.
            //Console.WriteLine(skorlar3[7]); // ekrana 9 yazar.




            //string[] meyveler = { "muz", "çilek", "karpuz", "vişne", "erik" };
            ////Console.WriteLine($"1. meyve {meyveler[0]}"); // ekrana muz yazar.
            ////Console.WriteLine($"2. meyve {meyveler[1]}");
            ////Console.WriteLine($"3. meyve {meyveler[2]}");
            ////Console.WriteLine($"4. meyve {meyveler[3]}");
            ////Console.WriteLine($"5. meyve {meyveler[4]}");

            //for (int i = 0; i < meyveler.Length ; i++)
            //{
            //    Console.WriteLine($"{i+1}. meyve: {meyveler[i]}");
            //}







            //Console.WriteLine("dizi uzunluğunu girin: ");
            //int boyut = int.Parse(Console.ReadLine());
            //int[] numbers  = new int[boyut];

            //for (int i = 0; i < boyut; i++)
            //{
            //    Console.WriteLine($"{i+1} elemanı girin.");
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Tüm elemanlar dolduruldu!");
            //Console.WriteLine($"Dizideki eleman sayısı: {numbers.Length}");

            //Console.WriteLine("Dizideki elemanlar");
            //for (int i = 0; i < boyut; i++)
            //{
            //    Console.WriteLine($"{i+1}. eleman: {numbers[i]}");
            //}



            //// for each
            //// for each döngüsü dizilerde kullanılan bir for döngüsüdür.

            //int[] sayilar = { 1, 2, 3, 4, 5, 6, 7 };

            //foreach (var index in numbers) // dizi içinde sırayla tek tek dolaşır. sayılar içerisinde tek tek dolaş elemanları tek tek ziyaret et ve her ziyaret edişinde ilgili elemanı index değişkenine ata.
            //{
            //    Console.WriteLine(index); // ekranda 1'den 7'ye kadar yazar.
            //}

            //string[] sebzeler = { "brokoli", "ıspanak", "mantar", "havuç", "salatalık" };

            //foreach (var sebze in sebzeler)
            //{
            //    Console.WriteLine(sebze);
            //}



            // bir dizi içerisindeki sayıları arayacağız.Sayı bulma oyunu.

            int[] numberss = { 12, 24, 27, 23, 26 };

            Console.WriteLine("10 ile 30 arasında sayı giriniz");
            int sayii = int.Parse(Console.ReadLine());
            bool bulundu = false;

            foreach (var sayiii in numberss)
            {
                if (sayii==sayiii)
                {
                    Console.WriteLine("Tebrikler aradığınız sayı dizi içinde!");
                    bulundu = true;
                    break;
                }
            }
                if(!bulundu) 
            {
                Console.WriteLine("Üzgünüm aradığınız sayı dizi içinde bulunmuyor.");
               
            }

            Console.Read();


        }
    }
}
