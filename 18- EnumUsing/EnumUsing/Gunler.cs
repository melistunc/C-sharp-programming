using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumUsing
{
    public enum Gunler
    {
        /*public string Gun { get; set; } // get set olduğu için program.cs'ten veri değişken girişi yapabiliyoruz.*/
        Pazartesi,
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar // class'ı silip burayı enum yaptık yani böylece Gunler'i çağırdığımız zaman otomatikmen sadece buradaki değişkenlerden vermek zorunda olacağız.
    }
}
