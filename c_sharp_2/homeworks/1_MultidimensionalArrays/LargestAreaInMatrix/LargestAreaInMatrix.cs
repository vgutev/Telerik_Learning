using System;

namespace LargestAreaInMatrix
{
    class LargestAreaInMatrix
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] nM = Array.ConvertAll(sInput, int.Parse);
            int[,] matrix = new int[nM[0], nM[1]];
            bool[,] calculated = new bool[matrix.GetLength(0), matrix.GetLength(1)];
            int areaCount = 0;
            for (int row = 0; row < nM[0]; row++)
            {
                input = Console.ReadLine();
                sInput = input.Split(' ');
                for (int col = 0; col < nM[1]; col++)
                {
                    matrix[row, col] = int.Parse(sInput[col]);
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (!calculated[row, col])
                    {
                        int count = DepthFirstSearch(matrix, row, col, calculated);
                        if (areaCount < count)
                        {
                            areaCount = count;
                        }
                    }

                }
            }
            Console.WriteLine(areaCount);
        }

        static int DepthFirstSearch(int[,] array, int row, int col, bool[,] calc)
        {
            int result = 1;
            calc[row, col] = true;
            if ((row - 1 >= 0) && (array[row - 1, col] == array[row, col]) && !calc[row - 1, col])
            {
                result += DepthFirstSearch(array, row - 1, col, calc);
            }
            if ((row + 1 < array.GetLength(0)) && (array[row + 1, col] == array[row, col]) && !calc[row + 1, col])
            {
                result += DepthFirstSearch(array, row + 1, col, calc);
            }
            if ((col - 1 >= 0) && (array[row, col - 1] == array[row, col]) && !calc[row, col - 1])
            {
                result += DepthFirstSearch(array, row, col - 1, calc);
            }
            if ((col + 1 < array.GetLength(1)) && (array[row, col + 1] == array[row, col]) && !calc[row, col + 1])
            {
                result += DepthFirstSearch(array, row, col + 1, calc);
            }
            return result;
        }
    }
}
