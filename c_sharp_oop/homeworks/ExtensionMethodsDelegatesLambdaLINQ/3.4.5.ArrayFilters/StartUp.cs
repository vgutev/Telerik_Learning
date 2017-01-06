using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4._5.ArrayFilters
{
    class StartUp
    {
        static void Main()
        {
            Student[] students = new Student[3];
            students[0] = new Student("Ivan", "Kolev", 21);
            students[1] = new Student("Ivan", "Antonov", 40);
            students[2] = new Student("Lubo", "Ganev", 23);
            //Problem 3. First before last test
            LINQ.FirstBeforeLast(students);
            //Problem 4. Age range test
            LINQ.AgeRange(students);
            //Problem 5. Order students test
            LambdaExpressions.OrderFirstLastName(students);
            LINQ.OrderFLName(students);
        }
    }
}
