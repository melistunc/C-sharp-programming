using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // sınıflar nesne üretmek için vardırlar. 

            // Araba class'ına ulaşmak için bir nesne oluşturmamız gerekiyor. Ayrıca Program.cs ekranda çalıştırıldığı için burayı kullanırız ekranda görüntülemek için. 

            //Araba araba = new Araba(); // Araba tipinde araba isimli bir Araba nesnesi oluşturduk. Yani Araba class'ında araba isimli nesne oluşturduk.
            //araba.marka = "Porsche"; // bu şekilde Araba claass'ı içinde tanımladığımız araba nesnesi ile Araba nesnesi içindeki değişkenlere ulaşarak özelliklerini değiştirebildik.Ekrana porsche gelir.
            //araba.model = "911 Carrera GTS";
            //araba.renk = "Baby pink";
            //araba.yil = 1963;

            //Araba araba = new Araba("Ferrari", "Competizione 812", "Burgundy",2021); // kurucu metot için. Kurucu metotta aynı tanımladığımız sırayla yazmak zorundayız.

            //Araba araba2 = new Araba(); // ikinci nesneyi de oluşturursak aynı değerler tekrar ekrana yazdırılır.Aama bunu yapmamalıyız yani Araba class'ında arabadaki değişkenleri özelleştirmeliyiz. Burada Ferrari ekrana yazılır. Eğer Araba class'ı içindeki değişkenlerin özelliklerini silseydik burası boş gelecekti. Bu bir yanlıştır zorunlu olarak buraya eklettirmeliyiz. Zorunlu olarak değer atamalıysak YAPICI METOT'ları kullanabiliriz.

            /*araba2.DegerAta("Mercedes","AMG GT Coupe", "Siyah",2021); // DegerAta metodunda parametreleri nasıl koyduysak bunu da öyle koyuyoryz.Yapıcı metotu açıklamak için */
            //araba2.BilgiYazdır();
            //araba.BilgiYazdır(); // burada class içindeki değişkenlere erişmek için Araba nesnesinin erişimini herkese açık yapmalıyız. Ekrana yazdırmak için metodu çalıştırırız burada.





            Apple apple = new Apple("Macbook Pro","Apple Pencil Pro","Airpods Pro","MagicBoard 11 inç","Ipad M2 11 inç", "Iphhone 12 pro max");

            apple.BilgiYazdır();
            Console.Read();
        }
    }
}
