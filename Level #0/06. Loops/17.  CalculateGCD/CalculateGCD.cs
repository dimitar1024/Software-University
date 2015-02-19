using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.CalculateGCD
{
    class CalculateGCD
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first  number: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int b = int.Parse(Console.ReadLine());
            int minValue = Math.Min(Math.Abs(a), Math.Abs(b));

            for (int i = minValue; i >= 0; i--)
            {
                if ((a % i == 0) && (b % i == 0))
                {
                    Console.WriteLine("NOD is: " + i);
                    break;
                }

            }
        }
    }
}
