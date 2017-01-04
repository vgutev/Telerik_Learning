using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static void Main()
        {
            decimal number = decimal.Parse(Console.ReadLine());
            PrintReverseDigits(number); 
        }
        static void PrintReverseDigits(decimal number)
        {
            string revNum = number.ToString();
            for (int i = revNum.Length - 1; i >= 0; i--)
            {
                Console.Write(revNum[i]);
            }
            Console.WriteLine();
        }
    }
}
