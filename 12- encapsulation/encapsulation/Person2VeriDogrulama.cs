using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Person2VeriDogrulama
    {
        // veri doğrulama
        private int age;

        public int Age { 
   
            get { // yazdırma

                if (age > 0)
                {
                    return age; // eğer yaş sıfırdan büyükse yani 0 yaşı da almamak için, yaşı döndür.
                }
                else
                {
                    return - 1; // -1 hata olarak döner. Yani yaşı yazdırmaz.
                }
            } 
            set { // değer verme okuma

                if (value < 0) { // gelen değer sıfırdan küçükse burası çalışsın yani yaş sıfırdan küçükse burası çalışsın.

                    Console.WriteLine("Yaş neagit olamaz.");
                }
                else
                {
                    age = value; // sıfırdan küçük değilse de gerçek değeri girilen değere eşitleriz.
                }
            }
        }
    }
}
