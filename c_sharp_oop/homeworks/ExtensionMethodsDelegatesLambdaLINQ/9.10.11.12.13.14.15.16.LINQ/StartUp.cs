using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3._4._5.ArrayFilters;

namespace _9._10._11._12._13._14._15._16.LINQ
{
    class StartUp
    {
        static void Main()
        {
            List<Student> studentList = new List<Student>();
            List<int> marks1 = new List<int>();
            marks1.Add(2);
            marks1.Add(3);
            marks1.Add(4);
            marks1.Add(5);
            marks1.Add(2);
            studentList.Add(new Student("Mincho", "Praznikov", 60, "100233", "020899666999", "mincho@abv.bg", marks1, 2));
            List<int> marks2 = new List<int>();
            marks1.Add(3);
            marks1.Add(3);
            marks1.Add(4);
            marks1.Add(5);
            marks1.Add(6);
            studentList.Add(new Student("Stefan", "Marianov", 33, "100206", "0899665999", "stefo@abv.bg", marks2, 2));
            List<int> marks3 = new List<int>();
            marks1.Add(6);
            marks1.Add(6);
            marks1.Add(6);
            marks1.Add(6);
            marks1.Add(6);
            studentList.Add(new Student("Otlichnio", "Shestikarov", 23, "100206", "020899665994", "zubar@gmail.com", marks3, 5));
            //Problem 9. Student groups
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
            //Problem 13. Extract students by marks
            var excellentStudents =
               from student in studentList
               where student.Marks.Contains(6)
               select new { FullName = $"{student.FirstName} {student.LastName}", Marks = student.Marks };
            //Problem 15. Extract marks
            var fnMarksFilter =
                from student in studentList
                where student.FN.EndsWith("06")
                select new { FullName = student.FirstName + " " + student.LastName, student.Marks };

        }
    }
}
