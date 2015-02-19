using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter N:");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int divider = (n / 2);
                int frameWidth = n * 2;
                int space = n;
                string spaceStr = new string(' ', space);
                string lenses = new string('/', frameWidth-2);
                string lensesStr = "*" + lenses + "*";
                if (i == 0 || i==n-1)
                {
                    string frame = new string('*', frameWidth);
                    Console.Write(frame);
                    Console.Write(spaceStr);
                    Console.WriteLine(frame);
                }
                if (divider == i)
                {
                    string bridgeStr = new string('|', space);
                    Console.Write(lensesStr);
                    Console.Write(bridgeStr);
                    Console.WriteLine(lensesStr);
                }
                if ((i != 0) && (i != n-1) && (i != divider))
                {
                    Console.Write(lensesStr);
                    Console.Write(spaceStr);
                    Console.WriteLine(lensesStr);
                }
                
            }
            

        }
    }
}
