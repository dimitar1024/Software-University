using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.PrimeChecker
{
    class PrimeChecker
    {
        static void Main(string[] args)
        {
            string input = "";
            while (!(input == "exit"))
            {
                Console.WriteLine("Enter n:");
                input = Console.ReadLine();
                if (input == "exit")
                {
                    Console.WriteLine();
                    Console.WriteLine("Bye-bye");
                    Console.WriteLine();
                    break;
                }
                int num = int.Parse(input);
                IsPrime(num);

            }
        }
        static void IsPrime(int n)
        {
            bool result = true;
            if ((n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0) && (n % 7 != 0) || (n == 1) || (n == 2) || (n == 3) || (n == 5) || (n == 7))
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
    }
}
