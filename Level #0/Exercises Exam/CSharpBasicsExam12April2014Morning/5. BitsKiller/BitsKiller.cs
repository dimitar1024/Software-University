using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.BitsKiller
{
    class BitsKiller
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index=0;
            int endBits = 0;
            int countBit = 0;
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                {
                    if (!((index % step ==1)||(step ==1 && index>0)))
                    {
                        int bitNow = (number >> bit) & 1;
                        endBits = (endBits << 1);
                        endBits = endBits | bitNow;
                        countBit++;

                        if (countBit == 8)
                        {
                            Console.WriteLine(endBits);
                            endBits = 0;
                            countBit = 0;
                        }
                    }
                    index++;
                }
            }
            if (countBit >0)
            {
                endBits = endBits << (8 - countBit);
                Console.WriteLine(endBits);
            }

        }
    }
}
