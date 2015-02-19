using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_BitsInverter
{
    class BitsInverter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of numbers:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter step:");
            int step = int.Parse(Console.ReadLine());
            int mack;
            int info;
            int result;
            // ЗАДАЧАТА Е НЕДОВЪРШЕНА !!!

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                
                for (int j = 0; j <=7; j++)
                {
                    mack = 1 << j;
                    result = number & mack;
                    info = result >> j;
                    int exit;
                    
                    if (info == 1)
                    {
                        mack = 1 << j;
                        exit = number | mack;
                    }
                    if (info == 0)
                    {
                        mack = ~(1 << j);
                        exit = number & mack;
                    }
                    Console.WriteLine(info);
                    Console.WriteLine(exit);
                }
                
            }
        }
    }
}
