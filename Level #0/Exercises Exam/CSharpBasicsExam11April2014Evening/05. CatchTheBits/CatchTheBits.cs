using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.CatchTheBits
{
    class CatchTheBits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int index = 0;
            int counter = 0;
            int outBits = 0;
            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                
                for (int bit = 7; bit >= 0; bit--)
                {
                    if ((index % step == 1)||(step == 1 && index>0))
                    {
                        int bitvalue = (num >> bit) & 1;
                        outBits = outBits << 1;
                        outBits = outBits | bitvalue;
                        counter++;

                        if (counter == 8)
                        {
                            Console.WriteLine(outBits);
                            counter = 0;
                            outBits = 0;
                        }

                        
                    }
                    index++;
                }

            }
            if (counter > 0)
            {
                outBits = outBits << (8 - counter);
                Console.WriteLine(outBits);
            }
        }
    }
}
