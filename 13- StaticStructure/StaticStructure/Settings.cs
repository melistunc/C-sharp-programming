using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticStructure
{
    class Settings
    {
        // static constructer
        public static string AppName { get; set; }
        // constructer class adını yazarak oluşturduğumuz yapılardır.
        Settings() { // constructer, class'a erişildiğinde ilk başta çalışır.
                     // burayı static yaparsak bir defa çalışır.
                     // en erken en başta constructer çalışır.

            AppName = "Myapp"; // appname bir defa atanacak.
            Console.WriteLine("Static constructer çalıştı!");
        }  

    }
}
