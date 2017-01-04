using System;
namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] n1 = new int[n];
            int[] n2 = new int[n];
            for (int i = 0; i < n; i++)
            {
                n1[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                n2[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (n1[i] != n2[i])
                {
                    Console.WriteLine("Not equal");
                    Environment.Exit(1);
                }
            }
            Console.WriteLine("Equal");
        }
    }
}
