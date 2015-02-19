using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.MinMaxSumAndAverageOfNNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double max = 0;
            double min = 0;
            double sum = 0;
            double avg = 0;

            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i==1)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }

                sum += number;
            }

            avg = sum / n;

            Console.WriteLine("min = {0}", min);
            Console.WriteLine("max = {0}", max);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("avg = {0:f2}", avg);

        }
    }
}
