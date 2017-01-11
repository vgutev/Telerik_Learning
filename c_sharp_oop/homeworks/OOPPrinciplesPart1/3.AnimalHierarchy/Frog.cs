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
