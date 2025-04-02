using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args) // buradaki fonksiyonda Main de bir metottur.
        {
            // MAIN METOT İÇİ
            //    // metotlar
            //    // metotlar kod tekrarının önlenmesi için kullanılır. Mesela bir kodu bir sürü kere koyaladığımızı düşünelim bunun yapılması hem zor hem de güncellenmesi çok büyük sıkıntı verir bunun çözümü ve kolaylaştırılması metotlar ile olur.
            //    // metodun içerisine metot tanımlamayız. metot dışında yeni metot tanımlayabiliriz.
            //    Karsila(); // Karsila fonksiyonunu çalıştırmak için ana main içinde çalıştırdık.
            //    Karsila(); // tekrar çalıştırırsak Karsila metodu tekrar çalışmış olur ve iki kere içindekiler ekrana yazılmış olur. Yani aynı kodu birden fazla kez tek bir metod ile yazdırabiliyoruz.
            //}
            //// fonksiyonlar ya geriye değer döndürür ya da değer döndürmez.bool, int vs.


            //MAIN METODU DIŞI
            //static void Karsila() // metot oluşturduk. void ile geriye değer döndürmeyeceğimizi belirttik. Metot içine ne yaptırmak istiyorsak onu belirtiriz. 
            // // metotlara isim verirken ilk harfleri her zaman büyük olur. 
            // // eğer static yazmasaydık sadece void yazsaydık ana main fonksiyonu içinde class içinde nesne oluşturup bu fonksiyon ismini de ana main fonksiyon içinde çalıştırmalıydık.
            // // nesne oluşturmadan static yazarak da bu fonksiyonu çalıştırabiliriz.
            //{
            //    Console.WriteLine("merhaba");
            //    Console.WriteLine("*******");
            //}













            // MAIN METOT İÇİ
            // parametre kullanımı
            // metoda bir değer göndermek istiyorsak bunu metoda parametre göndererek sağlarız.
            //    Console.WriteLine("1.sayıyı girin: "); // kullanıcıdan sayı almak.
            //    int s1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("2.sayıyı girin: ");
            //    int s2 = int.Parse(Console.ReadLine());

            //    Topla(s1, s2); // metotlarda parantez açıp kapatmak şarttır. Topla metoduna s1 ve s2 değişkenlerini gönderiyoruz bunları metot içinde kabul ettirmek için Topla metodu içinde de parametreleri göndermek zorundayız. Topla metoduna dallanma yapar.
            //    Console.Read();
            //}

            // MAIN METOT DIŞI
            //// parametre kullanımı
            //static void Topla(int a, int b) // burada yeni değişkenler oluşturduk ve üstteki gönderdiğimiz parametreler buradaki parametrelere denk oluyor fakat--
            //{
            //    int sayi1 = a; // ---bu kısımda da verdiğimiz parametreleri değişkenlere vermemeiz lazım tanımlı olması için metot içinde.
            //    int sayi2 = b;

            //    int sonuc = sayi1 + sayi2;

            //    Console.WriteLine("Toplama sonucu: "+sonuc);
            //}













            // MAIN METOT İÇİ
            // // geriye değer döndürme
            // //o anki değeri metoda göndermek demektir.
            // // hesaplamalar, karşılaştırmalar vs gibi işlemlerde kullanırız. Örneğin iki dizi aynı mı değil mi karşılaştırmak için gibi.
            //    Console.WriteLine("1.sayıyı girin: "); // kullanıcıdan sayı almak.
            //    int s1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("2.sayıyı girin: ");
            //    int s2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine(Topla(s1,s2)); // bu şekilde ekrana yazıyı en son yazdırırız. return ile ekrana yazdırmamıstık. Topla metoduna burada parametre atadık.
            //    Console.Read();

            //}

            // MAIN METOT DIŞI
            //// geriye değer döndürme 
            //static int Topla(int a, int b) // void geriye değer döndürmeyeceğim demektir. Döndürmek için ise değişkenimiz hangi tür ise onun türünü yazarız int, string vs.
            //{
            //    int sayi1 = a; 
            //    int sayi2 = b;

            //    int sonuc = sayi1 + sayi2; // geriye değer döndürme, buradaki değeri "sonuc" u geriye dönüp Topla metodu içerisinde atıyoruz yani eşitliyoruz. Artık topla dediğimizde bize iki sayının toplamını verecek.

            //    return sonuc; // return ile "sonuc" değişkenini Topla metodunun bizzat kendisine döndürürüz. Gerşye değer döndürmede genellikle ekrana yazı yazma işlemini yapmayız.
            //}















            // MAIN METOT İÇİ
            // aşırı yükleme, overloading
            // bir metodu birden fazla yöntemle kullanmak istiyrosak bunu overloading yöntemiyle kullanabiliriz.


            //    int sonuc1 = Topla(3, 5);
            //    double sonuc2 = Topla(3.4, 4.3);

            //    Console.WriteLine(sonuc1);

            //    Console.Read();

            //}

            // MAIN METOT DIŞI
            // aşırı yükleme 
            // yani burası şu şekilde çalışıyor: main içinde int sonuc1 ile Topla metodu çalıştırdığımızda int olarak toplama yapan Topla metoduna gidiyor, double işlem yapınca double ile Topla metodu çalıştırdığımızda ise aynı isimle oluşturduğumuz double toplama işlemi yapan Topla metoduna gidip çalıştırıyor ve işlem yapıyor. Aynı metot ismi tanımlayarak birden fazla metot çalıştırabiliyoruz buna overloading deniyor.
            //static int Topla(int a, int b) { 

            //    return a + b;
            //}

            //static double Topla(double a, double b)// burada bir overloading yaptık.
            //{

            //    return a + b;

            //}














            // kullanıcıdan boy ve kilo alın. Bir metoda bunları gönderin bu metot BMI kütle indexi numarası verecek mesela 26 bu sayıyı geriye değer döndürerek BMI metodundan alacagız. Sayıyı aldıktan bu sayıyı da başka bir metoda göndereceğiz bu metotta bu sayı 26 ise çok kilou diye mesaj verecek ekrana yazdıracak. Yani iki metod olacak biri değer döndürecek diğeri ekrana yazdıracak. bir vucüt kitle indexi hesaplayın. BMI.

            Console.Write("Kilonuzu girin (kg): ");
            var kilo = double.Parse(Console.ReadLine());
            Console.Write("Boyunuzu girin (m (0,00)): ");
            var boy = double.Parse(Console.ReadLine());

            BMIhesaplama(boy, kilo);
            Console.Read();
        }

        static double BMIhesaplama(double boy1, double kilo1)
        {
            double bmiSonuc = kilo1 / (boy1 * boy1);
            BMIyazdırma(bmiSonuc);

            return bmiSonuc;
        }
        static void BMIyazdırma(double bmiSonuc1)
        {
            if (bmiSonuc1<18.5)
            {
                Console.WriteLine("Düşük kilolusunuz. BMI: "+bmiSonuc1);
            }
            else if (18.5<bmiSonuc1 && bmiSonuc1 < 24.99)
            {
                Console.WriteLine("Normal kilolusunuz. BMI: " + bmiSonuc1);
            }
            else if (25.0 < bmiSonuc1 && bmiSonuc1 < 29.99)
            {
                Console.WriteLine("Fazla kilolusunuz. BMI: " + bmiSonuc1);
            }
            else if (30 < bmiSonuc1)
            {
                Console.WriteLine("Normal kilolusunuz. BMI: " + bmiSonuc1);
            }
            else
            {
                Console.WriteLine("Yanlış giriş tekrar hesaplayınız.");
            }
        }
    }
}
