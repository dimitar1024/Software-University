using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Eclipse
{
    class Eclipse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n;
            int space = n - 1;
            string spaceStr = new string(' ', space);
            string frame = new string('*', width - 2);
            string elipse = new string('/', width - 2);

            for (int i = 0; i < n; i++)
            {
                if ((i == 0) || (i == n - 1))
                {

                    Console.WriteLine(" {0} {1} {0}", frame, spaceStr);
                }
                if (i == n / 2)
                {
                    string spacedist = new string('-', space);
                    Console.WriteLine("*{0}*{1}*{0}*", elipse, spacedist);
                }
                if ((i != 0) && (i != n - 1) && (i != n / 2))
                {
                    Console.WriteLine("*{0}*{1}*{0}*", elipse, spaceStr);
                }
            }
        }
    }
}

