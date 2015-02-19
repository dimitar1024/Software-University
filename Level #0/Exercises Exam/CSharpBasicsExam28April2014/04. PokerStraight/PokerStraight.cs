using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PokerStraight
{
    class PokerStraight
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int card1 = 0; card1 < 10; card1++)
            {
                for (int suit1 = 0; suit1 < 4; suit1++)
                {
                    for (int suit2 = 0; suit2 < 4; suit2++)
                    {
                        for (int suit3 = 0; suit3 < 4; suit3++)
                        {
                            for (int suit4 = 0; suit4 < 4; suit4++)
                            {
                                for (int suit5 = 0; suit5 < 4; suit5++)
                                {
                                    sum = 10 * (card1+1) + suit1 + 1+
                                          20 * (card1+2) + suit2 + 1+
                                          30 * (card1+3) + suit3 + 1+
                                          40 * (card1+4) + suit4 + 1+
                                          50 * (card1+5) + suit5 + 1;
                                    if (sum == number)
                                    {
                                        counter++;
                                    }
                                }
                            }
                        }
                    }   
                }
            }
            Console.WriteLine(counter);
            
        }
    }
}
