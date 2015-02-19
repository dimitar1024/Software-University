using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SumOfThreeNumbers
{
    class SumOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.	Sum of 3 Numbers");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that reads 3 real numbers from the console and prints their sum. ");
            Console.WriteLine(new string('=', 80));

            double sum = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter #{0}",i+1);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
