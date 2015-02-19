using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 6.	Quadratic Equation");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots). ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine());
            double disc = b * b - (4 * a * c);
            if (disc < 0)
            {
                Console.WriteLine("no real roots");
            }
            if (disc == 0)
            {
                double result = -b / 2 * a;
                Console.WriteLine("x1=x2={0}",result);
            }
            if (disc > 0)
            {
                double sqrtDisc =Math.Sqrt(disc);
                double x1 = (-b - sqrtDisc) / (2 * a);
                double x2 = (-b + sqrtDisc) / (2 * a);
                Console.WriteLine("x1={0}; x2={1}",x1,x2);
            }

        }
    }
}
