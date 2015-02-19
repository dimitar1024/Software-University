using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.PointInsideACircleAndOutsideOfARectangle
{
    class PointInsideACircleAndOutsideOfARectangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 10.	Point Inside a Circle & Outside of a Rectangle");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2). ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter X: ");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Y: ");
            double y = double.Parse(Console.ReadLine());
            double radius = Math.Sqrt((x - 1) * (x - 1) + (y - 1) * (y - 1));

            if (((x >= -1)&&(x <=6))&&((y >=-1)&&(y <= 1)))
            {
                Console.WriteLine("No");
            }
            else
            {
                bool result = (radius <= 1.5);
                if (result == true)
                {
                    Console.Write("The point is inside K & outside of R? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Yes");
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("The point is inside K & outside of R? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("No");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }
            
        }
    }
}
