using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.CheckABitAtGivenPosition
{
    class CheckABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 13.	Check a Bit at Given Position");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n has value of 1. ");
            Console.WriteLine(new string('=', 80));

            int number, p;
            bool exit;
            do
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());
                p = int.Parse(Console.ReadLine());
                int mask = 1 << p;
                int bit;
                int result;
                bit = number & mask;
                result = bit >> p;
                if (result == 1)
                {
                    exit = true;
                    Console.Write("bit on position {0} is 1? ",p);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(exit);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    exit = false;
                    Console.Write("bit on position {0} is 1? ",p);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(exit);
                    Console.ResetColor();
                    Console.WriteLine();
                }
            } while (number is int);
        }
    }
}
