using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Cat : Animal, ISound
    {
        public Cat(int age, string name, Sex sex) : base(age, name, sex)
        {
        }

        public string ProduceSound()
        {
            return "Meow";
        }
    }
}
