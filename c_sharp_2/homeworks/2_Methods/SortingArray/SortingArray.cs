using System;

namespace SortingArray
{
    class SortingArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            SortArray(n, arr);
        }

        private static void SortArray(int n, int[] arr)
        {
            int max = 0;
            int temp = 0;
            for (int i = 0; i < n; i++)
            {
                temp = arr[i];
                max = MaxElemnt(arr, i);
                arr[i] = arr[max];
                arr[max] = temp;
            }
            Array.Reverse(arr);
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }

        static int MaxElemnt(int[] arr,int from)
        {
            int maxIndex = 0;
            int max = int.MinValue;
            for (int i = from; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
    }
}
