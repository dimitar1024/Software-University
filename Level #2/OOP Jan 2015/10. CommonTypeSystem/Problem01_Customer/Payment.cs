using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Customer
{
    public class Payment
    {
        private string productName;
        private decimal price;

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }
        public string ProductName
        {
            get { return productName ; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Product name is Empty! ");
                    }
                    else
                    {
                        this.productName= value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
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
                        throw new ArgumentOutOfRangeException("Price is not negative number");
                    }
                    else
                    {
                        this.price = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        
    }
}
