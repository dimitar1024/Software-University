using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SimpleCalculation
    {
        static void Main(string[] args)
        {
            ulong X = ulong.Parse(Console.ReadLine());
            ulong Y = ulong.Parse(Console.ReadLine());

            if (X == 0 && Y == 0)
            {
                Console.WriteLine(0);
            }
            else if (Y == 0)
            {
                Console.WriteLine(6);
            }
            else if (X == 0)
            {
                Console.WriteLine(5);
            }
            else if (X > 0 && Y > 0)
            {
                Console.WriteLine(1);
            }
            else if (X < 0 && Y > 0)
            {
                Console.WriteLine(2);
            }
            else if (X < 0 && Y < 0)
            {
                Console.WriteLine(3);
            }
            else if (X > 0 && Y < 0)
            {
                Console.WriteLine(4);
            }
        }
    }

