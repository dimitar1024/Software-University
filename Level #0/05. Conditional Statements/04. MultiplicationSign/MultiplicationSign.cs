using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 4.	Multiplication Sign");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it. Use a sequence of if operators. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter numbers:");
            int count = 0;
            int zeroes = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter #{0}", i+1);
                double number = double.Parse(Console.ReadLine());
                if (number < 0)
                {
                    count++;
                }
                if (number == 0)
                {
                    zeroes++;
                }
            }
            if (zeroes > 0)
            {
                Console.WriteLine("0");
            }
            if (zeroes == 0)
            {
                if (count % 2 == 0)
                {
                    Console.WriteLine("+");
                }
                else
                {
                    Console.WriteLine("-");
                }
            }
            
        }
    }
}
