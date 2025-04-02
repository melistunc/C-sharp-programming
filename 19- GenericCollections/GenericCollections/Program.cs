using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            arrayList.Add("Ahmet");
            arrayList.Add(1); // arraylist'te farklı farklı elemanlar listeye ekleyebiliyorduk.Güvensiz bir tip idi.

            // biz burada sadece tek bir türde değerler atansın yani listeye sadece int atansın gibi.
            List<int> sayilar = new List<int>(); // sayilar isimli list oluşturduk. <> arasına listemizin türünü veriyoruz. 
            sayilar.Add(1);
            //sayilar.Add("Mehmet"); // hatalı olur çünkü belli bir tip oluşturduk ve sadece o tipten değerleri kabul ediyoruz.

            List<string> isimler = new List<string>(); // string türünde isimler isimli liste. Sadece string türünde değişkenler tutulur.
            isimler.Add("Melis");
            isimler.Add("Nisa");
            isimler.Add("Ayşegül");  
            




            Customer customer1 = new Customer();
            customer1.Name = "Test";
            customer1.Id = 1;
            customer1.Surname = "Testt";

            List<Customer> customer = new List<Customer>(); // oluşturduğumuz özel tür olan Customer tipini listeye verdik. Yani Customer türünde bir liste ol ve sadece Customer'lari tut.
            customer.Add(new Customer() // customer'ı içeride tanımladık ve içindeki data'ları ekledik. Yani zaten tanımlamıştık burada veri eklemek için tanımladık.
            {
                Id = 2,
                Name = "Ahmet",
                Surname = "Ahmet soyad"

            });

        }
    }
}
