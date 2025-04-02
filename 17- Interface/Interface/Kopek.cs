using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Kopek : IHayvan, IKosabilir // iki tane kalıtım alabilir bir class.
    {
        public void Kos()
        {
            Console.WriteLine("Köpek koşuyor.");
        }

        public void SesCikar()
        {
            Console.WriteLine("Hav hav!");
        }
    }
}
