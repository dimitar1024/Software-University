using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MelonsAndWatermelons
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int watermelon = 0;
            int melon = 0;
            int endfor = day + end;
            int diff = 0;

            for (int i = day; i < endfor; i++)
            {
                
                switch (i%7)
                {
                    case 1: watermelon += 1;
                        break;
                    case 2: melon += 2;
                        break;
                    case 3: watermelon += 1;
                        melon += 1;
                        break;
                    case 4: watermelon += 2;
                        break;
                    case 5: watermelon += 2;
                        melon += 2;
                        break;
                    case 6: watermelon += 1;
                        melon += 2;
                        break;

                }
            }

            if (watermelon == melon)
            {
                Console.WriteLine("Equal amount: {0}",watermelon);
            }
            else if (watermelon > melon)
            {
                diff = Math.Abs(watermelon - melon);
                Console.WriteLine("{0} more watermelons",diff);
            }
            else if(melon > watermelon)
            {
                diff = Math.Abs(melon - watermelon);
                Console.WriteLine("{0} more melons",diff);
            }

        }
    }

