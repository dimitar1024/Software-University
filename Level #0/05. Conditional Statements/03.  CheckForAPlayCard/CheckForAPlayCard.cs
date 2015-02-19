using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 3.	Check for a Play Card");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Classical play cards use the following signs to designate the card face: 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter card:");
            string card = Console.ReadLine();

            switch (card)
            {
                case "2":
                case "3":
                case "4":
                case "5":
                case "6":
                case "7":
                case "8":
                case "9":
                case "10":
                case "j":
                case "J":
                case "Q":
                case "q":
                case "k":
                case "K":
                case "a":
                case "A":
                    Console.WriteLine("yes");
                    break;
                default:
                    Console.WriteLine("no");
                    break;
            }
        }
    }
}
