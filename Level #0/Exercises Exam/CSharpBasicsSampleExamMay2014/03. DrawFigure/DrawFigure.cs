using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.DrawFigure
{
    class DrawFigure
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int clock;
            int could;
            int price = n;
            string clockStr = "";
            string couldStr = "";
            int divider = (n + 1) / 2;
            for (int i = price; i > 0; i-=2)
            {
                clock = i;
                could = (n - i) / 2;
                couldStr = new string('.', could);
                clockStr = new string('*', clock);
                Console.Write(couldStr);
                Console.Write(clockStr);
                Console.WriteLine(couldStr);
            }
            for (int i = 1; i <= price; i += 2)
            {
                if (i != 1)
                {
                    clock = i;
                    could = (n - i) / 2;
                    couldStr = new string('.', could);
                    clockStr = new string('*', clock);
                    Console.Write(couldStr);
                    Console.Write(clockStr);
                    Console.WriteLine(couldStr);
                }
            }
        }
    }
}
