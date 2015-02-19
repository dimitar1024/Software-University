using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PrintASequence
{
    class PrintASequence
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 9.	Print a Sequence");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...");
            Console.WriteLine(new string('=', 80));

            for (int i = 2; i <= 11; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("-"+ i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
