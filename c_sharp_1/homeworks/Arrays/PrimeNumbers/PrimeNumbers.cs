using System;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool [] arr = new bool[n+1];
            int biggest = 0;
            for (int i = 0; i < n+1; i++)
            {
                arr[i] = true;
            }
            for (int i = 2; i < n+1; i++)
            {
                if (arr[i])
                {
                    for (int j = 2; (j * i) < n+1; j++)
                    {
                        arr[j * i] = false;
                    }
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    biggest = i;
                }
            }
            Console.WriteLine(biggest);
        }
    }
}
