namespace _3.AnimalHierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Animal.AverageAge(kittens);
            Kitten[] kittens = new Kitten[]
            {
                new Kitten(3, "Mimi"),
                new Kitten(5, "Doncho"),
                new Kitten(7, "Trevor")
            };
            Animal.AverageAge(kittens);
            //Animal.AverageAge(frogs);
            Frog[] frogs = new Frog[]
            {
                new Frog(2, "Kermit", Sex.male),
                new Frog(4, "Stefcho", Sex.male),
                new Frog(1, "Bini", Sex.female)
            };
            Animal.AverageAge(frogs);
            //Animal.AverageAge(dogs);
            Dog[] dogs = new Dog[]
            {
                new Dog(3, "Steven", Sex.male),
                new Dog(5, "Amy", Sex.female),
                new Dog(1, "Lindsey", Sex.female)
            };
            Animal.AverageAge(dogs);
            //Animal.AverageAge(cats);
            Cat[] cats = new Cat[]
            {
                new Cat(9, "Mandy", Sex.male),
                new Cat(3, "Jessie", Sex.female),
                new Cat(5, "Tom", Sex.male)
            };
            Animal.AverageAge(cats);
            //Animal.AverageAge(tomcats);
            Tomcat[] tomcats = new Tomcat[]
            {
                new Tomcat(3, "Slavi"),
                new Tomcat(4, "Omurtag"),
                new Tomcat(1, "Archie")
            };
            Animal.AverageAge(tomcats);
        }
    }
}
