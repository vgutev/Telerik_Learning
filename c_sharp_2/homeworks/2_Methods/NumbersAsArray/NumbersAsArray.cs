using System;

namespace NumbersAsArray
{
    class NumbersAsArray
    {
        static void Main()
        {
            int[] input = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] result = new int[arr1.Length > arr2.Length ? arr1.Length  + 1 : arr2.Length + 1];
            result = SumArrayNumbers(arr1, arr2);
            for (int i = 0; i < result.Length; i++)
            {
                if (i == result.Length - 1 && result[i] == 0)
                {
                    break;
                }
                Console.Write("{0} ",result[i]);
            }
            Console.WriteLine();
        }

        static int[] SumArrayNumbers(int[] arr1, int[] arr2)
        {
            int shortLength = arr1.Length < arr2.Length ? arr1.Length : arr2.Length;
            int longLength = arr1.Length > arr2.Length ? arr1.Length : arr2.Length;
            int[] result = new int[longLength + 1];
            bool trans = false;
            for (int i = 0; i < shortLength; i++)
            {
                if (trans == false)
                {
                    result[i] = arr1[i] + arr2[i];
                    if (result[i] > 9)
                    {
                        result[i] = result[i] - 10;
                        trans = true;
                    }
                }
                else
                {
                    result[i] = arr1[i] + arr2[i] + 1;
                    if (result[i] > 9)
                    {
                        result[i] = result[i] - 10;
                    }
                    else
                    {
                        trans = false;
                    }
                }
            }
            for (int i = shortLength; i < longLength; i++)
            {
                if (trans == true)
                {
                    result[i] = arr1.Length > arr2.Length ? arr1[i] + 1 : arr2[i] + 1;
                    if (result[i] > 9)
                    {
                        result[i] = result[i] - 10;
                    }
                    else
                    {
                        trans = false;
                    }
                }
                else
                {
                    result[i] = arr1.Length > arr2.Length ? arr1[i] : arr2[i];
                }
            }
            if (trans == true)
            {
                result[longLength] = 1;
            }
            return result;
        }

    }
}
