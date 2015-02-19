using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Disk
{
    class Disk
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            int centerX = area / 2;
            int centerY = area / 2;

            for (int row = 0; row < area; row++)
            {
                for (int col = 0; col < area; col++)
                {
                    int printX = col - centerX;
                    int printY = row - centerY;
                    
                    double pointNow = Math.Sqrt(printX * printX + printY * printY);
                    bool pointInRadius = pointNow <= radius;
                    if (pointInRadius)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
