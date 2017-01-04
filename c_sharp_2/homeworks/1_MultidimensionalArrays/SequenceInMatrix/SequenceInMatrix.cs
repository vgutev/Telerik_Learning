using System;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string[] sInput = input.Split(' ');
            int[] nM = Array.ConvertAll(sInput, int.Parse);
            string[,] matrix = new string[nM[0], nM[1]];
            int seqCount = 1;
            int tempSeqCount = 0;

            for (int row = 0; row < nM[0]; row++)
            {
                input = Console.ReadLine();
                sInput = input.Split(' ');
                for (int col = 0; col < nM[1]; col++)
                {
                    matrix[row, col] = sInput[col];
                }
            }

            // check row sequence
            tempSeqCount = 1;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    for (int i = col; i < matrix.GetLength(1) - 1; i++)
                    {
                        if (matrix[row, i] == matrix[row, i + 1]) tempSeqCount++;
                        else break;
                    }
                    if (tempSeqCount > seqCount)
                    {
                        seqCount = tempSeqCount;
                    }
                    tempSeqCount = 1;
                }
            }

            // check col squence
            tempSeqCount = 1; ;
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    for (int i = row; i < matrix.GetLength(0) - 1; i++)
                    {
                        if (matrix[i, col] == matrix[i + 1, col]) tempSeqCount++;
                        else break;
                    }
                    if (tempSeqCount > seqCount)
                    {
                        seqCount = tempSeqCount;
                    }
                    tempSeqCount = 1;
                }
            }

            // check right diagonals sequence
            tempSeqCount = 1;
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                tempSeqCount = 1;
                int tempRow = row;
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        tempSeqCount++;
                        row++;

                        if (tempSeqCount > seqCount)
                        {
                            seqCount = tempSeqCount;
                        }

                        if ((row + 1 == matrix.GetLength(0)) || (col + 1 == matrix.GetLength(1)))
                        {
                            row = tempRow;
                            tempSeqCount = 1;
                        }
                    }
                    else
                    {
                        col = col - tempSeqCount + 1;
                        tempSeqCount = 1;
                        row = tempRow;
                    }
                }
            }
            // check left diagonals sequence
            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                tempSeqCount = 1;
                int tempRow = row;
                for (int col = matrix.GetLength(1) - 1; col > 0 && row + 1 < matrix.GetLength(0); col--)
                {
                    if (matrix[row, col] == matrix[row + 1, col - 1])
                    {
                        tempRow++;
                        row++;

                        if (tempSeqCount > seqCount)
                        {
                            seqCount = tempSeqCount;
                        }

                        if ((row + 1 == matrix.GetLength(0)) || (col - 1 == 0))
                        {
                            row = tempRow;
                            tempSeqCount = 1;
                        }
                    }
                    else
                    {
                        col = col + tempSeqCount - 1;
                        tempSeqCount = 1;
                        row = tempRow;
                    }
                }
            }
            Console.WriteLine(seqCount);
        }
    }
}
