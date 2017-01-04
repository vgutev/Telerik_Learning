using System;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        { 
            string input = Console.ReadLine();
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(@"\u" + string.Format("{0:X}", (int)input[i]).PadLeft(4, '0'));
            }
            Console.WriteLine();
        }
    }
}
