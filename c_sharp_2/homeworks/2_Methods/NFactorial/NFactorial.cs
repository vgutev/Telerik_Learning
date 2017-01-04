using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            BigInteger result = 0;
            string sNum = num.ToString();
            int[] arrNum = new int[sNum.Length];

            if (num == 0 || num == 1)
            {
                Console.WriteLine(1);
                return;
            }
            for (int i = 0; i < sNum.Length; i++)
            {
                arrNum[i] = int.Parse(sNum[i].ToString());
            }
            result = MultiArr(arrNum, num- 1);
            for (int i = num - 2; i > 0 ; i--)
            {
                result *= i;
            }
            Console.WriteLine(result);
        }
        static int MultiArr(int[] arr, int multiplier)
        {
            int multi = 1;
            int Num = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Num += arr[i] * multi;
                multi *= 10;
            }
            Num *= multiplier;
            return Num;
        }
    }
}
