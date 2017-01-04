using System;

namespace AddingPolynomials
{
    class AddingPolynomials
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] pol1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] pol2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            int[] result = new int[pol1.Length];
            result = AddPolynom(pol1, pol2);
            for (int i = 0; i < pol1.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }
            Console.WriteLine();
        }
        static int[] AddPolynom(int[] pol1, int[] pol2)
        {
            int[] result = new int[pol1.Length];
            for (int i = 0; i < pol1.Length; i++)
            {
                result[i] = pol1[i] + pol2[i];
            }
            return result;
        }
    }
}
