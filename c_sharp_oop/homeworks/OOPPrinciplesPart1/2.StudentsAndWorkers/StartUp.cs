using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.StudentsAndWorkers
{
    class StartUp
    {
        static void Main()
        {
            //Initialize a list of 10 students and sort them by grade in ascending order.
            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student(3, "Ivan", "Petrov"));
            studentsList.Add(new Student(3, "Pesho", "Minchev"));
            studentsList.Add(new Student(4, "Garibaldi", "Rombev"));
            studentsList.Add(new Student(9, "Toni", "Krumov"));
            studentsList.Add(new Student(1, "Strahil", "Jelyazkov"));
            studentsList.Add(new Student(3, "Sava", "Krumov"));
            studentsList.Add(new Student(3, "Genadi", "Darmadanov"));
            studentsList.Add(new Student(4, "Asen", "Karatonchev"));
            studentsList.Add(new Student(9, "Stan", "Ibrikchiev"));
            studentsList.Add(new Student(1, "John", "Dimitrichkov"));
            var orderedStudentsList =
                from student in studentsList
                orderby student.Grade ascending
                select student;
            Console.WriteLine("List of students ordered by grade in ascending order:");
            foreach (var student in orderedStudentsList)
            {
                Console.WriteLine("Grade: {0} Name: {1} {2}", student.Grade, student.FirstName, student.LastName);
            }
            //Initialize a list of 10 workers and sort them by money per hour in descending order.
            List<Worker> workersList = new List<Worker>();
            workersList.Add(new Worker(200, 8, "Stefan", "Kuzmanov"));
            workersList.Add(new Worker(1000, 8, "Artem", "Artemov"));
            workersList.Add(new Worker(300, 6, "Ahil", "Mirmidonski"));
            workersList.Add(new Worker(287, 8, "Stefan", "Makedonski"));
            workersList.Add(new Worker(653, 4, "Yanko", "Tarpanjiev"));
            workersList.Add(new Worker(199, 10, "Eleonora", "Kuleva"));
            workersList.Add(new Worker(80, 4, "Mirka", "Asenova"));
            workersList.Add(new Worker(5000, 12, "Toni", "Stoev"));
            workersList.Add(new Worker(223, 8, "Alefteya", "Kirova"));
            workersList.Add(new Worker(53, 8, "Stan", "Kolev"));
            var orderedWorkersList =
                from worker in workersList
                orderby worker.MoneyPerHour() descending
                select worker;
            Console.WriteLine("\nList of workers ordered by money per hour in descending order:");
            foreach (var worker in orderedWorkersList)
            {
                Console.WriteLine("Money per hour: {0:f2} \tName: {1} {2}", worker.MoneyPerHour(), worker.FirstName, worker.LastName);
            }
            //Merge the lists and sort them by first name and last name.
            var mergedList1 =
                from student in studentsList
                select new { FirstName = student.FirstName, LastName = student.LastName };
            var mergedList2 =
                from worker in workersList
                select new { FirstName = worker.FirstName, LastName = worker.LastName };
            var mergedList3 = mergedList1.Concat(mergedList2);
            var humanList =
                from human in mergedList3
                orderby human.FirstName + human.LastName
                select human;
            Console.WriteLine("\nMerged lists of students and workers sorted by names:");
            foreach (var human in humanList)
            {
                Console.WriteLine("First name: {0} \tLast name: {1}", human.FirstName, human.LastName);
            }


        }
    }
}
