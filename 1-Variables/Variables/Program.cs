using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişkenleri tanımlama kuralları
            //[veri türü] [değişken adı]; (veya = 5; gibi)
            // değişkenler sayılarla başlamaz: 1number 
            // sayılar ile sonlanabilir: number1
            //değişkenler alt çizgi ile başlayıp sonlanabilir: _number, number_
            //özel işaretlerle başlayamaz: -number, #number
            //zorunlu değil fakat değişkenleri genellikle camel case olarak kullanırız yani: MyNumber, myNumber, thisMyNumber




            // int
            //int içerisinde tam sayıları barındırır. 0, 89..
            int number = 1;

            number = 2; // number değişkenimizin değerini değiştirdik. Artık number'ın değeri 2 olur, 1 silinir.
            number = number + 1; // number'ı bir arttırırız.

            number = number - 1; // bir azaltırız ve number!ın en son değeri bu olur.

            // sayi = A veya a veya "a" olamaz çünkü int tanımlandığımız şeyi string olarak yazamayız.

            Console.Write(number);
            Console.Read();




            // byte
            //byte küçük sayılarla çalışır. 0-255 arasındaki sayıları tutar. int kullansaydık fazla bellek alanı harcamış olacaktık. 

            byte number2= 255;




            //float
            //float içerisinde ondalıklı sayıları saklar. 0.5, 12.45... (içinde int'ları da tutar)
            //float değişkenine değer atadığımız zaman değerin sonuna ..f şeklinde harf eklememiz gerekir.

            float number3 = 4.5f; //5'in yanında sıfır olursa bunlar ekrana yazılmaz.




            // double
            //double içerisinde ondalıklı sayıları tutabilir float'tan daha büyüktür. (içinde int'ları da tutar)
            //sonuna d harfi eklemek zorunlu değil fakat yazıladabilir.

            double number4 = 90.32;




            // decimal
            //ondalıklı sayıları saklamak için kullanılır. Genellikle para ile ilgili değişkenlerde kullanılır.
            //sonuna m koyarız (ondalıklarda).

            decimal para = 34.23m;
            decimal para2 = 5;




            // char
            // char tek bir karakterleri ('a', 'B', '1' gibi) saklamak için kullanılır. ' ' kullanmak zorunludur. 

            char harf = 'A';
            harf = 'b';
            char harf2 = 'z';
            harf = harf2;
            harf = 'D';
            harf2 = 'Y';
            harf2 = harf; // en son çıktı D olur yani harf2'yi ekrana yazdırırsak D olur, harf de D olur.




            // string
            // string çoklu karakterleri ("melis", "ahmet", "buse", "12", "1.23", "a") saklarlar. Tek karakterleri de tutabilirler ama bellekte fazla er kaplarlar.

            string karakter = "melis";
            string karakter2 = "a";
            string karmasik = "387 *** @$$½ ";




            // boolean
            //bool mantıksal bir veri türüdür. True veya False saklar.

            bool secim = false;
            bool secim2 = true;

            secim = 20 > 10; //burada secim true olarak değişir.




            // var
            //var; bool, string, char, int... tüm değişken türlerinin yerini tutar fakat her zaman kullanılmaması tercih edilir. Çünkü bellek alanını fazla kaplar. Ne geleceğini bilmiyorsak kullanırız. Herhangi bir veri türünü içerisinde saklayabilir. Başladığı veri türü ile devam eder.

            var degisken = 1;
            //degisken = "a"; //burası hata verir çünkü bunu int olarak tanımlamıştık bu yüzden bu değişken türü artık int olmuştur.

            var degisken2 = "jlm";
            //degisken2 = 1; //burası hata verir çünkü degisken2'nin türünü string yaptık fakat başta string yaptığımız için burası int alamaz.

        }
    }
}
