using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.PrimeNumberCheck
{
    class PrimeNumberCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 8.	Prime Number Check");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an expression that checks if given positive integer number n (n ≤ 100) is prime (i.e. it is divisible without remainder only to itself and 1). ");
            Console.WriteLine(new string('=', 80));

            int number;
            bool result;

            do
            {
                Console.WriteLine("Enter number:");
                number = int.Parse(Console.ReadLine());
                if (number > 0 && number < 100)
                {
                    if ((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0) || (number == 1) || (number == 2) || (number == 3) || (number == 5) || (number == 7))
                    {
                        result = true;
                        Console.Write("The number is prime? ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(result);
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                    else
                    {
                        result = false;
                        Console.Write("The number is prime? ");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(result);
                        Console.ResetColor();
                        Console.WriteLine();
                    }
                }
            } while (number is int);
        }
    }
}
