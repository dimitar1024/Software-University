using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.PointInACircle
{
    class PointInACircle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 7.	Point in a Circle");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2).");
            Console.WriteLine(new string('=', 80));

            double x, y,sqrt;
            bool result;
            do
            {
                Console.WriteLine("Enter X: ");
                x = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y: ");
                y = double.Parse(Console.ReadLine());
                result = true;
                sqrt = Math.Sqrt(x * x + y * y);
                if (sqrt <= 2)
                {
                    result = true;
                    Console.Write("The point is inside of circle? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    result = false;
                    Console.Write("The point is inside of circle? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
            } while (x is int);
            
        }
    }
}
