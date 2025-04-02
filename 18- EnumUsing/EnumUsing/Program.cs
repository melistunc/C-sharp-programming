using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumUsing
{
    class Program
    {
        static void Main(string[] args)
        {
            // enum, oluşturduğumuz sabit değerlerdir.

            Gunler gunler = Gunler.Cumartesi; // burada sadece Gunler enum içinde tanımladıklarımızı yazabiliyoruz. Gunler için kullanacağımız değerleri sabit tuttuk.

            Console.WriteLine("Bugün günlerden "+gunler);
            Console.Read();
        }
    }
}
