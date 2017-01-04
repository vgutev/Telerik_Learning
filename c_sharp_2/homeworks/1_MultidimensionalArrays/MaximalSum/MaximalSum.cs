using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] nM = Array.ConvertAll(sInput, int.Parse);
            int[,] matrix = new int[nM[0], nM[1]];
            int maxSum = -10000;
            int tempSum = 0;
            for (int row = 0; row < nM[0]; row++)
            {
                input = Console.ReadLine();
                sInput = input.Split(' ');
                for (int col = 0; col < nM[1]; col++)
                {
                    matrix[row, col] = int.Parse(sInput[col]);
                }
            }

            for (int row = 0; row < nM[0] - 2; row++)
            { 
                for (int col = 0; col < nM[1] - 2; col++)
                {
                    tempSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] 
                              + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                              + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (tempSum > maxSum)
                        maxSum = tempSum;
                }
            }
            Console.WriteLine(maxSum);
        }
    }
}
