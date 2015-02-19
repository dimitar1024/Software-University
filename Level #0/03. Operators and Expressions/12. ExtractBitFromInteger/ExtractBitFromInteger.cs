using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.ExtractBitFromInteger
{
    class ExtractBitFromInteger
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 12.	Extract Bit from Integer");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write an expression that extracts from given integer n the value of given bit at index p. ");
            Console.WriteLine(new string('=', 80));

            int number, p;
            do
            {
                Console.WriteLine("Enter number: ");
                number = int.Parse(Console.ReadLine());
                p = int.Parse(Console.ReadLine());
                int mask = 1 << p;
                int bit;
                int result;
                bit = number & mask;
                result = bit >> p;
                Console.WriteLine("The bit on position {0} in your number {1} is {2}", p, number, result);
            } while (number is int);
            
        }
    }
}
