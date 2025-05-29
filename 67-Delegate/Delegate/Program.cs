using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Program
    {

        delegate void InputIslemleri(string input);  // sırasıyla birden fazla metot oluşturacağız ve delegate içine atacağız. delegate çağırdığımızda bunlar sıra ile çalışacak.


        static void InputAl(string input) {

            Console.WriteLine("Input alındı: "+input);
        }// new'lemeyeceğimiz için static oluşturduk.

        static void InputKontrolEt(string input) {

            Console.WriteLine("Input kontrol edildi.");
        }

        static void InputEkle(string input) {

            Console.WriteLine("Input database'e eklendi.");
        }

        static void Main(string[] args)
        {
            // delegate'siz
            /* InputAl("Deneme");
            InputKontrolEt("Deneme");
            InputEkle("Deneme"); */

            InputIslemleri inputislemleri = new InputIslemleri(InputAl);

            // DELEGATE'E METOTLARI EKLEME
            inputislemleri += InputKontrolEt;
            inputislemleri += InputEkle; 
            // ilgili metotları ekler.

            Delegate[] delegateMetotlarim = inputislemleri.GetInvocationList();// getinovationlist delegate listesini geri döndürür. geriye döndürdüğü tür delegate.

            // DELEGATE'DEN METOTLARI ÇIKARMA
            inputislemleri -= InputKontrolEt; // islemlerden kontrolet'i çıkarttık.

            // DELEGATE'E METOT EKLEME
            foreach (var item in inputislemleri.GetInvocationList()) // listenin içinde tek tek gezindi.
            {
                Console.WriteLine($"{item.Method.Name}"); // listeyi yazdırdı.
            }

            inputislemleri.Invoke("Data"); // delegate türünde oluşturduğumuz metottan oluşturduğumuz nesneyi çalıştır. 

            Console.ReadLine();
        }
    }
}
