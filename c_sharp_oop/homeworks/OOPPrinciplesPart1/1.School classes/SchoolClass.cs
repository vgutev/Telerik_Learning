using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School_classes
{
    class SchoolClass
    {
        private List<Teacher> teachers = new List<Teacher>();
        private List<Student> students = new List<Student>();
        private string textIdentifier;
        private string comments;

        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set
            {
                this.teachers = value;
            }
        }
        public List<Student> Students
        {
            get
            {
                return this.students;
            }
            private set
            {
                this.students = value;
            }
        }
        public string TextIdentifier
        {
            get
            {
                return this.textIdentifier;
            }
            private set
            {
                this.textIdentifier = value;
            }
        }
        public string Comments
        { get
            {
                return this.comments;
            }
            private set
            {
                this.comments = value;

            }
        }

        public SchoolClass(List<Teacher> teachers, List<Student> students, string textIdentifier, string comments = null)
        {
            this.Teachers = teachers;
            this.Students = students;
            this.TextIdentifier = textIdentifier;
            this.Comments = comments;
        }
    }
}
