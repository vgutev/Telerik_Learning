using System.Collections.Generic;

namespace _1.School_classes
{
    class Teacher : People
    {
        private List<Discipline> teachingDisciplines = new List<Discipline>();

        public List<Discipline> TeachingDisciplines
        {
            get
            {
                return this.teachingDisciplines;
            }
            set
            {
                this.teachingDisciplines = value;
            }
        }

        public Teacher(string name, List<Discipline> teachingDisciplines, string comments = null) : base(name, comments)
        {
            this.TeachingDisciplines = teachingDisciplines;
        }
    }
}
