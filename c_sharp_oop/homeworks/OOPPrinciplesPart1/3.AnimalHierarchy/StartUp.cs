using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Kitten[] kittens = new Kitten[]
            {
                new Kitten(3, "Mimi"),
                new Kitten(5, "Doncho"),
                new Kitten(7, "Trevor")
            };
            Console.WriteLine(Animal.AverageAge(kittens));
            Frog[] frogs = new Frog[]
            {
                new Frog(2, "Kermit", Sex.male),
                new Frog(4, "Stefcho", Sex.male),
                new Frog(1, "Bini", Sex.female)
            };
            Frogs[]=
            {
                Console.WriteLine(Animal.AverageAge());

             };
        }
            
        }
    }
}
