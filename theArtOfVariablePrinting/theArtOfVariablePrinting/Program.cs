using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace theArtOfVariablePrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            // temel string birleştirme
            string kurs = "C#";
            string kurs2 = "SQL";

            Console.WriteLine(kurs +  "Öğreniyorum."); // C# öğreniyorum. araya boşluklu.
            Console.WriteLine(kurs + " ve " + kurs2 + " Öğreniyorum!");




            //string format kullanımı
            string kurs3 = "C";
            string tarih = "2025";

            Console.WriteLine("{0} Yılında {1} öğrenmeye başladım.", tarih, kurs3); // 2025 yılında C öğrenmeye başladım. 0'a tarih değişkenini, 1!e kurs3 değişkenini atadık. 0 ve 1 indextirler.

            string metin = String.Format(" {0} yılında {1} öğrenmeye başladım." ,tarih, kurs3); // atring format metni istediğimiz gibi formatlar. Fakat bu şekilde bırakmak havada asılı bırakır bu yüzden console write ile ekrana yazdırmamız gerekir.
            Console.WriteLine(metin);




            //string interpolation
            int x = 10;
            int y = 20;
            string kurs4 = "C++";
            string tarih4 = "2024";

            Console.WriteLine($"{x} {y} {kurs4} {tarih4}"); //bu şekilde x ve y değişkeninin değeri ekranda gözükür.
            Console.Read();




            // string builder
            string kurs5 = "Python";
            string tarih5 = "2023";

            StringBuilder stringBuilder = new StringBuilder(); // nesne oluşturduk. builder bir kutu gibidir bunun içinde dğeişkenleri atayıp en son çağırırız.
            stringBuilder.Append( kurs5 );
            stringBuilder.Append( tarih5 ); // bir kutu içerisinde kurs5 ve tarih değişkenleirnin değerini koyduk.

            Console.WriteLine(stringBuilder); // şimdi de o kutuyu ekrana yazdırıyoruz.
        }
    }
}
