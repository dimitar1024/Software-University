namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    class Developer : RegularEmployee
    {
        List<Project> projects = new List<Project>();

        public void AddSale(Project project)
        {
            projects.Add(project);
        }

        public void RemoveSale(Project project)
        {
            projects.Remove(project);
        }

        public Developer(string firstName, string lastName, int id, decimal salary, Employee.Department department)
            : base(firstName, lastName, id, salary, department)
        {

        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} ID: {2}",this.FirstName,this.LastName,this.ID);
        }
    }
}
