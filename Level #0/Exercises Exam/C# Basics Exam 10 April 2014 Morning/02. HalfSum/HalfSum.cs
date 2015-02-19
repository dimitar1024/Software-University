using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.HalfSum
{
    class HalfSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum1 = 0;
            int sum2 = 0;
            int arr = 2 * n;

            for (int i = 0; i <arr; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i <n)
                {
                    sum1 += num;
                }
                if (i >= n)
	            {
                    sum2 +=num;
	            }
            }
            if (sum1==sum2)
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
