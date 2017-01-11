using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.School_classes
{
    class School
    {
        private List<SchoolClass> classes = new List<SchoolClass>();

        public List<SchoolClass> Classes
        {
            get
            {
                return this.classes;
            }
            private set
            {
                this.classes = value;
            }
        }
    }
}
