using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.SimpleLoops
{
    class SimpleLoops
    {
        static void Main(string[] args)
        {
            BigInteger t1 = BigInteger.Parse(Console.ReadLine());
            BigInteger t2 = BigInteger.Parse(Console.ReadLine());
            BigInteger t3 = BigInteger.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            BigInteger firstEl = t1;
            BigInteger secondEl = t2;
            BigInteger thirdEl = t3;
            BigInteger nextEl = t1 + t2 + t3;

            if (n == 1)
            {
                Console.WriteLine(0);
            }
            if (n == 2)
            {
                Console.WriteLine(firstEl);
            }
            if (n==3)
            {
                Console.WriteLine(thirdEl);
            }
            if (n >= 4)
            {
                for (int i = 4; i < n; i++)
                {
                    firstEl = secondEl;
                    secondEl = thirdEl;
                    thirdEl = nextEl;
                    nextEl = firstEl + secondEl + thirdEl;
                    
                }
                Console.WriteLine(nextEl);
            }   
        }
    }
}
