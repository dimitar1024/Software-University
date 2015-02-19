using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberComparer
{
    class NumberComparer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 4.	Number Comparer");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that gets two numbers from the console and prints the greater of them. Try to implement this without if statements. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine());
            double greater = (a + b + Math.Abs(a - b)) / 2;
            Console.WriteLine("The graeter is: {0}",greater);
        }
    }
}
