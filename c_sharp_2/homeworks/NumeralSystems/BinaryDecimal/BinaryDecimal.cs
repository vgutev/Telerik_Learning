using System;

namespace BinaryDecimal
{
    class BinaryDecimal
    {
        static void Main()
        {
            string num = Console.ReadLine();
            Console.WriteLine(BinaryToDecimal(num));
        }
        static long BinaryToDecimal (string binNum)
        {
            long decNum = 1L;
            long mult = 1L;
            for (int i = binNum.Length - 1; i >=0 ; i--)
            {
                decNum += (binNum[i] - '0') * mult;
                mult <<= 1; 
            }
            return decNum - 1;
        }
    } 
}
