using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_HumanStudentAndWorker
{
    class Worker : Human
    {
        const int WorkDays = 5;
        private decimal weekSalary;
        private int workHoursPerDay;

        public decimal WeekSalary
        {
            get { return weekSalary; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Please enter positive number");
                    }
                    else
                    {
                        weekSalary = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Please enter positive number");
                    }
                    else
                    {
                        workHoursPerDay = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public decimal MoneyPerHour() 
        {
            return this.WeekSalary / (this.WorkHoursPerDay * WorkDays);
        }

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName,lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} week salary: {2} work hours per day: {3}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
