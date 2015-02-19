using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.TheExplorer
{
    class TheExplorer
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int divider = n / 2;
            int outDiamond;
            string outDiam;
            string diamond = new string('*', 1);
            int space;
            for (int i = 0; i <= divider; i++)
            {

                space = 1 + ((i - 1) * 2);



                if (i == 0)
                {
                    outDiamond = (n - 1) / 2;
                    outDiam = new string('-', outDiamond);
                    Console.Write(outDiam);
                    Console.Write(diamond);
                    Console.WriteLine(outDiam);
                }
                if ((i <= divider) && !(i == 0))
                {
                    outDiamond = (n - (1 + i * 2)) / 2;
                    outDiam = new string('-', outDiamond);
                    string spaceStr = new string('-', space);
                    Console.Write(outDiam);
                    Console.Write(diamond);
                    Console.Write(spaceStr);
                    Console.Write(diamond);
                    Console.WriteLine(outDiam);
                }
            }
            for (int j = divider; j >= 0; j--)
            {
                diamond = new string('*', 1);
                space = 1 + ((j - 1) * 2);



                if (j == 0)
                {
                    outDiamond = (n - 1) / 2;
                    outDiam = new string('-', outDiamond);
                    Console.Write(outDiam);
                    Console.Write(diamond);
                    Console.WriteLine(outDiam);
                }
                if ((j < divider) && !(j == 0))
                {
                    outDiamond = (n - (1 + j * 2)) / 2;
                    outDiam = new string('-', outDiamond);
                    string spaceStr = new string('-', space);
                    Console.Write(outDiam);
                    Console.Write(diamond);
                    Console.Write(spaceStr);
                    Console.Write(diamond);
                    Console.WriteLine(outDiam);
                }
            }
        }
    }
}
