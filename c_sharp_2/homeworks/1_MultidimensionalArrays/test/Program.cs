//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets
//of several neighbor elements located on the same line, column or diagonal. Write a program that
//finds the longest sequence of equal strings in the matrix.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LineColumnOrDagonal
{
    static void Main()
    {
        string[,] array = new string[,] {
            {"ninja",       "ninja",        "izobilie",     "kusmet",       "uporitost"},
            {"priqtelstwo", "ninja",        "liubov",       "uporitost",    "kusmet"},
            {"smelost",     "sila",         "ninja",        "kusmet",       "iskrenost"},
            {"uporitost",   "uporitost",    "spokoistvie",  "ninja",        "spokoistvie"},
        };
        int bestCounter = 0;
        string bestStrText = "";

        Lines(array, out bestCounter, out bestStrText);
        Columns(array, ref bestCounter, ref bestStrText);
        DiagonalsDownRight(array, ref bestCounter, ref bestStrText);
        MoveDagonalsDownLeft(array, ref bestCounter, ref bestStrText);
        Console.WriteLine("Longest sequence of equal strings in the matrix: " + bestStrText);
        Console.WriteLine(bestCounter + " times");
        //chek diagonals up-right

    }
    static void Lines(string[,] arr, out int bestCount, out string bestText)
    {
        //check lines
        int count = 1;
        bestCount = 1;
        bestText = "";
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1) - 1; col++)
            {
                for (int i = col; i < arr.GetLength(1) - 1; i++)
                {
                    if (arr[row, i] == arr[row, i + 1]) count++;
                    else break;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestText = arr[row, col] + "\nlines";
                }
                count = 1;
            }
        }
    }

    static void Columns(string[,] arr, ref int bestCount, ref string bestText)
    {
        //check columns
        int count = 1; ;
        for (int col = 0; col < arr.GetLength(1); col++)
        {
            for (int row = 0; row < arr.GetLength(0) - 1; row++)
            {
                for (int i = row; i < arr.GetLength(0) - 1; i++)
                {
                    if (arr[i, col] == arr[i + 1, col]) count++;
                    else break;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    bestText = arr[row, col] + "\ncolumns";
                }
                count = 1;
            }
        }
    }
    static void DiagonalsDownRight(string[,] arr, ref int bestCount, ref string bestText)
    {
        //ckeck diagonals down-righ
        int count = 1;
        for (int rows = 0; rows < arr.GetLength(0) - 2; rows++)  //moves diagonal to left and down
        {
            for (int row = rows, col = 0; row < arr.GetLength(0) - 1; row++, col++)
            {
                if ((row == arr.GetLength(0) - 1) || (col == arr.GetLength(1) - 1)) break;
                if (arr[row, col] == arr[row + 1, col + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestText = arr[row, col] + "\ndiagonals down-right";
                    }
                }
                else count = 1;
            }
            count = 1;
        }
        for (int cols = 1; cols < arr.GetLength(0) - 2; cols++)  //moves diagonal to right
        {
            for (int row = 0, col = cols; row < arr.GetLength(0) - 1; row++, col++)
            {
                if ((row == arr.GetLength(0) - 1) || (col == arr.GetLength(1) - 1)) break;
                if (arr[row, col] == arr[row + 1, col + 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestText = arr[row, col] + "\ndiagonals down-right";
                    }
                }
                else count = 1;
            }
            count = 1;
        }
    }
    static void MoveDagonalsDownLeft(string[,] arr, ref int bestCount, ref string bestText)
    {
        //ckeck diagonals down-left
        int count = 1;
        for (int rows = 0; rows < arr.GetLength(0) - 1; rows++)  //moves diagonal to left and down
        {
            for (int row = rows, col = arr.GetLength(1) - 1; row < arr.GetLength(0) - 1; row++, col--)
            {
                if ((row == arr.GetLength(0) - 1) || (col == 0)) break;
                if (arr[row, col] == arr[row + 1, col - 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestText = arr[row, col] + "\ndiagonals down-left";
                    }
                }
                else count = 1;
            }
            count = 1;
        }
        for (int cols = arr.GetLength(1) - 2; cols >= 1; cols--)  //moves diagonal to right
        {
            for (int row = 0, col = cols; row < arr.GetLength(0) - 1; row++, col--)
            {
                if ((row == arr.GetLength(0) - 1) || (col == 0)) break;
                if (arr[row, col] == arr[row + 1, col - 1])
                {
                    count++;
                    if (count > bestCount)
                    {
                        bestCount = count;
                        bestText = arr[row, col] + "\ndiagonals down-left";
                    }
                }
                else count = 1;
            }
            count = 1;
        }
    }
}


//// check right diagonals sequence
//tempSeqCount = 1;
//for (int rows = 0; rows < matrix.GetLength(0) - 2; rows++) 
//{
//    for (int row = rows, col = 0; row < matrix.GetLength(0) - 1; row++, col++)
//    {
//        if ((row == matrix.GetLength(0) - 1) || (col == matrix.GetLength(1) - 1)) break;
//        if (matrix[row, col] == matrix[row + 1, col + 1])
//        {
//            tempSeqCount++;
//            if (tempSeqCount > seqCount)
//                seqCount = tempSeqCount;
//        }
//        else tempSeqCount = 1;
//    }
//    tempSeqCount = 1;
//}
//for (int cols = 1; cols < matrix.GetLength(0) - 2; cols++)  
//{
//    for (int row = 0, col = cols; row < matrix.GetLength(0) - 1; row++, col++)
//    {
//        if ((row == matrix.GetLength(0) - 1) || (col == matrix.GetLength(1) - 1)) break;
//        if (matrix[row, col] == matrix[row + 1, col + 1])
//        {
//            tempSeqCount++;
//            if (tempSeqCount > seqCount)
//                seqCount = tempSeqCount;
//        }
//        else tempSeqCount = 1;
//    }
//    tempSeqCount = 1;
//}

//// check left diagonals sequence
//tempSeqCount = 1;
//for (int rows = 0; rows < matrix.GetLength(0) - 1; rows++)  
//{
//    for (int row = rows, col = matrix.GetLength(1) - 1; row < matrix.GetLength(0) - 1; row++, col--)
//    {
//        if ((row == matrix.GetLength(0) - 1) || (col == 0)) break;
//        if (matrix[row, col] == matrix[row + 1, col - 1])
//        {
//            tempSeqCount++;
//            if (tempSeqCount > seqCount)
//                seqCount = tempSeqCount;
//        }
//        else tempSeqCount = 1;
//    }
//    tempSeqCount = 1;
//}
//for (int cols = matrix.GetLength(1) - 2; cols >= 1; cols--) 
//{
//    for (int row = 0, col = cols; row < matrix.GetLength(0) - 1; row++, col--)
//    {
//        if ((row == matrix.GetLength(0) - 1) || (col == 0)) break;
//        if (matrix[row, col] == matrix[row + 1, col - 1])
//        {
//            tempSeqCount++;
//            if (tempSeqCount > seqCount)
//                seqCount = tempSeqCount ;
//        }
//        else tempSeqCount = 1;
//    }
//    tempSeqCount = 1;
//}