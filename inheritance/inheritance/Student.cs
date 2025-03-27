using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Student : Person
        // person'daki verileri student class'ına aktarmıs olduk. Yani person class'ı içinde ne varsa artık student içinde de vardır. Buna kalıtım denir. Yani Person class'ından miras almış olur.
    {
        public string Lessons { get; set; }
    }
}
