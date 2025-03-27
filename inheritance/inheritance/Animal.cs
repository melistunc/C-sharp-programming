using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Animal
    {
        protected string Name { get; set; }

        protected void SesCikar () // protected yaptığımız için artık bu Class sadece miras alındığı yerlerde kullanlabilir oldu.
            // public -> herkese açık
            // private -> herkese kapalı
            // protected -> sadece miras alındığı yerde kullanıma açık.
        {
            Console.WriteLine("Hayvan ses çıkardı.");
        }
    }
}
