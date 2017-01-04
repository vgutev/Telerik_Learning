using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string aString = Console.ReadLine();
            string bString = Console.ReadLine();
            char[] a = new char[aString.Length];
            char[] b = new char[bString.Length];
            a = aString.ToCharArray();
            b = bString.ToCharArray();
            int length = aString.Length;
            if (aString == bString)
            {
                Console.WriteLine("=");
                Environment.Exit(4);
            }
            if (aString.Length >= bString.Length)
            {
                length = bString.Length;
            }
            if (length > 128)
            {
                length = 128;
            }
            for (int i = 0; i < length; i++)
            {
                if (a[i] > b[i])
                {
                    Console.WriteLine(">");
                    Environment.Exit(1);
                }
                else
                if (a[i] < b[i])
                {
                    Console.WriteLine("<");
                    Environment.Exit(2);
                }
            }
            if (a.Length > b.Length)
            {
                Console.WriteLine(">");
            }
            else
            {
                Console.WriteLine("<");
            }
        }
    }
}
