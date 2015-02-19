using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.BitsUp
{
    class BitsUp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 20.	** – Bits Up");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .
You are given a sequence of bytes. Consider each byte as sequences of exactly 8 bits.  You are given also a number step. Write a program to set to 1 the bits at positions: 1, 1 + step, 1 + 2*step, ... Print the output as a sequence of bytes.
Bits in each byte are counted from the leftmost to the rightmost. Bits are numbered starting from 0.
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter step: ");
            int step = int.Parse(Console.ReadLine());
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the number:");
                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
                for (int j = 7; j >= 0; j--)
                {
                    if ((index % step == 1) || (step == 1 && index > 0))
                    {
                        number = number | (1 << j);
                    }
                    index++;
                }
                Console.WriteLine(number);
                Console.WriteLine(Convert.ToString(number, 2).PadLeft(8, '0'));
            }






            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
            //for (int i = 3; i <= 5; i++)
            //{
            //    uint firstMask = (uint)1 << i;
            //    uint firstResult = number & firstMask;
            //    firstResult >>= i;
            //    uint secondMask = (uint)1 << (21 + i);
            //    uint secondResult = number & secondMask;
            //    secondResult >>= (21 + i);
            //    if (secondResult == 1)
            //    {
            //        number |= firstMask;
            //    }
            //    else
            //    {
            //        number &= (~firstMask);
            //    }
            //    if (firstResult == 1)
            //    {
            //        number |= secondMask;
            //    }
            //    else
            //    {
            //        number &= (~secondMask);
            //    }

            //}
            //Console.WriteLine("After exchange");
            //Console.WriteLine(number);
            //Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        }
    }
}
