using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStructure
{
    class Counter
    {
        public static int Count { get; private set; } // fields'ları da static olarak tanımlayabiliyoruz.

        public static void Artis()
        {
            Count++;
        }
    }
}
