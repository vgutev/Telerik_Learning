using System;

namespace RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int res = 0;
            int[] arr = new int[n];
            int[] check = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                check[i] = 1;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (arr[i] >= arr[j] && check[i] <= check[j] + 1)
                    {
                        check[i] = check[j] + 1;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (res < check[i])
                    res = check[i];
            }
            Console.WriteLine(res);
        }
    }
}
