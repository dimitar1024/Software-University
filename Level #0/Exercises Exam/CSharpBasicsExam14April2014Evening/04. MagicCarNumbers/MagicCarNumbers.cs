using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MagicCarNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[] latters = { 'A', 'B', 'C', 'E', 'H', 'K', 'M', 'P', 'T', 'X' };
            int[] numbers = { 10, 20, 30, 50, 80, 110, 130, 160, 200, 240 };
            int count = 0;
            int sum = 0;
            string now = "";
            int dontreverse = 0;

            for (int i1 = 0; i1 <= 9; i1++)
            {
                for (int i2 = 0; i2 <= 9; i2++)
                {
                    for (int i3 = 0; i3 <= 9; i3++)
                    {
                        for (int i4 = 0; i4 <= 9; i4++)
                        {

                            if (i3 != i4)
                            {
                                if (n ==(sum = numbers[2] + numbers[0] + i3 + i3 + i3 + i4 + numbers[i1] + numbers[i2]))
                                {
                                    count++;
                                    now = "" + latters[2] + latters[0] + i3 + i3 + i3 + i4 + latters[i1] + latters[i2];
                                    Console.WriteLine(now);
                                }
                                if (n==(sum = numbers[2] + numbers[0] + i3 + i4 + i4 + i4 + numbers[i1] + numbers[i2]))
                                {
                                    count++;
                                    now = "" + latters[2] + latters[0] + i3 + i4 + i4 + i4 + latters[i1] + latters[i2];
                                    Console.WriteLine(now);
                                }
                                if (n==(sum = numbers[2] + numbers[0] + i3 + i3 + i4 + i4 + numbers[i1] + numbers[i2]))
	                            {
                                    count++;
                                    now = "" + latters[2] + latters[0] + i3 + i3 + i4 + i4 + latters[i1] + latters[i2];
                                    Console.WriteLine(now);
	                            }
                                if (n==(sum = numbers[2] + numbers[0] + i3 + i4 + i3 + i4 + numbers[i1] + numbers[i2]))
                                {
                                    count++;
                                    now = "" + latters[2] + latters[0] + i3 + i4 + i3 + i4 + latters[i1] + latters[i2];
                                    Console.WriteLine(now);
                                }
                                if (n==(sum = numbers[2] + numbers[0] + i3 + i4 + i4 + i3 + numbers[i1] + numbers[i2]))
	                            {
                                    count++;
                                    now = "" + latters[2] + latters[0] + i3 + i4 + i4 + i3 + latters[i1] + latters[i2];
                                    Console.WriteLine(now);
	                            }
                            }
                            
                                                
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
                        
    }
    

