using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        private float MoneyPerHour(float weekSalary, int workHoursPerDay)
        {
            float moneyPerHour;
            moneyPerHour = weekSalary / (workHoursPerDay * 5);
            return moneyPerHour;
        }
    }
}
