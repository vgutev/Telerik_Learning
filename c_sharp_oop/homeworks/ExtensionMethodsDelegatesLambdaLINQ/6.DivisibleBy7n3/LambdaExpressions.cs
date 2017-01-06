using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DivisibleBy7n3
{
    class LambdaExpressions
    {
        public static void DivisibleBy7and3(int[] array)
        {
            var result = array.Where(x => x % 3 == 0 && x % 7 == 0).ToList();
            Console.WriteLine("Prints from given array of integers all numbers that are divisible by 7 and 3 using lambda expressions:");
            Console.WriteLine(string.Join(",", result));
        }
    }
}
