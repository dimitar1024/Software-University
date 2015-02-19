using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.PrintLongSequence
{
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 16.	* Print Long Sequence");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, … You might need to learn how to use loops in C# (search in Internet).");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("PrintLong Sequence");
            for (int i = 2; i < 1001; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("-" + i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
