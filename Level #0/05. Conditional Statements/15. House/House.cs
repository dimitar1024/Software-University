using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.House
{
    class House
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 15.	* – House");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Ivaylo decided he needs a new house. Since he is not a structural engineer yet, you have to help him construct the building from the ground zero.
The roof is a triangle. The walls are straight vertical lines. The base is a straight horizontal line. The roof, the walls and the base of the house it build of '*'. Everything else is filled with '.' (see the examples below to catch the idea).
You will be given an odd integer N, representing the width and the height of the house. The roof’s top starts from the center (N+1)/2 and forms a triangle with base of width N. The roof’s height is (N+1)/2. The distance between the roofs’ end point and the walls of the building is N/4, rounded down to an integer number. See the examples below to understand better these formulas.
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter number:");
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
                    Console.Write(endRoofStr);
                    Console.Write(roofStr);
                    Console.Write(inRoofStr);
                    Console.Write(roofStr);
                    Console.WriteLine(endRoofStr);
                }
                if (i == divider)
                {
                    roof = n;
                    roofStr = new string('*', roof);
                    Console.WriteLine(roofStr);
                }
            }
            for (int j = 0; j < (n-1)/2; j++)
            {
                    roof = 1;
                    roofStr = new string('*', roof);
                    string outHomeStr = new string('.', outHome);
                    int inHome = n - (2 * outHome + 2);
                    string inHomeStr = new string('.', inHome);
                if (j != (n - 2) / 2)
                {
                    Console.Write(outHomeStr);
                    Console.Write(roofStr);
                    Console.Write(inHomeStr);
                    Console.Write(roofStr);
                    Console.WriteLine(outHomeStr);
                }
                if (j == (n - 2) / 2)
                {
                    roof = inHome+2;
                    roofStr = new string('*', roof);
                    Console.Write(outHomeStr);
                    Console.Write(roofStr);
                    Console.WriteLine(outHomeStr);
                }
            }

        }
    }
}
