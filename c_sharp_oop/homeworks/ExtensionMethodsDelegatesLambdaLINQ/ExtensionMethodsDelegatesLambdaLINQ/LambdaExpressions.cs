using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    class LambdaExpressions
    {
        public static void OrderFirstLastName(Student[] students)
        {
            Console.WriteLine("\nStudents ordered by first and last name using lambda expressions:");
            var ordered = students.OrderBy(s => s.FirstName).ThenBy(s => s.LastName);
            foreach (var student in ordered)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
        public static void DivisibleBy7and3(int[] array)
        {
            var result = array.Where(x => x % 3 == 0 && x % 7 == 0).ToList();
            Console.WriteLine(string.Join(",", result));
        }

    }
}
