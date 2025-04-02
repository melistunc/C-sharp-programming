using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Dikdortgen : Sekil // virtual ile ovverrite yapabiliyorduk yani isteğe bağlı idi. Fakat burada zorunlu bir yapı vardır. Burada implement edersek Sekil class'ı içindeki alanhesapla zorunlu metodunu kendisi getirir.
    {
        public double Genislik { get; set; }
        public double Uzunluk { get; set; }
        public override double AlanHesapla() // alanhesapla metodu zorunlu olarak kullanılır.
        {
            return Uzunluk*Genislik;
        }
    }
}
