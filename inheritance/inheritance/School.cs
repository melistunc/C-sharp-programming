using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class School : Cafe // kalıtım aldı. Kalıtım olduğu için ilk önce Cafe constructor çalışır sonra School constructor çalışır.
    {
        public School() { // constructor metot

            Console.WriteLine("School Constructor çalıştı.");
        }
    }
}
