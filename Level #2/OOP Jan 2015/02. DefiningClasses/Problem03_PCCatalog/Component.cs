using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_PCCatalog
{
    class Component
    {
        //props
        private string name;
        private string details;
        private decimal price;
        public string Name
        {
            get { return name; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Name is empty");
                    }
                    else
                    {
                        name = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string Details
        {
            get { return details; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Name is empty");
                    }
                    else
                    {
                        details = value;
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
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Price can not negative number");
                    }
                    else
                    {
                        price = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


        //constructors
        public Component(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public Component(string name, string details, decimal price)
            : this(name, price)
        {
            this.Details = details;
        }

        //methods
        public override string ToString()
        {
            if (Details == null)
            {
                return " Name: " + this.Name + " Price: " + this.Price;
    
            }
            else
            {
            return " Name: " + this.Name + " Price: " + this.Price + " Details: " + this.Details;
            }
        }

    }
}
