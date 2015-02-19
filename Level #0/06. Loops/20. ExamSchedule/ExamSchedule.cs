using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.ExamSchedule
{
    
    class ExamSchedule
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinutes = int.Parse(Console.ReadLine());
            string partOfDay = Console.ReadLine();
            int endHour = int.Parse(Console.ReadLine());
            int endMinutes = int.Parse(Console.ReadLine());

            int hours = startHour + endHour;
            int minutes = startMinutes + endMinutes;

            if (minutes > 59)
            {
                hours += 1;
                minutes = minutes - 60;
            }
            if (hours >=12)
            {
                if (partOfDay =="PM")
                {
                    partOfDay = "AM";
                }
                else
                {
                    partOfDay = "PM";
                }

                switch (hours)
                {
                    case 13: hours = 01; break;
                    case 14: hours = 02; break;
                    case 15: hours = 03; break;
                    case 16: hours = 04; break;
                    case 17: hours = 05; break;
                    case 18: hours = 06; break;
                    case 19: hours = 07; break;
                    case 20: hours = 08; break;
                    case 21: hours = 09; break;
                    case 22: hours = 10; break;
                    case 23: hours = 11; break;
                    case 24: hours = 12; break;

                }
            }
            Console.WriteLine("{0}:{1}:{2}",hours.ToString("00"),minutes.ToString("00"),partOfDay);
        }
    }
}
