using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; //bu kısımlar kütüphanemizi temsil ediyor. Kütüphane, projede kullanılmak istenilen metot vs gibi verileri getirmemizi sağlar. Çağırdığımızda içlerindeki kodlar bu projeye dahil olur.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args) // ana fonksiyon
        {
            Console.WriteLine("Merhaba Ahmet Ali!"); //ekrana yazdırır.
            Console.Read(); //ekrana yazılan metin hemen kapanmasın diye mutlaka bunu ekleriz. Yoksa ekran kendi kendine kapanır. BU konsolu oku konsolu bekle anlamındadır.

            // açıklama satırı bu şekilde (tek satırlı açıklamalar için kullanılması uygundur.) veya
            /* bu şekilde gösterilir bu gösterim birden fazla satır için uygundur.*/
        }
    }
}
