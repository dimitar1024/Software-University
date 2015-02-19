using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int cols = int.Parse(Console.ReadLine());

            int area = rows*cols;
            double price = 0;
            if (type == "Premiere")
            {
                price = area * 12.00d;
            }
            if (type == "Normal")
            {
                price = area * 7.50d;
            }
            if (type == "Discount")
            {
                price = area * 5.00d;
            }

            Console.WriteLine("{0:f2} leva",price);
        }
    }
}
