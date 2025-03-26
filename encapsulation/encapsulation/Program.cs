using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            // kapsülleme
            Person person = new Person(); // propertiesde de kullanacağız.
            
            person.SetName("Ad");
            // bir kontrol yapmak istiyorsak mesela burada name=e sayı olarak string eğil de her zaman bir kelime karakter girilmesinin kontrolünü kapsülleme ile yaparız. setname ile veriye değer atadık.
            Console.WriteLine(person.GetName()); // getname ile değer okuyabiliriz. getname ile veriyi okduk.


            //2.form
            person.SetName("Ad2"); // birden fazla form kullandığımızda kapsülleme çok işimize yarar bir işi tek bir fonksiyon üzerinden yapmış oluruz.







            // properties
            person.Name = "Melis"; // değer atadık
            Console.WriteLine(person.GetName()); // değer okuduk.







            // veri doğrulama
            Person2VeriDogrulama person2VeriDogrulama = new Person2VeriDogrulama(); //nesne tanımladık.

            person2VeriDogrulama.Age = 23; // değer atadık set ile.Burada yaşın eksili veya yanlış girilmesini önlemek istiyoruz. Yaşı sıfırdan küçük olmasın.
            Console.WriteLine(person2VeriDogrulama); // değer okuduk get ile.
         
            





            // kulanıcı not sistemi. Bir calss olacak student isminde bunun iç değişkeni olacak, ad, not, soyad. notlar bir dizide saklanacak 1.not 30, 2.not 95 gibi. bir de bir tane sayac oluşturulabilir, diziyi kontrol etmek için. Ad'a değer ataması yaparken bu ad'a boş bir değer atamamalı kullanıcı. notları ekleyebilmek için de bir metot oluşturcaz. Öğrenciden notları alacağız bunları toplayıp ortalamasını alacağız. hesaplamayı da metot içerisinde yapacağız.

            Student student = new Student();
            
            Console.WriteLine("Ogrenci adi: "); // iami kullanıcıdan aldık.
            student.Ad = Console.ReadLine();

            Console.WriteLine("Kac not gireceksiniz: ");
            int size = int.Parse(Console.ReadLine());

            student.DiziyiBaslat(size);


            Console.WriteLine("Notları girin: ");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Not {i+1}: ");
                int not = int.Parse(Console.ReadLine());
                student.NotEkle(not);
            }

            Console.WriteLine($"\nOgrenci: {student.Ad}");
            Console.WriteLine($"\nOgrenci: {student.Ortalama}");

            Console.Read();
        }
    }
}
