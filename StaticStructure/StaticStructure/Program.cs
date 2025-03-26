using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // static nedir
            // staticler new lenemez yani new şeklinde nesne oluşturulamaz. new'lemeden static olarak metodu kullanabiliriz.
            mathHelper.Square(5.6);






            //static fields
            Counter.Artis();
            Counter.Artis();
            Counter.Artis();
            Counter.Count = 5;

            Console.WriteLine("Sayac değeri: "+Counter.Count);








            // static constructer
            Console.WriteLine("UYgulama adı "+ Settings.AppName); // çalıştırdık.

            Console.Read();
        }
    }
}
