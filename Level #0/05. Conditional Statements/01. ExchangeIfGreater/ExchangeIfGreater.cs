using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExchangeIfGreater
{
    class ExchangeIfGreater
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.	Exchange If Greater");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an if-statement that takes two integer variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());

            if (a >= b)
            {
                Console.WriteLine("{0} {1}",b,a);
            }
            if (a < b)
            {
                Console.WriteLine("{0} {1}",a,b);
            }
            
        }
    }
}
