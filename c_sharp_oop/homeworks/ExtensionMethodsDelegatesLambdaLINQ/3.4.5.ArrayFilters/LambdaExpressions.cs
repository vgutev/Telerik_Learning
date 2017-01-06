using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4._5.ArrayFilters
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
    }
}
