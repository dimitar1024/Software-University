using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 8.	Numbers from 1 to n");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line. Note that you may need to use a for-loop. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Numbers...");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i+1);
             
            }
        }
    }
}
