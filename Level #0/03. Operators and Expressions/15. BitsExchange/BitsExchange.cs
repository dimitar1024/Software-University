using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.BitsExchange
{
    class BitsExchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 15.	* Bits Exchange");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number,2).PadLeft(32,'0'));
            for (int i = 3; i <= 5; i++)
            {
                uint firstMask = (uint)1 << i;
                uint firstResult = number & firstMask;
                firstResult >>= i;
                uint secondMask = (uint)1 << (21 + i);
                uint secondResult = number & secondMask;
                secondResult >>= (21 + i);
                if (secondResult == 1)
                {
                    number |= firstMask;
                }
                else
                {
                    number &= (~firstMask);
                }
                if (firstResult == 1)
                {
                    number |= secondMask;
                }
                else
                {
                    number &= (~secondMask);
                }

            }
            Console.WriteLine("After exchange");
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));

        }
    }
}
