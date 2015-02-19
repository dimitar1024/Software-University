using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 17.	**– Volleyball");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 2 of C# Basics exam from 10-04-2014 Evening.  You can test your solution here .
Vladi loves a lot to play volleyball. However, he is a programmer now and he is very busy. Now he is able to play only in the holidays and in the weekends. Vladi plays in 2/3 of the holidays and each Saturday, but not every weekend – only when he is not at work and only when he is not going to his hometown. Vladi goes at his hometown h weekends in the year. The other weekends are considered “normal”. Vladi is not at work in 3/4 of the normal weekends. When Vladi is at his hometown, he always plays volleyball with his old friends once, at Sunday. In addition, if the year is leap, Vladi plays volleyball 15% more times additionally. We assume the year has exactly 48 weekends suitable for volleyball.
Your task is to write a program that calculates how many times Vladi plays volleyball (rounded down to the nearest integer number).
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter leap or normal");
            string leap = Console.ReadLine();
            Console.WriteLine("Enter holidays");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter hometown weekends");
            int h = int.Parse(Console.ReadLine());
            int weekends = 48;
            int hometown = h;
            int normalWeekends = 48 - hometown;
            int holidays = p;
            double plays = hometown * 1d + normalWeekends * 3d / 4d + holidays * 2 / 3;
            double bonus;
            if (leap == "leap")
            {
                bonus = plays * 0.15d;
                plays = plays + bonus;
            }
            
            Console.WriteLine((int)plays);
        }
    }
}
