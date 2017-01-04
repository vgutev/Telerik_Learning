using System;
using System.Text;

namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ReverseStr(input));
        }

        static string ReverseStr(string input)
        {
            StringBuilder revInput = new StringBuilder();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                revInput.Append(input[i]);
            }
            return revInput.ToString();
        }
    }
}
