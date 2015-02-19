using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _18.TrailingZeroesInN
{
    class TrailingZeroesInN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }

            while (factorial %10 == 0)
            {
                count++;
                factorial = factorial / 10;
            }

            Console.WriteLine(count);
        }
    }
}
