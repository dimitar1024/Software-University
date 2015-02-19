using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.RandomizeTheNumbers1N
{
    class RandomizeTheNumbers1N
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,-3}",rnd.Next(1,n));
            }
        }
    }
}
