using System;
namespace MaximalKSum
{
    class MaximalKSum
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(a);
            for (int i = n-1; i >= n - k; i--)
            {
                sum += a[i];
            }
            Console.WriteLine(sum);
        }
    }
}
