using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 18.	** – Odd / Even Sum");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .
You are given a number n and 2*n numbers. Write a program to check whether the sum of the odd numbers is equal to the sum of the even n numbers. The first number is considered odd, the next even, the next odd again, etc. Print as result “Yes” or “No”. In case of yes, print also the sum. In case of no, print also the difference between the odd and the even sums.
");
            Console.WriteLine(new string('=', 80));

            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            for (int i = 1; i <= 2*n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sum2 += num;
                }
                else
                {
                    sum1 += num;
                }
            }

            if (sum1 == sum2)
            {
                Console.WriteLine("Yes, sum=" + sum1);
            }
            else
            {
                int diff = Math.Abs(sum2 - sum1);
                Console.WriteLine("No, diff=" + diff);
            }

        }
    }
}
