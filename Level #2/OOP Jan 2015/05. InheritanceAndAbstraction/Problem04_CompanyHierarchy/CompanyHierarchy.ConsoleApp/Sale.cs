namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    public class Sale : ISale
    {
        private string productName;
        private DateTime date;
        private decimal price;

        public string ProductName
        {
            get { return productName; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Product name is Empty");
                    }
                    else
                    {
                        productName = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public decimal Price
        {
            get { return price; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Price is not negative");
                    }
                    else
                    {
                        price = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Sale(string productName, DateTime date, decimal price)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("product: {0} date: {1} price: {2}", this.ProductName,this.Date,this.Price);
        }

    }
}
