using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace typeAndUnsafeCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            // arraylist
            // koleksiyonlar diziler gibi yapılardır. burada da veriler saklanır.

            ArrayList liste = new ArrayList(); // burada dizilerden farklı olarak bir uzunluk belirtmeyiz. Bunlar dinamik olarak boyutlanır. Boyutları kendisi otomatik olarak yapar. 
            // Arraylist'lerde değerlerin aynı türden olması şartı yoktur, farklı türden veri türleri saklanabilir.

            liste.Add(1);
            liste.Add(3.12);
            liste.Add("Melis"); // listeye Melis string türünde veri ekle.
            liste.Remove(1); // eklenen 1 verisini sil.

            foreach (var item in liste)
            {
                Console.WriteLine(item);

            }






            // hashtable
            // hashtable'ı ekrana yazdırırken bir dictionary olarak tanımlamamız gerekiyor. Türü dict olmalıdır.
            // ke-value değerleri dictioanryEntry içerisinde tutulur.
            // hashtable sıralı liste değildir yani elemanlar sıralı şekilde saklanmazlar.
            Hashtable listem = new Hashtable();
            listem.Add(1,"bir"); // hashtable'da bir key bir de value koymalıyız. (Anahtar-değer) bazlı çalışıyor.
            //listem.Add(2, "iki");
            //listem.Add(3, "araba");
            //listem.Add(4, "avm");
            //listem.Add(19, "futbol");
            listem.Add("home", "ev");
            listem.Add("key", "anahtar");
            listem.Add("car", "araba");

            foreach (DictionaryEntry entry in listem)
            {
                Console.WriteLine($"Aanahtar: {entry.Key} Value: {entry.Value}");
            }






            // sortedList
            // hastable ile aynı kullanıma shaip fakat tek farkı sortListe sıralı şekilde sıralanır.

            SortedList list1 = new SortedList(); // sıralamayı karışık şekilde verirsek bile yani karışık eklersek bile sortedlist bunu kendi içinde sıralamaya koyup ekrana verir.
            list1.Add(3, "üç");
            list1.Add(1, "bir");
            list1.Add(2, "iki");


            foreach (DictionaryEntry entry in list1)
            {
                Console.WriteLine($"Anahtar: {entry.Key}, Değer: {entry.Value}");
            }






            // queue
            // first in first out, fifo.
            //ilk giren ilk çıkar.
            //bazı işlemlerde katmanlı olarak sıralama işlemi yapmak isteriz.

            Queue list2 = new Queue();
            list2.Enqueue("Melis"); // enque ile ekleriz eleman.
            list2.Enqueue("Buse");
            list2.Enqueue("İpek");
            list2.Enqueue("Beyza");

            Console.WriteLine(list2.Dequeue());// bize dequeue ilk elemanı verir.İlk elemanı çıkarır. Melis
            Console.WriteLine(list2.Peek()); // peek bize ikinci elemanı verir yani dequeue ile çıkan ilk elemandan sonraki elemanı çıkarır. Buse






            // stack
            // last in first out, lifo
            // son gelen ilk çıkar.
            // yığın mantığı ile çalışır.

            Stack list3 = new Stack();
            list3.Push("siyah"); // push ile yığına eklenir.
            list3.Push("burgundy");
            list3.Push("lacivert");
            list3.Push("beyaz");
            list3.Push("yeşil");
            list3.Push("turuncu");

            Console.WriteLine(list3.Pop()); // en son eklenen elemanı çıkarır ve o elemanı geri döndürür. 2'yi çıkaracak ve 2'yi ekrana yazdıracak. Geri döndürdüğü için ekrana bu çıkardığımız elemanı yazdırabiliyoruz.
            Console.WriteLine(list3.Peek()); // peek ile yukarıdaki gibi bir sonraki elemanı çıkarır ekrana yazdırırız.
            Console.Read();
        }
    }
}
