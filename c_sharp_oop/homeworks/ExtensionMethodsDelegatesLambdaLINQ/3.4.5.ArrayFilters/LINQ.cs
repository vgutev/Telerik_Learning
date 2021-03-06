﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4._5.ArrayFilters
{
    class LINQ
    {
        public static void FirstBeforeLast(Student[] students)
        {
            var firstBeforeLast =
                            from student in students
                            where student.FirstName.CompareTo(student.LastName) > 0
                            select student;
            foreach (var student in firstBeforeLast)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
        public static void AgeRange(Student[] students)
        {
            var youngStudents =
                from student in students
                where 18 <= student.Age && student.Age <= 24
                select new { student.FirstName, student.LastName };
            foreach (var student in youngStudents)
            {
                Console.WriteLine(student);
            }
        }
        public static void OrderFLName(Student[] students)
        {
            Console.WriteLine("\nStudents ordered by first and last name using LINQ:");
            var firstLast =
                            from student in students
                            orderby student.FirstName + student.LastName
                            select student;
            foreach (var student in firstLast)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
        }
    }
}
