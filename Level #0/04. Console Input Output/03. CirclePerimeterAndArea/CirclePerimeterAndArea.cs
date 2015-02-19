using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 3.	Circle Perimeter and Area");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter r:");
            double r = double.Parse(Console.ReadLine());
            double area = r*r * Math.PI;
            double perimeter = 2 * r * Math.PI;
            Console.WriteLine("The perimeter is: {0:f2} см", perimeter);
            Console.WriteLine("The area is: {0:f2} см",area);
        }
    }
}
