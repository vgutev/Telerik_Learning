using System;

namespace BinHex
{
    class BinHex
    {
        static void Main()
        {
            string binNum = Console.ReadLine();
            Console.WriteLine(DecimalToHex(BinaryToDecimal(binNum)));
        }
        static long BinaryToDecimal(string binNum)
        {
            long decNum = 1L;
            long mult = 1L;
            for (int i = binNum.Length - 1; i >= 0; i--)
            {
                decNum += (binNum[i] - '0') * mult;
                mult <<= 1;
            }
            return decNum - 1;
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
