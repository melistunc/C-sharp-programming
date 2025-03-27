using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virtualMethod
{
    class Kedi : Hayvan
    {
        public override void SesCikar() // override etmek yani geçersiz kılmak yani sescıkar metodunun üstüne yazmak.
        {
            Console.WriteLine("Miyav miyav"); // sescikar metotdunu güncellemiş olduk.
        }
    }
}
