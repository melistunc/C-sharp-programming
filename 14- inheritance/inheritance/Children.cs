using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    sealed class Children : Human // sealed mühürlenmiş anlamına gelir yani artık Children'dan kalıtım yapamayız herhangi bir class Children class'ından kalıtım alamaz.
    {
        public string Lessons { get; set; }
    }
}
