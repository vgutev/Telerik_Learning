using System;

namespace LargerThanNeighbours
{
    class LargerThanNeighbours
    {
        static void Main()
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];
            string input = Console.ReadLine();
            arr = Array.ConvertAll(input.Split(' '), int.Parse);
            Console.WriteLine(LargerThanNeighbours(arr));
        }
        static int LargerThanNeighbours(int[] arr)
        {
            int count = 0;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i-1] < arr[i] && arr[i] > arr[i+1])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
