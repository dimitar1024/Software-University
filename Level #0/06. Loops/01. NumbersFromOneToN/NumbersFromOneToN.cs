using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.NumbersFromOneToN
{
    class NumbersFromOneToN
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter n:");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0} ",i+1);
            }
        }
    }
}
