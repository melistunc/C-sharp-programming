using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Program
    {
        static void Main(string[] args) // interface, metotlaarımızı ve özelliklerine tanımladığımız bir class çeşididir. interface'te sadece imzalar olur sadece tanımlamak istediğimiz anahtar kelimeler olur fazlası detaylısı olmaz.Bunu da kalıtım aldığımız yerlerde kulllanmak zorundayız.interface diyerek tanımlamak zorundayız.
        {

            IArac arac = new Arac(); // interface türünde bir araç oluşturduk bu araç Aarac class'ından geldi.

            arac.Durdur();
            arac.Calistir();






            // interface'ler new'lenemez. Interface'lerden nesne oluşturulamaz.
            IHayvan hayvan = new Kopek();
            IHayvan hayvan1 = new Kedi();
            IKosabilir kosabilir = new Insan();
            IKosabilir kosankopek = (IKosabilir)hayvan; // hayvan'ı Ikosabilir'e kast et diyoruz. yani burada Ihayvan ve Ikosabilir birbirlieriyle kalıtım uapmamıştır fakat dolayılı olarak bir class içinden kalıtım verdikleri için birbirlerini kast edebilirler bu şekilde.

            hayvan.SesCikar();
            hayvan1.SesCikar();
            kosabilir.Kos(); //ekranda: havhav, miav miav, insan kosuyor--yazar.
            kosankopek.Kos(); // hayvanı kosabilir türe kast etmiş olduk. Ekranda kopek koşuyor yazar.
            Console.Read();
        }
    }
}
