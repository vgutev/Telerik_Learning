namespace _2.StudentsAndWorkers 
{
    class Worker : Human
    {
        private float weekSalary;
        private int workHoursPerDay;

        public float WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            private set
            {
                if (value > 0)
                {
                    this.weekSalary = value;
                }
            }
        }
        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            private set
            {
                if (value > 0 && 24 >= value)
                {
                    this.workHoursPerDay = value;
                }
            }
        }

        public Worker(float weekSalary, int workHoursPerDay, string firstName, string lastName) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public float MoneyPerHour()
        {
            float moneyPerHour;
            moneyPerHour = this.weekSalary / (this.workHoursPerDay * 5);
            return moneyPerHour;
        }
    }
}
