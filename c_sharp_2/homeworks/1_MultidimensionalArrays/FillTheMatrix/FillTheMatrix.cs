using System;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n,n];
            int num = 1;
            int downIndex = 0;
            int rightIndex = 1;
            int upIndex = n;
            int leftIndex = n;
            string direction = "down";
            char type = Convert.ToChar(Console.ReadLine());
            switch (type)
            {
                case 'a':
                    for (int col = 0; col < n; col++)
                    {
                        for (int row = 0; row < n; row++)
                        {
                            matrix[row, col] = num;
                            num++;
                        }
                    }
                    break;
                case 'b':
                    for (int col = 0; col < n; col++)
                    {
                        if (col % 2 ==0)
                        {// for even columns value increases downwards
                            for (int row = 0; row < n; row++)
                            {
                                matrix[row, col] = num;
                                num++;
                            }
                        }
                        else
                        {// for odd columns value increases upwards
                            for (int row = n-1; row >= 0; row--)
                            {
                                matrix[row, col] = num;
                                num++;
                            }
                        }
                        
                    }
                    break;
                case 'c':
                    // fill first half of the diagonals
                    for (int row = n - 1; row > 0; row--)
                    {
                        int tempRow = row;
                        for (int col = 0; col <= n - row - 1; col++)
                        {
                            matrix[tempRow, col] = num;
                            num++;
                            tempRow++;
                        }
                    }
                    // fill central diagonal
                    for (int i = 0; i < n; i++)
                    {
                        matrix[i, i] = num;
                        num++;
                    }
                    // fill second half of diagonals
                    num = n*n;
                    for (int row = 0; row < n; row++)
                    {
                        int tempRow = row;
                        for (int col = n - 1; col >= n - row - 1; col--)
                        {
                            matrix[tempRow, col] = num;
                            num--;
                            tempRow--;
                        }
                    }
                    break;
                case 'd':
                    while (num <= n * n)
                    {
                        switch (direction)
                        {
                            // fill downward direction
                            case "down":
                                for (int row = downIndex; row < n - downIndex; row++)
                                {
                                    int col = downIndex;
                                    matrix[row, col] = num;
                                    num++;
                                }
                                downIndex++;
                                direction = "right";
                                break;
                            // fill riht direction
                            case "right":
                                for (int col = rightIndex; col < n - rightIndex +1; col++)
                                {
                                    int row = n - rightIndex;
                                    matrix[row, col] = num;
                                    num++;
                                }
                                rightIndex++;
                                direction = "up";
                                break;
                            //fil upward direction
                            case "up":
                                for (int row = upIndex - 2; row >= n - upIndex; row--)
                                {
                                    int col = upIndex - 1;
                                    matrix[row, col] = num;
                                    num++;
                                }
                                upIndex--;
                                direction = "left";
                                break;
                            // fill left direction
                            case "left":
                                for (int col = leftIndex - 2; col > n - leftIndex; col--)
                                {
                                    int row = n - leftIndex;
                                    matrix[row, col] = num;
                                    num++;
                                }
                                leftIndex--;
                                direction = "down";
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                default:
                    break;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == n - 1)
                    {
                        Console.WriteLine("{0}", matrix[i, j]);
                    }
                    else
                    {
                        Console.Write("{0} ", matrix[i, j]);
                    }
                }
            }
            
        }
    }
}
