using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class WineGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outGlass = 0;
            int wine = 0;

            for (int i = 0; i < n/2; i++)
            {
                
                    outGlass = i;
                    wine = n - outGlass * 2 - 2;
                    string outGlassStr = new string('.', outGlass);
                    string wineStr = new string('*', wine);
                    Console.WriteLine("{0}\\{1}/{0}", outGlassStr, wineStr);
            }

            int outNum = 0;
            string outStr = "";
            string glassStr = "||";
            if (n <12)
            {
                for (int i = 0; i < (n/2)-1; i++)
                {
                    outNum = (n - 2) / 2;
                    outStr = new string('.', outNum);
                    Console.WriteLine("{0}{1}{0}",outStr,glassStr);
                    
                }
                Console.WriteLine(new string('-', n));
            }

            if (n >= 12)
            {
                for (int i = 0; i < (n / 2) - 2; i++)
                {
                    outNum = (n - 2) / 2;
                    outStr = new string('.', outNum);
                    Console.WriteLine("{0}{1}{0}", outStr, glassStr);

                }
                Console.WriteLine(new string('-', n));
                Console.WriteLine(new string('-', n));
            }
        }
    }

