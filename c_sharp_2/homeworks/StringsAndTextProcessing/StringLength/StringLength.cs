using System;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(StringLengthFill(input));
        }
        static string StringLengthFill(string input)
        {
            input = input.PadRight(20, '*');
            return input;
        }
    }
}
