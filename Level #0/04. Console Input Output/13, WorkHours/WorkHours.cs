using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13__WorkHours
{
    class WorkHours
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 13.	* – Work Hours");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
Lelia Vanche is a very keen freelance developer. She is well known for her outstanding skills, but she is also known for being pretty moody, which often affects her productivity. She also has a passion for bicycles and 10% of the normal work days she goes mountain-biking instead of working.
You are asked to calculate whether Lelia Vanche can finish a project on time. You will be given the number of hours required to finish the project, the days that Lelia Vanche has available for working (mind that she goes to biking in 10% of this time) and her average productivity during the given period. Assume that a normal work day for Lelia Vanche has 12 hours. Note that only the whole hours are taken (e.g. 6.98 hours is rounded down to 6 hours).
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter hours to finish the project: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter days available to finish the project: ");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the productivity in percent:");
            int p = int.Parse(Console.ReadLine());
            int hours = h;
            int days = d;
            double percent = p*1d/100d;
            double workDay = (days * 0.9) * 12d;
            double workHours = workDay * percent;
            double work = (int)workHours;

            Console.WriteLine(new string('*',80));
            if (work <= hours)
            {
                Console.WriteLine("No");
                Console.WriteLine(work - hours);
            }
            else
            {
                Console.WriteLine("Yes");
                Console.WriteLine(work - hours);
            }
        }
    }
}
