using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Kedi : IHayvan, IKosabilir
    {
        public void Kos()
        {
            Console.WriteLine("Kedi kosuyor.");
        }

        public void SesCikar()
        {
            Console.WriteLine("miav miav");
        }
    }
}
