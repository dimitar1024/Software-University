using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SumOfNNumbers
{
    class SumOfNNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 9.	Sum of n Numbers");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note that you may need to use a for-loop. ");
            Console.WriteLine(new string('=', 80));

            double sum = 0;
            Console.WriteLine("Enter number of integers:");
            int numbers = int.Parse(Console.ReadLine());
            for (int i = 0; i < numbers; i++)
            {
                Console.WriteLine("Enter number #{0}",i+1);
                double number = double.Parse(Console.ReadLine());
                sum += number;
            }
            Console.WriteLine("The sum is:");
            Console.WriteLine(sum);
        }
    }
}
