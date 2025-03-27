using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Employee : Person
        // kalıtım yaptık. Person'u Employee'ye aktardık.
    {
        public string Job {  get; set; }
        public decimal Salary { get; set; }
    }
}
