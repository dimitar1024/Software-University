namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    public class Manager : Employee, IManager
    {
        List<Employee> team = new List<Employee>();

        public void AddEmployeeToTeam(Employee employee)
        {
            team.Add(employee);
        }

        public void RemoveEmployeeToTeam(Employee employee)
        {
            team.Remove(employee);
        }
        public Manager(string firstName, string lastName, int id, decimal salary, Employee.Department department)
            : base(firstName, lastName, id, salary, department)
        {

        }
        public string PrintTeam()
        {
            var teamList = new StringBuilder();

            foreach (var employee in team)
            {
                teamList.AppendFormat(employee.ToString() + "\n");
            }

            return teamList.ToString();
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} ID: {2}", this.FirstName, this.LastName, this.ID);
        }
    }
}
