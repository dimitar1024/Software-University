using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DivideBySevenAndFive
{
    class DivideBySevenAndFive
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 3.	Divide by 7 and 5");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time. ");
            Console.WriteLine(new string('=', 80));

            int number;
            bool result = true;

            do
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());
                if ((number % 5 == 0) && (number % 7 == 0))
                {
                    result = true;
                    Console.Write("Is the number odd? ");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(result);
                    Console.ResetColor();
                    Console.WriteLine();
                }
                else
                {
                    result = false;
                    Console.Write("Is the number odd? ");
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
