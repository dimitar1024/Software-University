using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CatchTheBits
{
    class CatchTheBits
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 17.	– Catch the Bits");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 4 of C# Basics exam from 11-04-2014 Evening.  You can test your solution here .
You are given a sequence of bytes. Consider each byte as sequence of exactly 8 bits.  You are given also a number step. Write a program to extract all the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes. In case the last byte have less than 8 bits, add trailing zeroes at its right end. Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 0.
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter number of integers:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the step:");
            int step = int.Parse(Console.ReadLine());
            int index = 0;
            int outputBits = 0;
            int outputBitsCount = 0;


            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter nujmber #{0}",i+1);
                int number = int.Parse(Console.ReadLine());
                
                for (int j = 7; j >= 0; j--)
                {
                    if ((index % step == 1)||(step ==1 && index > 0))
                    {
                        int bit = (number >> j) & 1;
                        outputBits = outputBits << 1;
                        outputBits = outputBits | bit;
                        outputBitsCount++;
                        if (outputBitsCount == 8)
                        {
                            Console.WriteLine(new string('*',20));
                            Console.WriteLine(outputBits);
                            Console.WriteLine(new string('*', 20));
                            outputBits = 0;
                            outputBitsCount = 0;
                        }
                    }
                    index++;
                }
            }
            if (outputBitsCount > 0)
            {
                outputBits = outputBits << (8 - outputBitsCount);
                Console.WriteLine(new string('*', 20));
                Console.WriteLine(outputBits);
                Console.WriteLine(new string('*', 20));
            }
        }
    }
}
