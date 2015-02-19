using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.DifferenceBetweenDates
{
    class DifferenceBetweenDates
    {
        static void Main(string[] args)
        {
            //input
            Console.WriteLine("Pleace enter start and end dates in format (dd.MM.yyyy)");
            Console.WriteLine("Enter start date:");
            string inputStart = Console.ReadLine();
            Console.WriteLine("Enter end date:");
            string inputEnd = Console.ReadLine();
            //output
            double days = DifferenceBetweenDates(inputStart,inputEnd);
            Console.WriteLine(days);
       }
            
            static double DifferenceBetweenDates(string start, string end) 
            {
            string[] startArr = start.Split('.');
            int sDay = int.Parse(startArr[0]);
            int sMouth = int.Parse(startArr[1]);
            int sYear = int.Parse(startArr[2]);

            string[] endArr = end.Split('.');
            int eDay = int.Parse(endArr[0]);
            int eMouth = int.Parse(endArr[1]);
            int eYear = int.Parse(endArr[2]);
            
            
            
            DateTime diffStart = new DateTime(sYear, sMouth,sDay);
            DateTime diffEnd = new DateTime(eYear, eMouth, eDay);

            double diffDay = diffEnd.Subtract(diffStart).TotalDays;
           return diffDay;
        }
    }
}
