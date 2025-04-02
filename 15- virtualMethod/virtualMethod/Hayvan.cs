using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualMethod
{
    class Hayvan
    {
        public virtual void SesCikar() // sanal bir metot oldu. override üstüne yazmak demektir.
        {
            Console.WriteLine("Hayvan ses çıkarıyor.");
        }
    }
}
