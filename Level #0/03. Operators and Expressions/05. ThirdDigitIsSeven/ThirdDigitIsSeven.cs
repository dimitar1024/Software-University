using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ThirdDigitIsSeven
{
    class ThirdDigitIsSeven
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 5.	Third Digit is 7?");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an expression that checks for given integer if its third digit from right-to-left is 7.");
            Console.WriteLine(new string('=', 80));

            int number;
            bool result = true;

            do
            {
                Console.WriteLine("Enter your number: ");
                number = int.Parse(Console.ReadLine());
                int hunds = (number / 100) % 10;
                if (hunds == 7)
                {
                    result = true;
                    Console.Write("Third digit is 7? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    result = false;
                    Console.Write("Third digit is 7? ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                
            } while (number is int);

            // do while цикъла съм го поставил за да проверявате повече числа с едно стартиране на програмата.
            // няма нищо общо с работата на програмата :)
        }
    }
}
