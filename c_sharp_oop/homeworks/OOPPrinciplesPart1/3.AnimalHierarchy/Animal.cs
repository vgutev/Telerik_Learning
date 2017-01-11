using System;
namespace _3.AnimalHierarchy
{
    class Animal
    {
        private int age;
        private string name;
        private Sex sex;

        public int Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value >= 0)
                {
                    this.age = value;
                }
                else
                {
                    throw new ArgumentException("Age can't be negative!");
                }
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid name entered!");
                }
            }
        }
        public Sex Sex
        {
            get
            {
                return this.sex;
            }
            protected set
            {
                this.sex = value;
            }
        }
        
        public Animal(int age, string name, Sex sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public static void AverageAge(Animal[] animals)
        {
            int sumAge = 0;
            int counter = 0;
            foreach (var animal in animals)
            {
                sumAge += animal.age;
                counter++;
            }
            string animalType = animals.GetType().Name;
            animalType = animalType.Remove(animalType.Length - 2) + "s";
            Console.WriteLine("The average age of {0} in the list is: \t{1}", animalType, sumAge / counter);
        }
    }
}
