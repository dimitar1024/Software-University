using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_PCCatalog
{
    class Computer
    {
        //props
        private string name;
        private decimal price;
        public List<Component> components;

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
        public decimal Price
        {
            get { return price; }
        }

        // constructors
        public Computer(string name, List<Component> comp)
        {
            this.Name = name;
            this.components = comp.ToList();
        }


        //methods
        
        private decimal totalPrice() 
        {
            
            decimal res = 0.0m;
            foreach (var item in components)
            {
                res += item.Price;
            }
            return res;
        }

        private string componentsToString() 
        {
            List<Component> comp = components.OrderBy(o => o.Price).ToList();
            string result = "";
            foreach (var item in comp)
	        {
		        if (item.Details == null)
	            {
		            result += "Name: " + item.Name + " Price: " + item.Price + " BGN\n";
	            }
                else
	            {
                    result += "Name: " + item.Name + " Details: " + item.Details + " Price: " + item.Price + " BGN\n";
	            }   
	        }
            return result;
        }
        public override string ToString()
        {
            return "Computer Name: " + this.Name + "\n\n" + componentsToString() + "\nTotal Price " + totalPrice() + " BGN";
        }
        
    }
}
