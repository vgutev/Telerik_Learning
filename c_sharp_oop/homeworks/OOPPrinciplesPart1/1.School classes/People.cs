using System;

namespace _1.School_classes
{
    class People
    {
        private string name;
        private string comments;

        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    this.name = value;
                }
                else
                {
                    throw new ArgumentException("Invalid Name entered!");
                }
            }
        }
        public string Comments
        {
            get
            {
                return this.comments;
            }
            private set
            {
                this.comments = value;
            }
        }

        public People(string name, string comments = null)
        {
            this.Name = name;
            this.Comments = comments;
        }
    }
}
