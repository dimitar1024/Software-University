using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.OddOrEvenIntegers
{
    class OddOrEvenIntegers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.	Odd or Even Integers");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an expression that checks if given integer is odd or even.");
            Console.WriteLine(new string('=', 80));

            int number;
            do
            {
                bool odd = true;
                Console.WriteLine("Enter your number: ");
                number = int.Parse(Console.ReadLine());
                if (number % 2 == 0)
                {
                    odd = false;
                    Console.Write("Is the number odd? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(odd);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    odd = true;
                    Console.Write("Is the number odd? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(odd);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                
            } while (number is int);    
            
                
            // do while цикъла съм го поставил за да проверявате повече числа с едно стартиране на програмата.
            // няма нищо общо с работата на програмата :)
            
        }
    }
}
