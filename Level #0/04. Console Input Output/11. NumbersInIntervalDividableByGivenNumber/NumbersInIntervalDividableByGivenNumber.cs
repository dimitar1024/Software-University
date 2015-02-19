using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.NumbersInIntervalDividableByGivenNumber
{
    class NumbersInIntervalDividableByGivenNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 11.	* Numbers in Interval Dividable by Given Number");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter start:");
            int start = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter start:");
            int end = int.Parse(Console.ReadLine());
            int p = 0;
            for (int i = start; i <= end; i++)
            {
                if ((i % 5 == 0)||(i % 10 == 0))
                {
                    p++;
                }
            }
            Console.WriteLine("Numbers: "+ p);

        }
    }
}
