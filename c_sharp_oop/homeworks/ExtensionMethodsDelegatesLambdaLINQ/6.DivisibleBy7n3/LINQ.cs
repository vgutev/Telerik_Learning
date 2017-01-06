using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.DivisibleBy7n3
{
    class LINQ
    {
        public static void DivisibleBy7and3(int[] array)
        {
            var result =
                from number in array
                where number % 3 == 0 && number % 7 == 0
                select number;
            Console.WriteLine("Prints from given array of integers all numbers that are divisible by 7 and 3 using LINQ:");
            Console.WriteLine(string.Join(",", result));
        }
    }
}
