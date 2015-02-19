namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    public class SalesEmployee : RegularEmployee
    {
        List<Sale> sales = new List<Sale>();

        public void AddSale(Sale sale)
        {
            sales.Add(sale);
        }

        public void RemoveSale(Sale sale)
        {
            sales.Remove(sale);
        }

        public SalesEmployee(string firstName, string lastName, int id, decimal salary, Employee.Department department)
            : base(firstName, lastName, id, salary, department)
        {

        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} ID: {2}", this.FirstName, this.LastName, this.ID);
        }
    }
}
