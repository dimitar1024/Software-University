using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.BitSifting
{
    class BitSifting
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 21.	** – Bit Sifting");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
In this problem we'll be sifting bits through sieves (sift = пресявам, sieve = сито).
You will be given an integer, representing the bits to sieve, and several more numbers, representing the sieves the bits will fall through. Your task is to follow the bits as they fall down, and determine what comes out of the other end.
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter the number:");
            ulong number = ulong.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of sieves:");
            int s = int.Parse(Console.ReadLine());
            for (int i = 0; i < s; i++)
            {
                Console.WriteLine("Enter sieve:");
                ulong sieve = ulong.Parse(Console.ReadLine());
                number = number & (~sieve);
            }

            ulong countOfBits = 0;
            while (number > 0)
            {
                countOfBits += (number & 1);
                number >>= 1;
            }

            Console.WriteLine("The bits is:");
            Console.WriteLine(countOfBits);
        }
        
    }
}
