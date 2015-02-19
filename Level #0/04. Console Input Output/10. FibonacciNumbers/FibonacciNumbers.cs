using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 10.	Fibonacci Numbers");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by spaces) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …. Note that you may need to learn how to use loops. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            decimal firstNumber = 0;
            decimal secondNumber = 1;
            decimal nextNumber = firstNumber + secondNumber;
            if (n == 1)
            {
                Console.WriteLine(firstNumber);
            }
            if (n == 2)
            {
                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
            }
            if (n >=3)
            {


                Console.WriteLine(firstNumber);
                Console.WriteLine(secondNumber);
                Console.WriteLine(nextNumber);
                for (int i = 3; i < n; i++)
                {

                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                    nextNumber = firstNumber + secondNumber;
                    Console.WriteLine(nextNumber);
                }
            }
        }
    }
}
