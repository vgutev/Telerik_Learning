using System;

namespace StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            string a = "Hello";
            string b = "World";
            object x = a + " " + b;
            string c = (string)x;
            Console.WriteLine(c);
        }
    }
}
