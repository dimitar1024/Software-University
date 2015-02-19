using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Trapezoids
{
    class Trapezoids
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 9.	Trapezoids");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an expression that calculates trapezoid's area by given sides a and b and height h.");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter \"a\" on your trapezoids");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"b\" on your trapezoids");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter \"h\" on your trapezoids");
            double h = double.Parse(Console.ReadLine());

            double area = ((a + b) / 2) * h;
            Console.WriteLine("Area is: " + area);

        }
    }
}
