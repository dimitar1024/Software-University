using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int width = 3 * n;
        int height = n + 2;
        int body = n / 2;
        int roof = n / 2;
        int wheels = n / 2 - 1;

        int could = 0;
        int inside = 0;
        string couldStr= "";
        string insideStr = "";
        couldStr = new string('.', n);
        insideStr = new string('*', n);
        Console.WriteLine("{0}{1}{0}",couldStr,insideStr);
        for (int i = 0; i <= n/2-1; i++)
        {
            if (i == n / 2 - 1)
            {
                inside += 2;
                could -= 1;
                couldStr = new string('*', could);
                insideStr = new string('.', inside);
                Console.WriteLine("{0}*{1}*{0}", couldStr, insideStr);
            }
            if (i != n/2-1)
            {
                inside = n + 2 * i;
                could = (width - inside - 2) / 2;
                couldStr = new string('.', could);
                insideStr = new string('.', inside);

                Console.WriteLine("{0}*{1}*{0}", couldStr, insideStr);  
            }
                      

        }

        for (int k = 0; k < (n/2)-2; k++)
        {
            inside = width - 2;
            insideStr = new string('.', inside);
            Console.WriteLine("*{0}*",insideStr);
        }
        Console.WriteLine(new string('*',width));

        for (int j = 0; j < (n / 2) - 1; j++)
        {
            
            int coulds = n / 2;
            int inWheels = n / 2 - 1;
            int underCar = width - coulds * 2 - inWheels * 2 - 4;
            string wheel = new string('.', wheels);
            if (j == ((n / 2) - 2))
            {
                couldStr = new string('.', coulds);
                wheel = new string('*', wheels);
                insideStr = new string('.', underCar);
                Console.WriteLine("{0}*{1}*{2}*{1}*{0}", couldStr, wheel, insideStr);
            }

            if (j != (n / 2) - 2)
            {
                couldStr = new string('.', coulds);

                insideStr = new string('.', underCar);

                Console.WriteLine("{0}*{1}*{2}*{1}*{0}", couldStr, wheel, insideStr);
            }
        }
    }
}
