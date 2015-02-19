using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NestedLoops
{
    class NestedLoops
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int bill = int.Parse(Console.ReadLine());
            int cow = int.Parse(Console.ReadLine());

            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = (number % 10);
            

            for (int i = 9900; i <=9999; i++)
            {
                int a1 = i / 1000;
                int a2 = (i / 100) % 10;
                int a3 = (i / 10) % 10;
                int a4 = (i % 10);
                int[] arrOfNumber = new int[4];
                arrOfNumber[0] = a1;
                arrOfNumber[1] = a2;
                arrOfNumber[2] = a3;
                arrOfNumber[3] = a4;
                int bills = 0;
                int cows = 0;
                if (a1 == a)
                {
                    bills++;
                }
                else if (a2 == b)
                {
                    bills++;
                }
                else if (a3 == c)
                {
                    bills++;
                }
                else if (a4 == d)
                {
                    bills++;
                }
                int fn = Array.IndexOf(arrOfNumber, a);
                int sn = Array.IndexOf(arrOfNumber, b);
                int tn = Array.IndexOf(arrOfNumber, c);
                int fourn = Array.IndexOf(arrOfNumber, d);
                
                
                if (fn !=-1)
                {
                    cows++;
                }
                else if (sn !=-1)
                {
                    cows++;
                }
                else if (tn != -1)
                {
                    cows++;
                }
                else if (fourn != -1)
                {
                    cows++;
                }

                if ((cow == cows)&&(bills == bill))
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("" + fourn + " i:" + i + " bills:" + bills + " cows: "+ cows);
                            
            }
        }
    }
}
