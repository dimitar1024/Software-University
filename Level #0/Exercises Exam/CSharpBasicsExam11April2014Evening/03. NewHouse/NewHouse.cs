using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int could = 0;
            int roof = 0;

            for (int i = 1; i <= n; i+=2)
            {
                could = (n - i) / 2;
                roof = i;
                string couldStr = new string('-', could);
                string roofStr = new string('*', roof);

                Console.WriteLine("{0}{1}{0}",couldStr,roofStr);
            }
            for (int i = 0; i < n; i++)
            {
                int wall = n - 2;
                string wallStr = new string('*', wall);
                Console.WriteLine("|{0}|",wallStr);
            }
        }
    }
}
