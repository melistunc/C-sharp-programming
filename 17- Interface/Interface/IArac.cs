using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface IArac // interface'ler tanımlanırken her zaman I ile başlar (büyük ı) ve sonrasında anımlama ismni veririz. Arac interface'i.
    {
        void Calistir(); // metot
        void Durdur(); // buradaki metotların içini doldurmuyoruz bunu kalıtım aldığımız yerde yapacağız.
    }
}
