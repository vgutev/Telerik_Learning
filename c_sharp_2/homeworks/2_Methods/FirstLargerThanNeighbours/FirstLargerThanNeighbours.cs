using System;

namespace FirstLargerThanNeighbours
{
    class FirstLargerThanNeighbours
    {
        static void Main()
        {
            int arrSize = int.Parse(Console.ReadLine());
            int[] arra = new int[arrSize];
            string input = Console.ReadLine();
            arra = Array.ConvertAll(input.Split(' '), int.Parse);
            Console.WriteLine(FirstLarger(arra));
        }
        static int FirstLarger(int[] arr)
        {
            int index = -1;
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i - 1] < arr[i] && arr[i] > arr[i + 1])
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
    }
}
