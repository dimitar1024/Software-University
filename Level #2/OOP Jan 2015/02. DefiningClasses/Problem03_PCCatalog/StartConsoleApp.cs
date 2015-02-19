using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_PCCatalog
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<Component> components = new List<Component>();

            Component RAM = new Component("RAM","Kingston 16 GB 2x8 GB", 120);
            components.Add(RAM);
            Component HDD = new Component("HDD","ADATA 1 TB", 350);
            components.Add(HDD);
            Component Motherboard = new Component("Motherboard","Acer", 500);
            components.Add(Motherboard);
            Component Processor = new Component("Processor","Intel Core i7", 400);
            components.Add(Processor);
            Component GraphicsCard = new Component("Graphics card","Full HD",540);
            components.Add(GraphicsCard);

            Computer Acer = new Computer("Acer SoftUniTest", components);

            Console.WriteLine(Acer.ToString());
        }
    }
}
