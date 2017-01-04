using System;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static void Main()
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arr = new int[arrSize];
            string input = Console.ReadLine();
            int numberX = int.Parse(Console.ReadLine());
            arr = Array.ConvertAll(input.Split(' '), int.Parse);
            Console.WriteLine(SameNumCount(numberX, arr));
        }

        static int SameNumCount(int number, int[] array)
        {
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
