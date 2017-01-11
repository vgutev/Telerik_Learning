using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School_classes
{
    class Student : People
    {
        private int classNumber;

        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }
            private set
            {
                if (0 >= value || value > 40)
                {
                    throw new ArgumentException("Invalid class number entered!");
                }
                else
                {
                    this.classNumber = value;
                }
            }
        }

        public Student(string name, int classNumber, string comments = null) : base(name, comments)
        {
            this.ClassNumber = classNumber;
        }
    }
}
