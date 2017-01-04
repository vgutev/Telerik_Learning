using System;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int tempTimes = 0;
            int times = 0;
            int num = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                tempTimes = 0;
                for (int j = i; j < n; j++)
                {
                    if (a[i] == a[j])
                    {
                        tempTimes++;
                    }
                    if (tempTimes > times)
                    {
                        times = tempTimes;
                        num = a[i];
                    }
                }
            }
            Console.WriteLine("{0} ({1} times)", num, times);
        }
    }
}
