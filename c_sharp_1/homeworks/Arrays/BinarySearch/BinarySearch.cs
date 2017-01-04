using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int item = 0;
            int res = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            item = int.Parse(Console.ReadLine());
            if (Array.BinarySearch(a, item) < 0)
            {
                res = -1;
            }
            else
                res = Array.BinarySearch(a, item);
            Console.WriteLine(res); 
        }
    }
}
