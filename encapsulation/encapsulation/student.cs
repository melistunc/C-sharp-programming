using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encapsulation
{
    class Student
    {
        private string ad;
        private string soyad;
        private int[] not;
        private int notSayac =0;

        public string Ad {  // isim girme
        
            get { return ad; }
            set {

                if (!string.IsNullOrEmpty(value)) // gelen veri null veya boş mu. boşsa true gelecek, dolu olursa false gelecek. yani burası dolu olacak önündeki değil olduğu için. boş değilse atama işlemi yap.
                {
                    ad = value;
                }
                else // boşsa burası çalışacak.
                {
                    Console.WriteLine("Ad kısmını boş bırakmayınız.");
                }
            }
        }

        public void  NotEkle(int nots) // girilen notlar belirli bir dilimin üzerinde not girememeli. not ekleme
        {
            if (notSayac < not.Length) // sayac notlarımın uzunluğundan küçükse satırı çalıştır.
            {
                if (nots >=0 && nots <=100) // girilen parametre 0'dan büyük mü 100'den küçük mü true ise alt kod çalışır.
                {
                    not[notSayac] = nots; // dizi içerisindeki ilgili indexe dışarıdan gelen değeri ata.
                    notSayac++; //index'i arttırmalıyız ki aynı elemanla çakışmasın.
                }
                else
                {
                    Console.WriteLine("Not 0 ile 100 arasında olmalı");
                }

            }
            else // taşarsa büyükse bura çalışır.
            {
                Console.WriteLine("Daha fazla not eklenemez, dizi doldu!");
            }
        }

        public double Ortalama // ortalama alma
        {
            get {

                // eğer sayac 0 ise eleman girilmemiştir.
                if (notSayac == 0) // sayac 0 ise.
                {
                    return 0;
                }
                else
                {
                    double total = 0;
                    for (int i = 0; i < notSayac; i++)
                    {
                        total += not[i];//toplamını bulduk
                    }
                    return total/notSayac; // ortalaması döner
                }
            }
        }
        public void DiziyiBaslat(int sizedizi)
        {
            not = new int[sizedizi];// dizi boyutunu belirtmek ve diziyi new'lemek için.
        }
    }
}
