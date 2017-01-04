using System;

namespace HexBinary
{
    class HexBinary
    {
        static void Main()
        {
            string hexNum = Console.ReadLine();
            Console.WriteLine(DecimalBinary(HexToDec(hexNum))); 
        }
        static long HexToDec(string hexNum)
        {
            long decNum = 0L;
            long mult = 1L;
            for (int i = hexNum.Length - 1; i >= 0; i--)
            {
                if (47 < hexNum[i] && hexNum[i] < 58)
                {
                    decNum += int.Parse(hexNum[i].ToString()) * mult;
                    mult <<= 4;
                }
                else
                {
                    decNum += int.Parse((hexNum[i] - 55).ToString()) * mult;
                    mult <<= 4;
                }
            }
            return decNum;
        }
        static string DecimalBinary(long dec)
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
