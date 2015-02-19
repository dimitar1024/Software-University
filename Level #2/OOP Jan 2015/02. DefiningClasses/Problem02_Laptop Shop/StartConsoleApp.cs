using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem02_Laptop_Shop;

namespace Problem02_Laptop_Shop
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            Laptop HP430 = new Laptop("HP430", 1199.00D);

            Battery battery = new Battery("Li-lon", 7,3000,4.5);
            Laptop HP450 = new Laptop("HP450", "HP", "Intel Core i7", 8, "Intel 3D Full HP", "750 GB", "1366 x 768", battery, 1300);

            Console.WriteLine("\nLaptop");
            Console.WriteLine(new string('-',60));
            Console.WriteLine(HP430.ToString());
            Console.WriteLine(new string('-', 60));
            Console.WriteLine("\nLaptop");
            Console.WriteLine(new string('-', 60));
            Console.WriteLine(HP450.ToString());
            Console.WriteLine(new string('-', 60));
        }
    }
}
