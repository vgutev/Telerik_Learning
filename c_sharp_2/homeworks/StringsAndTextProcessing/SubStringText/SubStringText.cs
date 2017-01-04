using System;

namespace SubStringText
{
    class SubStringText
    {
        static void Main()
        {
            string pattern = Console.ReadLine();
            string input = Console.ReadLine();
            Console.WriteLine(SubStringCount(input, pattern));
        }
        static int SubStringCount(string input, string pattern)
        {
            input = input.ToLower();
            pattern = pattern.ToLower();
            short count = 0;
            int index = 0;
            while (input.Contains(pattern))
            {
                index = input.IndexOf(pattern) + pattern.Length;
                input = input.Substring(index);
                count++;
            }
            return count;
        }
    }
}
