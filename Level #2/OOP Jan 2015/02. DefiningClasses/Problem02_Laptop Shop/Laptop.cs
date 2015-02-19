using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_Laptop_Shop
{
    class Laptop
    {
        private string model;
        private string manufacturer;
        private string processor;
        private int ram;
        private string graphicsCard;
        private string hdd;
        private string screen;
        private double price;
        Battery battery = new Battery();

        public string Model
        {
            get { return model; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Model is empty");
                    }
                    else
                    {
                        model = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string Manufacturer
        {
            get { return manufacturer; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Manufacturer is empty");
                    }
                    else
                    {
                        manufacturer = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string Processor
        {
            get { return processor; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Processor is empty");
                    }
                    else
                    {
                        processor = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public int Ram
        {
            get { return ram; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("RAM is not negative number");
                    }
                    else
                    {
                        ram = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string GraphicsCard
        {
            get { return graphicsCard; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Graphics card is empty");
                    }
                    else
                    {
                        graphicsCard = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string Hdd
        {
            get { return hdd; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("HDD is empty");
                    }
                    else
                    {
                        hdd = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public string Screen
        {
            get { return screen; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Screen is empty");
                    }
                    else
                    {
                        screen = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public double Price
        {
            get { return price; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Price is not negative number");
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

        public Laptop(string model, double price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, string manufacturer, string processor, int ram,string graphicsCard, string hdd, string screen, Battery battery, double price) 
            : this(model,price)
        {
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Ram = ram;
            this.GraphicsCard = graphicsCard;
            this.Hdd = hdd;
            this.Screen = screen;
            this.battery = battery;
        }

        public override string ToString()
        {
            if (manufacturer == null) // manufacturer is property from second constructor.
            // I check only one of the elements of the second constructor, because the others are mandatory
            {
                return String.Format("|model               | {0}\n|price               | {1:0.00} lv.\n",
                    this.Model,this.Price);
            
            }
            else
            {
                return String.Format("|model               | {0}\n|manufacturer        | {1}\n|processor           | {2}\n|RAM                 | {3} GB\n|graphics card       | {4}\n|HDD                 | {5}\n|screen              | {6}\n|battery             | {7},{8}-cells,{9} mAh\n|battery life        | {10} hours\n|price               | {11:0.00} lv.\n",
                    this.Model, this.Manufacturer, this.Processor, this.Ram, this.GraphicsCard, this.Hdd, this.Screen, this.battery.Type, this.battery.Cells, this.battery.Capacity, this.battery.Live, this.Price);
            }
        }
    }
}
