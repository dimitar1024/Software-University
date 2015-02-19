using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _11.RandomNumbersInGivenRange
{
    class RandomNumbersInGivenRange
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write("{0,-3}",rnd.Next(min,max));
            }
        }
    }
}
