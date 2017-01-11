using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.StudentsAndWorkers
{
    class Student : Human
    {
        private int grade;

        public int Grade
        {
            get
            {
                return this.grade;
            }
            private set
            {
                this.grade = value;
            }
        }

        public Student(int grade, string firstName, string lastName) : base(firstName, lastName)
        {
            this.Grade = grade;
        }
    }
}
