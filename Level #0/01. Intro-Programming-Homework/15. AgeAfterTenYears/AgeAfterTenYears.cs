using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.AgeAfterTenYears
{
    class AgeAfterTenYears
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 15.	* Age after 10 Years");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter your years: ");
            int year = int.Parse(Console.ReadLine());
            int afterTenYear = year + 10;
            Console.WriteLine("Your age after 10 years is: " + afterTenYear);
        }
    }
}
