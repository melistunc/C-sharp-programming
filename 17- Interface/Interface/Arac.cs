using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Arac : IArac // interface'ten kalıtım aldık ve zorunlu olarak metotları gelmek zorunda olur.
    {
        public void Calistir()
        {
            Console.WriteLine("Araba çalıştırıldı class içinden."); //bu kısımdan yani class'lar içinden interface'ten aldığımız metotları burada doldurabiliyoruz.
        }

        public void Durdur()
        {
            Console.WriteLine("Araba durduruldu class içinden");
        }
    }
}
