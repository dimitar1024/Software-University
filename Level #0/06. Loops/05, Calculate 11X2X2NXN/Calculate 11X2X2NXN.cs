using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05__Calculate_11X2X2NXN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            float sum = 1;
            float factorial = 1;
            int power = x;
            for (int count = 1; count <= n; count++)
            {
                factorial *= count;
                sum += factorial / x;
                x *= power;
            }
            Console.WriteLine("{0 :F5}", sum);
        }
    }
}
