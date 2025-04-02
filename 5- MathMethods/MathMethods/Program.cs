using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            // min-max

            Console.WriteLine("1.sayıyı giriniz: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("2.sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            int enBuyuk = Math.Max(sayi1, sayi2); //  math matematikler için kullanılan kütüphanedir. Max, verilen iki sayıdan büyüğünü bulup ekrana döndürür.

            Console.WriteLine(enBuyuk);
            Console.Read();

            int enKucuk = Math.Min(sayi1, sayi2); // iki değişken arasındaki en küçük sayıyı bulur. 


            


            // sqrt , kök alma
            Console.WriteLine("Karekökünü bulmak istediğiniz sayı: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            double swrt = Math.Sqrt(sayi); // sayi değişkenin karekökünü bul. küsüratlı çıkabileceği için double ile tanımladık.




            // abs , mutlak değer alma
            Console.WriteLine("Sayı giriniz: ");
            double num = Convert.ToDouble(Console.ReadLine());

            double sonuc = Math.Abs(num); // num değişkeninin değerinin mutlak değerini aldı.




            // round, bir sayıyı bir üst tam sayıya yuvarlar.
            Console.WriteLine("sayı giriniz: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double sonuc2 = Math.Round(num2);




            // pow, üs alma fonksiyonudur.
            Console.WriteLine("Sayı girin: ");
            double num3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Üs girin");
            double us = Convert.ToDouble(Console.ReadLine());

            double sonuc3 = Math.Pow(num3, us);
        } 
    }
}
