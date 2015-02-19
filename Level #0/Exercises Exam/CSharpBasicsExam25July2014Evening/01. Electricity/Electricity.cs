using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Electricity
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int flat = int.Parse(Console.ReadLine());
            string moment = Console.ReadLine().Trim();

            string[] time = moment.Split(':');
            int hour = int.Parse(time[0]);
            int minutes = int.Parse(time[1]);
            int lamps = 0;
            int computers = 0;

            if ((hour>=14 && minutes >= 0) && (hour<=18 && minutes<=59))
            {
                lamps += 2;
                computers += 2;
            }

            if ((hour >= 19 && minutes >= 0) && (hour <= 23 && minutes <= 59))
            {
                lamps += 7;
                computers += 6;
            }

            if ((hour >= 0 && minutes >= 0) && (hour <= 8 && minutes <= 59))
            {
                lamps += 1;
                computers += 8;
            }

            int power = floors * flat;
            int lampsAll = lamps * power;
            int computersAll = computers * power;

            double sum = (lampsAll * 100.53d) + (computersAll * 125.90);

            Console.WriteLine("{0} Watts",(int)sum);

        }
    }

