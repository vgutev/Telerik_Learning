using System;

namespace BinaryShort
{
    class BinaryShort
    {
        static void Main()
        {
            short num = short.Parse(Console.ReadLine());
            Console.WriteLine(ShortBinary(num));
        }
        static string ShortBinary(short shortNum)
        {
            string binary = string.Empty;
            bool isNegative = false;
            if (shortNum < 0)
            {
                shortNum += 32767;
                shortNum++;
                isNegative = true;
            }
            while (shortNum > 0)
            {
                binary = (shortNum & 1) + binary;
                shortNum >>= 1;
            }
            for (int i = binary.Length; i < 15; i++)
            {
                binary = "0" + binary;
            }
            if (isNegative == true)
            {
                binary = "1" + binary;
            }
            else
            {
                binary = "0" + binary;
            }
            return binary;
        }
    }
}
