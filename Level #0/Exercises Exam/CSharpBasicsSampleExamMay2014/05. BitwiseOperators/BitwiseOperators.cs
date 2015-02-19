using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitwiseOperators
{
    class BitwiseOperators
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] algoritam = new int[n];

            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                //Console.WriteLine(Convert.ToString(p, 2));
                int invert = ~p;
                int reverse = 0;

                while (p > 0)
                {
                    int bit = p & 1;
                    reverse = reverse << 1;
                    reverse = reverse | bit;
                    p = p >> 1;
                }
                
                algoritam[i] = reverse;
                reverse = 0;
            }
            foreach (int numb in algoritam)
            {
                Console.WriteLine(numb);
            }
        }

    }
}
