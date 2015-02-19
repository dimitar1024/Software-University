using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem05_BitArray
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            var bits = new BitArray(1024);
            bits[1000] = 1;
            Console.WriteLine(bits);
        }
    }
}
