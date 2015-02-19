using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int a = 1; a <= 7; a++)
            {
                for (int b = 1; b <= 7; b++)
                {
                    for (int c = 1; c <= 7; c++)
                    {
                        for (int d = 1; d <= 7; d++)
                        {
                            for (int e= 1; e <= 7; e++)
                            {
                                for (int f = 1; f <= 7; f++)
                                {
                                    for (int g = 1; g <= 7; g++)
                                    {
                                        for (int h = 1; h <= 7; h++)
                                        {
                                            for (int i = 1; i <= 7; i++)
                                            {
                                                int abc = a * 100 + b * 10 + c;
                                                int def = d * 100 + e * 10 + f;
                                                int ghi = g * 100 + h * 10 + i;
                                                if ((ghi - def == diff) && (def - abc == diff))
                                                {
                                                    if (sum == (a + b + c + d + e + f + g + h + i))
                                                    {
                                                        if ((a >= 1) && (a <= 7) && 
                                                            (b >= 1) && (b <= 7) &&
                                                            (c >= 1) && (c <= 7) &&
                                                            (d >= 1) && (d <= 7) &&
                                                            (e >= 1) && (e <= 7) &&
                                                            (f >= 1) && (f <= 7) &&
                                                            (g >= 1) && (g <= 7) &&
                                                            (h >= 1) && (h <= 7) &&
                                                            (i >= 1) && (i <= 7)
                                                            )
                                                        {
                                                            Console.WriteLine("" + a + b + c + d + e + f + g + h + i);
                                                            counter++;
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
