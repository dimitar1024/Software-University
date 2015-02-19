using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 13.	* – Triangle");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"You are given a two-dimensional Cartesian coordinate system and three points A, B, C with coordinates: A(Ax, Ay), B(Bx,  By), C(Cx, Cy). Write a program to check if these three points can form a triangle. Then calculate the area of this triangle. To find the distance between two points with the coordinates (x1, y1) and (x2, y2) use the formula:
D= √(〖〖(x〗_2-x_1)〗^2+〖〖(y〗_2-y_1)〗^2 )  
You can use the inequalities of a triangle to check whether three segments a, b and c can form a triangle:
a+b>c;  b+c>a; a+c>b
To calculate the area you can use Heron`s formula (a method for calculating the area of a triangle when you know the lengths of all three sides). Let a, b, c be the lengths of the sides of a triangle. Thus:
Area=√(p(p-a)(p-b)(p-c) ), where p is half the perimeter: (a+b+c)/2.
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter point on your triangle:");
            double[] x = new double[3];
            double[] y = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter X on point #{0}", i + 1);
                x[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Y on point #{0}", i + 1);
                y[i] = double.Parse(Console.ReadLine());
            }
            double a = Math.Sqrt(Math.Pow((x[1] - x[0]), 2) + Math.Pow((y[1] - y[0]), 2));
            double b = Math.Sqrt(Math.Pow((x[2] - x[1]), 2) + Math.Pow((y[2] - y[1]), 2));
            double c = Math.Sqrt(Math.Pow((x[2] - x[0]), 2) + Math.Pow((y[2] - y[0]), 2));
            
            if ((a + b > c) && (b + c > a) && (a + c > b))
            {
                Console.WriteLine("Yes");
                double p = (a + b + c) / 2;
                double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
                Console.WriteLine("{0:f2}", area);
            }

            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:f2}", a);
            }
        }
    }
}
