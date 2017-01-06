using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.IEnumerableExtensions
{
    class StartUp
    {
        static void Main()
        {
            //problem 2. IEnumerable extensions test
            var test = new List<int> { 18, 22, 13, 1, 5, 6, 21 };
            Console.WriteLine(test.Sum1());
            Console.WriteLine(test.Product1());
            Console.WriteLine(test.Average1());
            Console.WriteLine(test.Min1());
            Console.WriteLine(test.Max1());
        }
    }
}
