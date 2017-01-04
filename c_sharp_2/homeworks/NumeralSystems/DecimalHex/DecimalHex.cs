using System;
namespace DecimalHex
{
    class DecimalHex
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToHex(num));
        }
        static string DecimalToHex(long decNum)
        {
            string hex = string.Empty;
            while (decNum > 0)
            {
                if (decNum % 16 < 10)
                {
                    hex = (decNum % 16) + hex;
                    decNum >>= 4;
                }
                else
                {
                    hex = (char)((decNum % 16) + 55) + hex;
                    decNum >>= 4;
                }
            }
            return hex;
        }

    }
}
