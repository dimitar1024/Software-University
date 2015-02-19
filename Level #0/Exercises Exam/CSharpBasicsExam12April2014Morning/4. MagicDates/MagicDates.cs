using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.MagicDates
{
    class MagicDates
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());

            DateTime startDate = new DateTime(start, 1, 1);
            DateTime endDate = new DateTime(end, 12, 31);
            int interval = 1;
            int count = 0;


            while ((startDate = startDate.AddDays(interval))<=endDate)
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

                if ((d1 * d2 + d1 * m1 + d1 * m2 + d1 * y1 + d1 * y2 + d1 * y3 + d1 * y4 + d2 * m1 + d2 * m2 + d2 * y1 + d2 * y2 + d2 * y3 + d2 * y4 + m1 * m2 + m1 * y1 + m1 * y2 + m1 * y3 + m1 * y4 + m2 * y1 + m2 * y2 + m2 * y3 + m2 * y4 + y1 * y2 + y1 * y3 + y1 * y4 + y2 * y3 + y2 * y4 + y3 * y4) == magic)
                {
                    Console.WriteLine("{0:dd-MM-yyyy}", startDate);
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
