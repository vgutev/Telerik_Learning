using System;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(LastDigitString(num));
        }

        static string LastDigitString (int number)
        {
            string[] sLastDigit = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            do
            {
                number %= 10;
            } while (number / 10 != 0);
            return sLastDigit[number];
        }
    }
}
