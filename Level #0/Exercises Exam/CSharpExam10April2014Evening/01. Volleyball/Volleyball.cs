using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string leap = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int year = 48;
            int hometown = h;
            int holidays = p;
            int normal = year - hometown;

            double plays = (hometown * 1) + (normal * 3d / 4d) + holidays * 2d / 3d;

            if (leap == "leap")
            {
                plays = plays + (plays * 0.15d);
            }
            Console.WriteLine((int)plays);
        }
    }
}
