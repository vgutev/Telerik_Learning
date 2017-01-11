using System;

namespace _1.School_classes
{
    class Discipline
    {
        private string name;
        private int numberOfLectures;
        private int numberOfExcersise;
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
                    throw new ArgumentException("Invalid name entered!");
                }
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExcersise
        {
            get
            {
                return this.numberOfExcersise;
            }
            private set
            {
                this.numberOfExcersise = value;
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

        public Discipline(string name, int numberOfLectures, int numberOfExcersise, string comments = null)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExcersise = numberOfExcersise;
            this.Comments = comments;
        }
    }
}
