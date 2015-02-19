using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Comparing_Floats
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 13.	*Comparing Floats");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001. Note that we cannot directly compare two floating-point numbers a and b by a==b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps. Examples:");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter the first number: ");
            decimal firstNumber = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            decimal secondNumber = decimal.Parse(Console.ReadLine());
            bool result;

            if (result = Math.Round(firstNumber,6) == Math.Round(secondNumber,6))
            {
                Console.WriteLine("Are you equal? {0}",result);
            }
            else
            {
                Console.WriteLine("Are you equal? {0}", result);
            }
            if (Math.Round(firstNumber,6) > Math.Round(secondNumber,6))
            {
                Console.WriteLine("First number is greater than Second number");
            }
            if (Math.Round(firstNumber,6) < Math.Round(secondNumber,6))
            {
                Console.WriteLine("Second number is greater than Second number");
            }
        }
    }
}
