using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Problem 17. Longest string
            string[] strArr = new string[] { "banan", "kamiontuzu", "barbaron" };
            var max = strArr.OrderByDescending(str => str.Length).ToArray()[0];
            Console.WriteLine(max);
        }
    }
}
