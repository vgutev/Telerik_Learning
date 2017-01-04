using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExtractSentences2
{
    class Program
    {
        static void Main()
        {
            string word = Console.ReadLine();
            string input = Console.ReadLine();
            Console.WriteLine(Extract2(input));
        }
        static string Extract2(string input)
        {
            StringBuilder formatted = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]) && !char.IsWhiteSpace(input[i]) && !(input[i] == '.'))
                {
                    formatted.Append(' ');
                }
                else
                {
                    formatted.Append(input[i]);
                }
            }
            return formatted.ToString();
        }
    }
}
