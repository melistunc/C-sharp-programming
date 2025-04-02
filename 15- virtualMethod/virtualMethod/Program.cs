using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Hayvan hayvan = new Hayvan();
            hayvan.SesCikar(); // ekrana hayvan ses çıkarıyor yazar.

            Hayvan kedi = new Kedi(); // hayvan türünde kedi isimli Kedi'den oluşan bir değişken tanımladık. Çokbiçimcilik yaptık. Hyavna türünde kedi olacak.

            Hayvan kopek = new Kopek();
            // hayvan türünde bir köpek oluşturduk ve bunu köpek class'ından aldık.Çokbiçimlilik.

            kedi.SesCikar();
            kopek.SesCikar();  // hayvan ses çıkarıyor miyav miyav hav hav --yazar.

        }
    }
}
