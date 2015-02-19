using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.NumbersWithNestedIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 7.	Sort 3 Numbers with Nested Ifs");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that enters 3 real numbers and prints them sorted in descending order. Use nested if statements. Don’t use arrays and the built-in sorting functionality.");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter the numbers:");
            double[] numbers = new double[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter number #{0}",i+1);
                numbers[i] = double.Parse(Console.ReadLine());
            }
            if ((numbers[0] < numbers[1])&&(numbers[0] < numbers[2]))
            {
                if (numbers[1] < numbers[2])
                {
                    Console.WriteLine("{0}>{1}>{2}", numbers[2], numbers[1], numbers[0]);
                }
                else
                {
                    Console.WriteLine("{0}>{1}>{2}", numbers[1], numbers[2], numbers[0]);
                }
            }
            if ((numbers[1] < numbers[0]) && (numbers[1] < numbers[2]))
            {
                if (numbers[0] < numbers[2])
                {
                    Console.WriteLine("{0}>{1}>{2}", numbers[2], numbers[0], numbers[1]);
                }
                else
                {
                    Console.WriteLine("{0}>{1}>{2}", numbers[0], numbers[2], numbers[1]);
                }
            }
            if ((numbers[2] < numbers[0]) && (numbers[2] < numbers[1]))
            {
                if (numbers[0] < numbers[1])
                {
                    Console.WriteLine("{0}>{1}>{2}", numbers[1], numbers[0], numbers[2]);
                }
                else
                {
                    Console.WriteLine("{0}>{1}>{2}", numbers[0], numbers[1], numbers[2]);
                }
            }
        }
    }
}
