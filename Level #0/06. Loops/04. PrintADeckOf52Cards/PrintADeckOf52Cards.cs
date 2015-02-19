using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main(string[] args)
        {
            // правим два масива за картите и боята им.
            string[] card = {"1","2","3","4","5","6","7","8","9","10","J","Q","K","A"};
            char[] suit = { '♠', '♥', '♦', '♣' };
            // стинга now ще го използва за конкатинация на карта и боя.
            string now = "";

            // два вложедни цикъла по- малкия отговаря за боята, а другия за картите.
                for (int j = 0; j < 4; j++)
                {
                    for (int i = 0; i < 14; i++)
                    {
                        now = card[i] + suit[j];
                        Console.Write("{0} ",now);
                    }
                    Console.WriteLine();
                }
            
        }
    }
}
