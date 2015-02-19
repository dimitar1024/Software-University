using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.TheBiggestOfThreeNumbers
{
    class TheBiggestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 5.	The Biggest of 3 Numbers");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that finds the biggest of three numbers. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter the numbers:");
            double biggest = -10; // ако началната стойност е 0 то, ако най-голямото число е отрицателно след проверката ще изпише 0. Затова съм поставил една примерна стойност -10
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter #{0}",i+1);
                double number = double.Parse(Console.ReadLine());
                if (number > biggest)
                {
                    biggest = number;
                }
            }
            Console.WriteLine("The biggest is: " + biggest);
        }
    }
}
