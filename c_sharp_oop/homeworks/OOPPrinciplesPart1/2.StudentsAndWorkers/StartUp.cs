using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    class StartUp
    {
        static void Main()
        {
            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student(3, "Ivan", "Petrov"));
            studentsList.Add(new Student(3, "Pesho", "Minchev"));
            studentsList.Add(new Student(4, "Garibaldi", "Rombev"));
            studentsList.Add(new Student(9, "Sracimir", "Krumov"));
            studentsList.Add(new Student(1, "Strahil", "Jelyazkov"));
            studentsList.Add(new Student(3, "Sava", "Krumov"));
            studentsList.Add(new Student(3, "Genadi", "Darmadanov"));
            studentsList.Add(new Student(4, "Asen", "Karatonchev"));
            studentsList.Add(new Student(9, "Kalin", "Ibrikchiev"));
            studentsList.Add(new Student(1, "John", "Dimitrichkov"));

        }
    }
}
