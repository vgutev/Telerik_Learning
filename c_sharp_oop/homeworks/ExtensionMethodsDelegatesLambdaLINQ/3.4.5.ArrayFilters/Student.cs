using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4._5.ArrayFilters
{
    public class Student
    {
        //student properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public string FN { get; private set; }
        public string Tel { get; private set; }
        public string Email { get; private set; }
        public List<int> Marks { get; private set; }
        public int GroupNumber { get; private set; }

        //student constructors
        public Student()
        { }
        public Student(string firstName, string lastName, int age, string fn = "0",
            string tel = null, string email = null, List<int> marks = null, int groupNumber = 0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
        }
    }
}
