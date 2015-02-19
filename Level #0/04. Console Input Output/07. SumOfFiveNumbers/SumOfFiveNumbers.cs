using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.SumOfFiveNumbers
{
    class SumOfFiveNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 7.	Sum of 5 Numbers");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum. ");
            Console.WriteLine(new string('=', 80));

            double sum = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter number #{0}",i+1);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum is:");
            Console.WriteLine(sum);
        }
    }
}
