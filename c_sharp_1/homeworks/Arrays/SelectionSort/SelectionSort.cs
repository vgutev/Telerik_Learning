using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    if (a[i] > a[j])
                    {
                        a[i] = a[j] + a[i];
                        a[j] = a[i] - a[j];
                        a[i] = a[i] - a[j]; 
                    }

                }
                Console.WriteLine(a[i]);
            }

        }
    }
}
