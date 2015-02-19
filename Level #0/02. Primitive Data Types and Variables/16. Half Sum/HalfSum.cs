using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Half_Sum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            Console.WriteLine("Enter first n numbers");
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum1 += number;
            }

            int sum2 = 0;
            Console.WriteLine("Enter second n numbers");
            for (int i = 0; i < n; i++)
            {
                int numbertwo = int.Parse(Console.ReadLine());
                sum2 += numbertwo;
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum={0}",sum1);
            }
            else
            {
                int diff = Math.Abs(sum1 - sum2);
                Console.WriteLine("No, diff={0}",diff);

            }
        }
    }
}
