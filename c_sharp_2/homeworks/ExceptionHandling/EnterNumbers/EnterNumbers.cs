using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int[] numbers = Numbers();
            Console.Write("1 < ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0} < ", numbers[i]);
            }
            Console.Write("100");

        }
        static int[] Numbers(int start = int.MinValue, int end = int.MaxValue)
        {
            int[] numbers = new int[10];
            string[] sNumbers = new string[10];
            for (int i = 0; i < 10; i++)
            {
                sNumbers[i] =  Console.ReadLine();
            }
            try
            {
                for (int i = 0; i < 10; i++)
                {
                    numbers[i] = int.Parse(sNumbers[i]);
                }
                for (int i = 1; i < 10; i++)
                {
                    if (numbers[i] <= numbers[i - 1] || numbers[i - 1] < 2 || numbers[i] > 99)
                    {
                        throw new Exception();
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
                Environment.Exit(1);
            }
            return numbers;
        }
    }
}
