using System;

namespace MaximalSequence
{
    class MaximalSequence
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int times = 1;
            int mem = 1;
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 1; i < n; i++)
            {
                if (a[i] == a[i-1])
                {
                    times++;
                    if (times > mem)
                        mem = times;
                }
                else
                {
                    times = 1;
                }
            }
            Console.WriteLine(mem);
        }
    }
}
