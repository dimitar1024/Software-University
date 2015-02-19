using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BeerTime
{
    class BeerTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 10.	* Beer Time");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"A beer time is after 1:00 PM and before 3:00 AM. Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints “beer time” or “non-beer time” according to the definition above or “invalid time” if the time cannot be parsed. Note that you may need to learn how to parse dates and times. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter a time in format \"hh:mm tt\" (Example: 04:35 PM)");
            DateTime time = DateTime.Parse(Console.ReadLine());
            int hour = time.TimeOfDay.Hours;

            if ((hour >= 13 && hour <=24) || (hour >=0 && hour <=3))
            {
                Console.WriteLine("beer time");
            }
            else
            {
                Console.WriteLine("non-beer time");
            }
        }
    }
}
