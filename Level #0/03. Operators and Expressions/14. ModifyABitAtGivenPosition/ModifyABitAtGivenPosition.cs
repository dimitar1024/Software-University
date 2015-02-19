using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.ModifyABitAtGivenPosition
{
    class ModifyABitAtGivenPosition
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 14.	Modify a Bit at Given Position");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n. ");
            Console.WriteLine(new string('=', 80));

            int number, p,v,result,mask;
            
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter position:");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter value:");
            v = int.Parse(Console.ReadLine());
            
            if (v == 1)
            {
                mask = 1 << p;
                result = number | mask;
                Console.WriteLine("The new number is: " + result);
            }
            if (v == 0)
            {
                mask = ~(1 << p);
                result = number & mask;
                Console.WriteLine("The new number is: " + result);
            }
            
            
        }
    }
}
