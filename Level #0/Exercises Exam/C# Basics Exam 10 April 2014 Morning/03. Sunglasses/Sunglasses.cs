using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sunglasses
{
    class Sunglasses
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int width = 2 * n;
            string space = "";
                    
            string glass = new string('/', width - 2);

            for (int i = 0; i < n; i++)
            {
                if ((i == 0)||(i == n-1))
                {
                    space = new string(' ', n);
                    string frame = new string('*', width);
                    Console.WriteLine("{0}{1}{0}", frame, space);
                }
                if (i == n/2)
                {
                    
                    space = new string('|', n);
                    Console.WriteLine("*{0}*{1}*{0}*",glass,space);
                }
                if ((i!=0)&&(i!=n/2)&&(i!=n-1))
                {
                    space = new string(' ', n);
                    Console.WriteLine("*{0}*{1}*{0}*", glass, space);
                }
            }

        }
    }
}
