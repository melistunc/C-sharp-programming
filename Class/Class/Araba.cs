using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Araba // yeni bir class oluşturduk Araba isminde.
    {
        public string marka = "Ferrari"; // buradaki değişkenler de gizlidir bunları da açık yapmalıyız yani public yapmalıyız ki nesne ile kullanabilelim.
        public string model= "Competizione 812";
        public string renk = "Burgundy";
        public int yil = 2021; // araba'nın özellikleri.

        // farklı metotlar oluşturarak bu özellikleri yönetebiliriz.

        // yapıcı metot, constructor
        public Araba(string marka1, string model1, string renk1, int yil1) { // sınıf ismi ile aynı isim vermeliyiz ve nesne gibi parantez açmalıyız bu bir constructor metottur. public yazmalıyız.

            this.marka = marka1;
            this.model = model1;
            this.renk = renk1;
            this.yil = yil1;

        }

        public void BilgiYazdır() // void önüne herhangi bir şey yazmazsak bunu otomatik olarak private kabul eder açmak için herkes public yazmalıyız.
        {
            Console.WriteLine($"Marka: { marka}, Renk: {renk}, Yıl: {yil}, Model: {model}");
        } // şimdi main metot içinde bu class'ı çağırmak istiyoruz. Değişkenleri kullanmak. İlk önce Program.cs içinden buradaki Araba class'ına ulaşmak istiyoruz.

        /*public void DegerAta(string marka1, string model1, string renk1, int yil1) // yukarıda tanımladığımız parametrelere değer atamak için oluşturduk ve bu metoda yeni değişkenler atadık. Program.cs'te kullanmak için public'e çevirdik.Boşsa private olarak kabul edilir. Yapıcı metotu açıklamak için
        {
            this.marka = marka1; // marka burada tanımladığımız marka1 değişkenine atansın. this.marka class'ın içerisindeki markayı temsil ediyor. this Araba class'ını temsil eder.
            this.model = model1;
            this.renk = renk1;
            this.yil = yil1;
        }*/
    }
}
