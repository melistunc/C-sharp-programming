using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Car
    {
        public string Marka { get; set; }

        public void BilgiYazdir()
        {
            Console.WriteLine("Marka: "+Marka);
        }
    }
}
