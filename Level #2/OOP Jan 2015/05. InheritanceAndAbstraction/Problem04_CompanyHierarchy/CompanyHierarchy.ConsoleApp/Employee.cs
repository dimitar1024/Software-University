namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    public class Employee : Person, IEmployee
    {
        private decimal salary;
        private Department department;

        public enum Department
        {
            Production,
            Accounting,
            Sales,
            Marketing
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Salary is not negative number");
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Department Departament
        {
            get { return department; }
            set { department = value; }
        }
        public Employee(string firstName, string lastName, int id, decimal salary, Department department)
            : base(firstName, lastName, id)
        {
            this.Salary = salary;
            this.Departament = department;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} ID: {2} Department: {3}", this.FirstName,this.LastName,this.ID,this.Departament);
        }
    }
}
