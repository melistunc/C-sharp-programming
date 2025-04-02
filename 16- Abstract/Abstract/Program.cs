using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Program
    {
        static void Main(string[] args) // abstract ile overrite yapısını zorunlu yaparız.
        {
            Sekil dikdortgen = new Dikdortgen {Genislik=3, Uzunluk=5 }; // bu şekilde de genişlik ve uzunluğa değer verebiliriz. dikdörtgen alanı. {} ile değerleri bu şekilde dışarıdan yazabiliriz.

            Console.WriteLine("Dikdörtgen alanı: " + dikdortgen.AlanHesapla());



            Sekil daire = new Daire { Yaricap=4};//daire alanı.

            Console.WriteLine("Dairenin alanı: " + daire.AlanHesapla());
            Console.Read();
        }
    }
}
