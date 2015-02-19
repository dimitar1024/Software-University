using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.House
{
    class House
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int endRoof;

            int roof = 1;
            string roofStr = "";
            string endRoofStr = "";
            int inRoof = 0;
            string inRoofStr = "";
            int center = n;
            int outHome = n / 4;
            int divider = (n - 1) / 2;

            for (int i = 0; i <= divider; i++)
            {
                int j = i + 2;
                if (i == 0)
                {
                    endRoof = (n - 1) / 2;
                    roof = 1;
                    endRoofStr = new string('.', endRoof);
                    roofStr = new string('*', roof);
                    Console.Write(endRoofStr);
                    Console.Write(roofStr);
                    Console.WriteLine(endRoofStr);
                }

                if ((i < divider) && !(i == 0))
                {
                    endRoof = (n - (1 + i * 2)) / 2;
                    roof = 1;
                    inRoof = 1 + ((i - 1) * 2);
                    endRoofStr = new string('.', endRoof);
                    roofStr = new string('*', roof);
                    inRoofStr = new string('.', inRoof);
                    Console.WriteLine("{0}{1}{2}{1}{0}",endRoofStr,roofStr,inRoofStr);
                }
                if (i == divider)
                {
                    roof = n;
                    roofStr = new string('*', roof);
                    Console.WriteLine(roofStr);
                }
            }
            for (int j = 0; j < divider; j++)
            {
                roof = 1;
                roofStr = new string('*', roof);
                string outHomeStr = new string('.', outHome);
                int inHome = n - (2 * outHome + 2);
                string inHomeStr = new string('.', inHome);
                if (j != (n - 2) / 2)
                {
                    Console.WriteLine("{0}{1}{2}{1}{0}",outHomeStr,roofStr,inHomeStr);
                    
                }
                if (j == (n - 2) / 2)
                {
                    roof = inHome + 2;
                    roofStr = new string('*', roof);
                    Console.WriteLine("{0}{1}{0}",outHomeStr,roofStr);
                }
            }

        }
    }
}
