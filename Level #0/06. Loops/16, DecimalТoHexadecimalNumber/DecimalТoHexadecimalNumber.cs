using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16__DecimalТoHexadecimalNumber
{
    class DecimalТoHexadecimalNumber
    {
        static void Main(string[] args)
        {
            long decimalInput = long.Parse(Console.ReadLine());
            string hexNumber = "";

            if (decimalInput == 0)
            {
                hexNumber = "0";
            }
            else
            {
                while (decimalInput > 0)
                {
                    int numNow = (int)decimalInput % 16;
                    decimalInput = decimalInput / 16;

                    switch (numNow)
                    {
                        case 10: hexNumber = 'A' + hexNumber; break;
                        case 11: hexNumber = 'B' + hexNumber; break;
                        case 12: hexNumber = 'C' + hexNumber; break;
                        case 13: hexNumber = 'D' + hexNumber; break;
                        case 14: hexNumber = 'E' + hexNumber; break;
                        case 15: hexNumber = 'F' + hexNumber; break;

                        default: hexNumber = numNow + hexNumber; break;
                    }
                }
                Console.WriteLine(hexNumber);
            }
        }
    }
}
