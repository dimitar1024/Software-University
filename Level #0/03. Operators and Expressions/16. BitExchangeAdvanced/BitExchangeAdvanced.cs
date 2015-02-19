using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.BitExchangeAdvanced
{
    class BitExchangeAdvanced
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 16.	** Bit Exchange (Advanced)");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. The first and the second sequence of bits may not overlap. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter number: ");
            uint number = uint.Parse(Console.ReadLine());
            Console.WriteLine("Enter p: ");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter q: ");
            int q = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter k: ");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            int subQ = q - p;
            int subK = p + k;
            for (int i = p; i < subK; i++)
            {
                uint firstMask = (uint)1 << i;
                uint firstResult = number & firstMask;
                firstResult >>= i;
                uint secondMask = (uint)1 << (subQ + i);
                uint secondResult = number & secondMask;
                secondResult >>= (subQ + i);
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
