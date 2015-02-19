using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14__DecimalТoBinaryNumber
{
    class DecimalТoBinaryNumber
    {
        static void Main(string[] args)
        {
            long input = long.Parse(Console.ReadLine());
            string bitNumber = "";

            while (input!=0)
            {
                int bit = (int) input % 2;
                input = input / 2;
                bitNumber = bit + bitNumber;

            }

            Console.WriteLine(bitNumber);
        }
    }
}
