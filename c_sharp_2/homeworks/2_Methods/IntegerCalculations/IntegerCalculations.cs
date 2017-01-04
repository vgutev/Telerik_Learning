using System;
using System.Numerics;
namespace IntegerCalculations
{
    class IntegerCalculations
    {
        static void Main()
        {
            int[] numbers = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            MinMaxAvSumPro(numbers);
        }
        static void MinMaxAvSumPro(int[] numbers, bool min = true, bool max = true,
                                    bool average = true, bool sum = true, bool product = true)
        {
            int minimum = 1000;
            int maximum = -1000;
            double resAverage = 0;
            int resSum = 0;
            BigInteger resproduct = 1;
            // getting minimum value
            if (min == true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] < minimum)
                    {
                        minimum = numbers[i];
                    }
                }
                Console.WriteLine(minimum);
            }
            // getting maximum value
            if (max == true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > maximum)
                    {
                        maximum = numbers[i];
                    }
                }
                Console.WriteLine(maximum);
            }
            // getting average value
            if (average == true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    resAverage += numbers[i];
                }
                resAverage = resAverage / numbers.Length;
                Console.WriteLine("{0:f2}", resAverage);
            }
            // getting sum of the numbers
            if (sum == true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    resSum += numbers[i];
                }
                Console.WriteLine(resSum);
            }
            // getting product of the numbers
            if (product == true)
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    resproduct *= numbers[i];
                }
                Console.WriteLine(resproduct);
            }
        }
    }
}
