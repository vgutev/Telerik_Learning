using System;
using System.Text;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(ParseTagsText(input));
        }
        static string ParseTagsText(string input)
        {
            string[] splitPattern = { "<upcase>", "</upcase>" };
            StringBuilder corrOut = new StringBuilder();
            string[] inputSplit = input.Split(splitPattern, StringSplitOptions.None);
            for (int i = 0; i < inputSplit.Length; i++)
            {
                if (i % 2 == 0)
                {
                    corrOut.Append(inputSplit[i]);
                }
                else
                {
                    corrOut.Append(inputSplit[i].ToUpper());
                }
            }
            return corrOut.ToString();
        }
    }
}
