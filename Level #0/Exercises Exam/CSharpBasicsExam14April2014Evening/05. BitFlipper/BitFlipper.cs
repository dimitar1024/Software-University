using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitFlipper
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());
            int endBit = 62;
            while (endBit > 0)
            {
                endBit--;
                ulong old = (n >> endBit) & 7;
                if (old == 0 || old == 7)
                {
                    n = n ^ ((ulong)7 << endBit);
                    endBit -=2;
                }
            }
            Console.WriteLine(n);
        }
    }

