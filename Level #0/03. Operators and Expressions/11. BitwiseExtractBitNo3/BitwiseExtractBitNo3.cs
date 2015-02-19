using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BitwiseExtractBitNo3
{
    class BitwiseExtractBitNo3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 11.	Bitwise: Extract Bit #3");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer. The bits are counted from right to left, starting from bit #0. The result of the expression should be either 1 or 0. ");
            Console.WriteLine(new string('=', 80));

            int number;
            do
            {
                Console.WriteLine("Enter the bit:");
                number = int.Parse(Console.ReadLine());
                int mask = 1 << 3;
                int bit;
                int result;
                bit = number & mask;
                result = bit >> 3;
                Console.WriteLine("The bit is: " + result);
            } while (number is int);
            
        }
    }
}
