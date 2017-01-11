using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.AnimalHierarchy
{
    class Frog : Animal, ISound
    {
        public Frog(int age, string name, Sex sex) : base(age, name, sex)
        {
        }

        public string ProduceSound()
        {
            return "Kvak kvak, kvakiti kvak!";
        }
    }
}
