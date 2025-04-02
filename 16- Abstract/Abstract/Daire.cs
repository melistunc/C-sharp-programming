using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Daire : Sekil // sekilden miras alır. 
    {
        public double Yaricap { get; set; }
        public override double AlanHesapla()
        {
            return Math.PI * Yaricap * Yaricap;
        }
    }
}
