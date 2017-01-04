using System;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] numbers = Array.ConvertAll(sInput, int.Parse);
            int max = int.MinValue;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int tempMax;
                tempMax = GetMax(numbers[i], numbers[i + 1]);
                if (tempMax > max)
                {
                    max = tempMax;
                }
            }
            Console.WriteLine(max);
        }
        static int GetMax(int num1, int num2)
        {
            int bigger = num1;
            if (bigger < num2)
            {
                bigger = num2;
            }

            return bigger;
        }
    }
}
