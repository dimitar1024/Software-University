namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    public class RegularEmployee : Employee, IRegularEmployee
    {
        public RegularEmployee(string firstName, string lastName, int id, decimal salary, Employee.Department department)
            : base(firstName, lastName, id, salary, department)
        {

        }
    }
}
