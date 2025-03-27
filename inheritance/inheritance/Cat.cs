using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Cat : Animal // kalıtım aldı.
    {
        public void Miyavla()
        {
            Name = "Milena";
            Console.WriteLine($"Kedinin adı: {Name}");
            SesCikar();
            Console.WriteLine("Meow Meow!!!");
        }
    }
}
