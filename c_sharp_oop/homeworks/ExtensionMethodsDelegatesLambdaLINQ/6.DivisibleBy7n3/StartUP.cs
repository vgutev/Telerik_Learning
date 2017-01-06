using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DivisibleBy7n3
{
    class StartUp
    {
        static void Main()
        {
            //Problem 6. Divisible by 7 and 3 test
            var test = new List<int> { 18, 42, 13, 1, 5, 6, 21 };
            LambdaExpressions.DivisibleBy7and3(test.ToArray());
            LINQ.DivisibleBy7and3(test.ToArray());
        }
    }
}
