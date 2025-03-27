using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte Age { get; set; }

        //public string FullName()
        //{
        //    return $"{FirstName} {LastName}";
        //}

        public string FullName => $"{FirstName} {LastName}"; // değişken gibi tanımladık fullname'i fullname yazınca bu yazdığımız cümle ekrana gelsin diyoruz. Yukarıdaki metotu oluşturmak yerine bu şekilde tanımladık. => kullandığımızda return kullanmaya gerek yoktur aynı işlevi görürler. Bu işaret geriye sağındaki değeri döndüreceğini söyler.
        public string Introduce => $"Hi, I'm {FullName}";


       
    }
}
