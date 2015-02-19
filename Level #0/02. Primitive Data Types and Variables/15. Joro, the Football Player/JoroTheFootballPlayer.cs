using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Joro__the_Football_Player
{
    class JoroTheFootballPlayer
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter \"t\" for leap year  or \"f\" for that is not leap");
            string leap = Console.ReadLine();
            Console.WriteLine("Enter holiday weekends:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter weekends that Joro spends in his hometown:");
            int h = int.Parse(Console.ReadLine());

            int weekends = 52;
            int hometown = h;
            int normal = weekends - hometown;
            int holidays = p;
            double plays = (hometown * 1d) + (normal * 2d / 3d) + (holidays / 2d);
            if (leap == "t")
            {
                plays += 3;
            }
            Console.WriteLine((int)plays);
        }
    }
}
