using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Person
    {
        // kapsülleme
        private string name; // propertiesde de kullanacağız.

        public void SetName(string val) // değer atama işlemi yapacak. Tek bir yerden değerin string ataması yaparız burada şartımıza göre name'e değer atıyoruz. ne şart istiyorsak. Böylece bir kapsülleme yapmış oluruz. Verileri kontrol altında tutmak = kapsüllemedir.
        {
            if (true)
            {
                name = val; // parametreden gelen değeri atadık.
            }

        }

        public string GetName() { // değer okuma -getirme işlemi yapar.

            return name; // name'i getirir geri döndürür böylece değeri atadıktan sonra okumuş oluruz.
        }




        //properties kullanımı
        public string Name
        {
            get { return name; } // bana name'i getir. Veriyi okumak. Melis ismini burada okuduk.
            set { name = value; } // name'e gelen değer (value)'yi name'e atadık. Melis ismini buraya atadık.
        }
    }
}
