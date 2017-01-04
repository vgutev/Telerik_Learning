using System;

namespace SumIntegers
{
    class SumIntegers
    {
        static void Main()
        {
            string nums = Console.ReadLine();
            int[] arrNums = Array.ConvertAll(nums.Split(' '), int.Parse);
            Console.WriteLine(SumOfInts(arrNums));
        }
        static int SumOfInts(int[] arrNums)
        {
            int sum = 0;
            for (int i = 0; i < arrNums.Length; i++)
            {
                sum += arrNums[i];
            }
            return sum;
        }
    }
}
