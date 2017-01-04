using System;

namespace AnyToAny
{
    class AnyToAny
    {
        static void Main()
        {
            byte inBase = byte.Parse(Console.ReadLine());
            string inNum = Console.ReadLine();
            byte outBase = byte.Parse(Console.ReadLine());
            Console.WriteLine(DecimalToAny(AnyToDec(inNum, inBase), outBase));
        }

        static long AnyToDec(string inNum, byte inBase)
        {
            long decNum = 0L;
            long tempBase = 1L;
            for (int i = inNum.Length - 1; i >= 0; i--)
            {
                if (47 < inNum[i] && inNum[i] < 58)
                {
                    decNum += int.Parse(inNum[i].ToString()) * tempBase;
                    tempBase *= inBase;
                }
                else
                {
                    decNum += int.Parse((inNum[i] - 55).ToString()) * tempBase;
                    tempBase *= inBase;
                }
            }
            return decNum;
        }
        static string DecimalToAny(long decNum, byte outBase)
        {
            string outNum = string.Empty;
            while (decNum > 0)
            {
                if (decNum % outBase < 10)
                {
                    outNum = (decNum % outBase) + outNum;
                    decNum /= outBase;
                }
                else
                {
                    outNum = (char)((decNum % outBase) + 55) + outNum;
                    decNum /= outBase;
                }
            }
            return outNum;
        }
    }
}
