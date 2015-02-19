using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Rectangles
{
    class Rectangles
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 4.	Rectangles");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an expression that calculates rectangle’s perimeter and area by given width and height. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter \"a\" on your rectangles: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\" on your rectangles: ");
            double b = double.Parse(Console.ReadLine());
            double s = a * b;
            double p = (a + b) * 2;
            Console.WriteLine("Area\'s on your rectangles is: " + s + " sm");
            Console.WriteLine("Perimetar on your rectangles is: " + p + " sm");
        }
    }
}
