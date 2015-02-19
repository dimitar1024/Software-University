using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MorseCodeNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] numbers = { "-----", ".----", "..---", "...--", "....-", "-----"};

            int a = n / 1000;
            int b = (n / 100) % 10;
            int c = (n / 10) % 10;
            int d = (n/1) % 10;

            bool isFound = false;
            int sum = a + b + c + d;

            for (int i1 = 0; i1 <=5; i1++)
            {
                for (int i2 = 0; i2 <=5; i2++)
                {
                    for (int i3 = 0; i3 <=5; i3++)
                    {
                        for (int i4 = 0; i4 <=5; i4++)
                        {
                            for (int i5 = 0; i5 <=5; i5++)
                            {
                                for (int i6 = 0; i6 <=5; i6++)
                                {
                                    int morze = i1 * i2 * i3 * i4 * i5 * i6; 
                                    if (morze==sum)
                                    {
                                        Console.WriteLine("{0}|{1}|{2}|{3}|{4}|{5}|", numbers[i1], numbers[i2], numbers[i3], numbers[i4], numbers[i5], numbers[i6]);
                                        isFound = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (!isFound)
            {
                Console.WriteLine("No");
            }

        }
    }

