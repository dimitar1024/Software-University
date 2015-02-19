using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.BankAccountData
{
    class BankAccountData
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 11.	Bank Account Data");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter middle name: ");
            string middleName = Console.ReadLine();
            Console.WriteLine("Enter last  name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Money : ");
            int money = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bank name: ");
            string bankName = Console.ReadLine();
            Console.WriteLine("Enter IBAN: ");
            string iban = Console.ReadLine();
            Console.WriteLine("Enter number on first credit card: format(16-digit)");
            string firstCardStr = Console.ReadLine();
            long firstCard = long.Parse(firstCardStr);
            Console.WriteLine("Enter number on second credit card: format(16-digit)");
            string secondCardStr = Console.ReadLine();
            long secondCard = long.Parse(secondCardStr);
            Console.WriteLine("Enter number on third credit card: format(16-digit)");
            string thirdCardStr = Console.ReadLine();
            long thirdCard = long.Parse(thirdCardStr);


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Your acount is create!");
            Console.ResetColor();
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("   Welcome Mr/Ms " + lastName);
            Console.WriteLine();
            Console.WriteLine("           Name: " + firstName);
            Console.WriteLine("    Middle name: " + middleName);
            Console.WriteLine("      Last name: " + lastName);
            Console.WriteLine("          Money: " + money + " лв");
            Console.WriteLine("      Bank name: " + bankName);
            Console.WriteLine("           IBAN: " + iban);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("First credit card: ");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Number on card: ");
            if (firstCardStr.Length != 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR! ");
                Console.ResetColor();
                Console.Write("Please enter 16-digit number");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0:0000 0000 0000 0000}", firstCard);
            }
            Console.WriteLine();
            Console.WriteLine("Second credit card: ");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Number on card: ");
            if (secondCardStr.Length != 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR! ");
                Console.ResetColor();
                Console.Write("Please enter 16-digit number");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0:0000 0000 0000 0000}", secondCard);
            }
            Console.WriteLine();
            Console.WriteLine("Third credit card: ");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine("Number on card: ");
            if (thirdCardStr.Length != 16)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("ERROR! ");
                Console.ResetColor();
                Console.Write("Please enter 16-digit number");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("{0:0000 0000 0000 0000}", thirdCard);
            }
        }
    }
}
