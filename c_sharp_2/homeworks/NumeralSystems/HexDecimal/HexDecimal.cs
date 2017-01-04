using System;

namespace HexDecimal
{
    class HexDecimal
    {
        static void Main()
        {
            string hexNum = Console.ReadLine();
            Console.WriteLine(HexToDec(hexNum));
        }
        static long HexToDec(string hexNum)
        {
            long decNum = 0L;
            long mult = 1L;
            for (int i = hexNum.Length - 1; i >= 0; i--)
            {
                if (47< hexNum[i] && hexNum[i] < 58)
                {
                    decNum += int.Parse(hexNum[i].ToString()) * mult;
                    mult <<= 4;
                }
                else
                {
                    decNum += int.Parse((hexNum[i]-55).ToString()) * mult;
                    mult <<= 4;
                }
            }
            return decNum;
        }

    }
}
