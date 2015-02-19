using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitRoller
{
    class BitRoller
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int freeze = int.Parse(Console.ReadLine());
            int rolls = int.Parse(Console.ReadLine());

            int endbits = 0;
            int index = 0;
            for (int i = 0; i < rolls; i++)
            {


                for (int bit = 0; bit <= 19; bit++)
                {
                    int bitEnd = 0;

                    if (index == 0)
                    {
                        bitEnd = number & 1;
                    }
                    if ((index % freeze != 1) && (index != 19) && (index != 0))
                    {
                        int bitNow = (number >> index) & 1;
                        endbits = endbits >> 1;
                        endbits = endbits | bitNow;
                    }
                    if (index == 19)
                    {
                        endbits = endbits | bitEnd;
                    }
                    index++;
                }
            }
            Console.WriteLine(endbits);
        }
    }
}
