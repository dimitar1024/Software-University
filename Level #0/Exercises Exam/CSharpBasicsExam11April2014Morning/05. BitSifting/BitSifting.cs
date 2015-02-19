using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _05.BitSifting
{
    class BitSifting
    {
        static void Main(string[] args)
        {
            ulong number = ulong.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            ulong count = 0;
            for (int i = 0; i < n; i++)
            {
                ulong num = ulong.Parse(Console.ReadLine());
                number = number & ~(num);

            }

            while (number > 0)
            {
                count += (number & 1);
                number >>= 1;
            }
            Console.WriteLine(count);

        }
    }
}
