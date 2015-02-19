using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.JoroTheFootballPlayer
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            double year = 52;
            double holidays = p;
            double hometown = h;
            double normal = year-hometown;

            double plays = (hometown * 1d) + (normal * 2d / 3d) + (holidays * 1d/2d);

            if (leap == "t")
            {
                plays += 3;
            }

            Console.WriteLine((int)plays);
        }
    }
}
