namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    public class Customer : Person, ICustomer
    {
        private List<Sale> allSales = new List<Sale>();

        public void AddSale(Sale sale)
        {
            allSales.Add(sale);
        }

        public void RemoveSale(Sale sale)
        {
            allSales.Remove(sale);
        }
        public Customer(string firstName, string lastName, int id)
            : base(firstName, lastName, id)
        {

        }

        public void TotalPrice()
        {
            throw new NotImplementedException("TODO this list not foreach. I dont know");
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} ID: {2}", this.FirstName, this.LastName, this.ID);
        }
    }
}
