using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Arrow
{
    class Arrow
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int outArrow = n / 2;
            int widthRow = n * 2 - 1;
            string outStr = "";
            string arrow = "";

            for (int i = 0; i < (n-1); i++)
            {
                
                if (i == 0)
                {
                    arrow = new string('#', n);
                    outStr = new string('.', outArrow);
                    Console.WriteLine("{0}{1}{0}",outStr,arrow);
                }
                if (!(i == 0))
                {


                    outStr = new string('.', outArrow);
                    arrow = new string('.', n - 2);

                    Console.WriteLine("{0}#{1}#{0}", outStr, arrow);
                }
            }
            arrow = new string('.', n - 2);
            outStr = new string('#', outArrow);
            Console.WriteLine("{0}#{1}#{0}",outStr,arrow);

            // roof
            int outRoof = 0;
            int inRoof = 0;
            for (int i = (n-2); i > 0; i--)
            {
                outRoof = n-1-i;
                inRoof = widthRow - 2 - (outRoof*2);
                string outRoofStr = new string('.', outRoof);
                string inRoofStr = new string('.', inRoof);
                Console.WriteLine("{0}#{1}#{0}",outRoofStr,inRoofStr);

            }

            string endStr = new string('.', n-1);
            Console.WriteLine("{0}#{0}",endStr);


        }
    }
}
