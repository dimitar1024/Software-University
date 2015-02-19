using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.MagicDates
{
    class MagicDates
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 16.	** – Magic Dates");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Consider we are given a date in format dd-mm-yyyy, e.g. 17-03-2007. We calculate the weight of this date by joining together all its digits, multiplying each digit by each of the other digits and finally sum all obtained products. In our case we will have 8-digits: 17032007, so the weight is 1*7 + 1*0 + 1*3 + 1*2 + 1*0 + 1*0 + 1*7 + 7*0 + 7*3 + 7*2 + 7*0 + 7*0 + 7*7 + 0*3 + 0*2 + 0*0 + 0*0 + 0*7 + 3*2 + 3*0 + 3*0 + 3*7 + 2*0 + 2*0 + 2*7 + 0*0 + 0*7 + 0*7 = 144.
Your task is to write a program that finds all magic dates: dates between two fixed years matching given magic weight. The dates should be printed in increasing order in format dd-mm-yyyy. We use the traditional calendar (years have 12 months, each having 28, 29, 30 or 31 days, etc.). Years start from 1 January and end in 31 December.
");
            Console.WriteLine(new string('=', 80));

            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());


            DateTime startDate = new DateTime(start, 1, 1);
            DateTime stopDate = new DateTime(end, 12, 31);
            int interval = 1;
            int count = 0;

            while ((startDate = startDate.AddDays(interval)) <= stopDate)
            {
                int date = startDate.Day;
                int d1 = date / 10;
                int d2 = date % 10;
                int mouth = startDate.Month;
                int m1 = (mouth / 10);
                int m2 = mouth % 10;
                int year = startDate.Year;
                int y1 = year / 1000;
                int y2 = (year / 100) % 10;
                int y3 = (year / 10) % 10;
                int y4 = (year % 10);
                
                if ((d1 * d2 + d1 * m1 + d1 * m2 + d1 * y1 + d1 * y2 + d1 * y3 + d1 * y4 + d2 * m1 + d2 * m2 + d2 * y1 + d2 * y2 + d2 * y3 + d2 * y4 + m1 * m2 + m1 * y1 + m1 * y2 + m1 * y3 + m1 * y4 + m2 * y1 + m2 * y2 + m2 * y3 + m2 * y4 + y1 * y2 + y1 * y3 + y1 * y4 + y2 * y3 + y2 * y4 + y3 * y4) == diff)
                {
                    Console.WriteLine("{0:dd-MM-yyyy}",startDate);
                    count++;
                }
            }
            if (count == 0)
            {
                Console.WriteLine("No");
            }

        }
        
    }
}
