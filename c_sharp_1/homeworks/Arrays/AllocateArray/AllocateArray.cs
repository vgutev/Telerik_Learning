using System;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nArray = new int[n];
            for (int i = 0; i < nArray.Length; i++)
            {
                nArray[i] = i * 5;
                Console.WriteLine(nArray[i]); 
            }
        }
    }
}
