using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddEvenSum
{
    class OddEvenSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumEven = 0;
            int sumOdd = 0;

            for (int i = 1; i <= 2 * n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    sumEven += num;
                }
                else
                {
                    sumOdd += num;
                }
            }
            if (sumEven == sumOdd)
            {
                Console.WriteLine("Yes, sum={0}", sumEven);
            }
            else
            {
                int diff = Math.Abs(sumEven - sumOdd);
                Console.WriteLine("No, diff={0}", diff);
            }
        }
    }
}

