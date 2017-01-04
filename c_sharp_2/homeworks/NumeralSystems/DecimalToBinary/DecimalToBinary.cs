using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalBinary(num));
        }
        static string DecimalBinary(long  dec)
        {
            string binary = string.Empty;
            while (dec > 0)
            {
                binary = (dec & 1) + binary;
                dec >>= 1;
            }
            return binary;
        }
    }
}
