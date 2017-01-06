using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsDelegatesLambdaLINQ
{
    class StartUp
    {
        static void Main()
        {
            //problem 1. substring extension method test
            StringBuilder strBuild = new StringBuilder();
            strBuild.Append("banan");
            strBuild.Append(" makaron");
            strBuild.Append(" tikva");
            Console.WriteLine(strBuild.Substring(6));
            //problem 2. IEnumerable extensions test
            var test = new List<int> { 18, 22, 13, 1, 5, 6, 21 };
            Console.WriteLine(test.Sum1());
            Console.WriteLine(test.Product1());
            Console.WriteLine(test.Average1());
            Console.WriteLine(test.Min1());
            Console.WriteLine(test.Max1());
            //test LINQ
            Student[] students = new Student[3];
            students[0] = new Student("Ivan", "Kolev", 21);
            students[1] = new Student("Ivan", "Antonov", 40);
            students[2] = new Student("Lubo", "Ganev", 23);
            LINQ.FirstBeforeLast(students);
            LINQ.AgeRange(students);
            //test  lamba expressions
            LambdaExpressions.OrderFirstLastName(students);
            LINQ.OrderFLName(students);
            LambdaExpressions.DivisibleBy7and3(test.ToArray());
            LINQ.DivisibleBy7and3(test.ToArray());
            //Problem 9. Student groups
            List<Student> studentList = new List<Student>();
            List<int> marks1 = new List<int>();
            marks1.Add(2);
            marks1.Add(3);
            marks1.Add(4);
            marks1.Add(5);
            marks1.Add(6);
            studentList[0] = new Student("Mincho", "Praznikov", 60, 100233, "020899666999", "mincho@abv.bg", marks1, 2);
            List<int> marks2 = new List<int>();
            marks1.Add(3);
            marks1.Add(3);
            marks1.Add(4);
            marks1.Add(5);
            marks1.Add(6);
            studentList[0] = new Student("Stefan", "Marianov", 33, 100234, "0899665999", "stefo@abv.bg", marks2, 2);
            List<int> marks3 = new List<int>();
            marks1.Add(6);
            marks1.Add(6);
            marks1.Add(6);
            marks1.Add(6);
            marks1.Add(6);
            studentList[0] = new Student("Otlichnio", "Shestikarov", 23, 100235, "020899665994", "zubar@gmail.com", marks3, 5);
            var orderedStudents =
                from student in studentList
                where student.GroupNumber == 2
                select student;
            //Problem 11. Extract students by email
            var mailFilter =
                from student in studentList
                where student.Email.EndsWith("abv.bg")
                select student;
            //Problem 12. Extract students by phone
            var phoneFilter =
                from student in studentList
                where student.Tel.StartsWith("02")
                select student;
        }


    }
}
