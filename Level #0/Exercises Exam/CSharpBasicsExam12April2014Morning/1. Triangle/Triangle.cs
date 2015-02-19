using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Triangle
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int Ax = int.Parse(Console.ReadLine());
            int Ay = int.Parse(Console.ReadLine());
            int Bx = int.Parse(Console.ReadLine());
            int By = int.Parse(Console.ReadLine());
            int Cx = int.Parse(Console.ReadLine());
            int Cy = int.Parse(Console.ReadLine());

            double A = Math.Sqrt(Math.Pow((Bx-Ax),2) + Math.Pow((By-Ay),2));
            double B = Math.Sqrt(Math.Pow((Cx-Bx),2) + Math.Pow((Cy-By),2));
            double C = Math.Sqrt(Math.Pow((Ax-Cx),2) + Math.Pow((Ay-Cy),2));
            double P = (A+B+C)/2;
            if ((A + B > C) && (B + C > A) && (A + C > B))
            {
                double area = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
                Console.WriteLine("Yes");
                Console.WriteLine("{0:f2}",area);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("{0:f2}",A);
            }
		 
	    }
    }
}
