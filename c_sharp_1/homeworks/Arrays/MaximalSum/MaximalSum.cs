using System;
namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int mem = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum = 0;
                for (int j = i; j < n; j++)
                {
                    sum += a[j];
                    if (sum > mem)
                    {
                        mem = sum;
                    }
                }
            }
            Console.WriteLine(mem);
        }
    }
}
