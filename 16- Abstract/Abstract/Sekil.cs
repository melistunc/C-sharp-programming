using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    abstract class Sekil // base class, abstract class yaptık. yani zorunlu olarak diğer class'lara da aktarılacak.
    {
        public abstract double AlanHesapla();  // asbtract metot (zorunlu kullanım yaptık) gövdesiz metot oluştu.
        public void SekilBilgisi() {

            Console.WriteLine("Bu bir geometrik şekildir.");
        }
    }
}
