using System;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? a = null;
            int? b = null;
            Console.WriteLine("{0} {1}", a, b);
            a = 5;
            b = 10;
            Console.WriteLine("{0} {1}", a, b);
        }
    }
}
