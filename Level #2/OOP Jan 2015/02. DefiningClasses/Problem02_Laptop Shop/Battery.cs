using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Laptop_Shop
{
    class Battery
    {
        private int cells;
        private int capacity;
        private double live;
        private string type;

        public int Capacity
        {
            get { return capacity; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Battery capacity have not negative number");
                    }
                    else
                    {
                        capacity = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        
        public int Cells
        {
            get { return cells; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Battery cells have not negative number");
                    }
                    else
                    {
                        cells = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public double Live
        {
            get { return live; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Battery cells have not negative number");
                    }
                    else
                    {
                        live = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string Type
        {
            get { return type; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Battery type have not empty");
                    }
                    else
                    {
                        type = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Battery()
        {

        }
        public Battery(string type, int cells, int capacity, double live)
        {
            this.type = type;
            this.Cells = cells;
            this.Capacity = capacity;
            this.Live = live;
        }
        
    }
}
