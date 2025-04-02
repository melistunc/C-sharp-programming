using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Apple
    {
        public string computer;
        public string pencil;
        public string earphones;
        public string keyboard;
        public string tablet;
        public string phone;
        public Apple(string computer1, string pencil1, string earphones1, string keyboard1, string tablet1, string phone1)
        {
            this.computer = computer1;
            this.pencil = pencil1;
            this.earphones = earphones1;
            this.keyboard = keyboard1;
            this.tablet = tablet1;
            this.phone = phone1;
        }
        public void BilgiYazdır()
        {
            Console.WriteLine($"Bilgisayar: {computer}, Telefon: {phone}, Kalem: {pencil}, Kulaklık: {earphones}, Klavye: {keyboard}, Tablet: {tablet}" );
        }
    }
}
