using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person person = new Person();
            //person.FirstName = "Melis";
            //person.LastName = "Tunç";
            //person.Age = 23;

            //Console.WriteLine(person.FullName);
            //Console.WriteLine(person.Introduce);










            var employee = new Employee(); // bir çalışan oluşturduk. Employee class'ı ile.
            employee.FirstName = "Beren"; // Person calss'ından kalıtım yoluyla aldıgımız bilgiler.
            employee.LastName = "Saat"; // Person calss'ından kalıtım yoluyla aldıgımız bilgiler.
            employee.Age = 25; // Person calss'ından kalıtım yoluyla aldıgımız bilgiler.
            employee.Job = "Actor";
            employee.Salary = 180000;

            Console.WriteLine(employee.Introduce); // verdiğimiz tüm bilgileri ekranda gösterir.








            var student = new Student(); // değişken tanımladık nesne ile Student class'ı içinden oluşturduk.
            student.FirstName = "Melia";
            student.LastName = "Tunç";
            student.Age = 23;
            student.Lessons = "Math";
            Console.WriteLine(student.Introduce);









            // consructor
            School school = new School();








            //protected erişim belirleyici
            Cat cat = new Cat();
            cat.Miyavla();

            //Animal animal = new Animal();
            //animal.Name = "Selina";
            //animal.SesCikar(); // animal class'ının burada değil sadece miras alındığı yer yani Cat class'ı içinde kullanılmasını istiyorum.








            //bir araç sınıfı olacak bu araç sınıfı iki sınıfa miras verecek. bir de motosiklete miras verecek. 

            Formula formula = new Formula();
            formula.Marka = "Ferrari";

            Motosiklet motosiklet = new Motosiklet();
            motosiklet.Marka = "BMW";

            Car car = new Car();
            car.BilgiYazdir();
            Console.Read();
        }
    }
}
