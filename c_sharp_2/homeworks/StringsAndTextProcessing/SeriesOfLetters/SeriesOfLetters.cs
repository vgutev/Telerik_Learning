using System;
using System.Text;
namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            string input = Console.ReadLine();
            Console.WriteLine(RemDoubleLetters(input));
        }
        static string RemDoubleLetters(string input)
        {
            StringBuilder trimmOut = new StringBuilder();
            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i] != input[i + 1])
                {
                    trimmOut.Append(input[i]);
                }
            }
            trimmOut.Append(input[input.Length - 1]);
            return trimmOut.ToString();
        }
    }
}
