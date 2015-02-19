using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.TheExplorer
{
    class TheExplorer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 19.	** – The Explorer");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
Bai Vylcho is very an enthusiastic explorer. His passion are the diamonds, he just adores them. Today he is going on an expedition to collect all kind of diamonds, no matter small or large. Help your friend to find all the diamonds in the biggest known cave "The Console Cave". At the only input line you will be given the width of the diamond. The char that forms the outline of the diamonds is '*' and the surrounding parts are made of '-' (see the examples). Your task is to print a diamond of given size n.
");
            Console.WriteLine(new string('=', 80));

            int n = int.Parse(Console.ReadLine());
            int divider = n / 2;
            int outDiamond;
            string outDiam;
            string diamond = new string('*', 1);
            int space;
            for (int i = 0; i <= divider; i++)
            {
                
                space = 1 + ((i-1)*2);
                
                
                
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
                    outDiamond = (n - (1 + i * 2))/2;
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

