using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.PlayWithIntDoubleAndString
{
    class PlayWithIntDoubleAndString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 9.	Play with Int, Double and String");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that, depending on the user’s choice, inputs an int, double or string variable. If the variable is int or double, the program increases it by one. If the variable is a string, the program appends " * " at the end. Print the result at the console. Use switch statement. ");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine(@"Please choose a type:
1 --> int
2 --> double
3 --> string
            ");
            int n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Please enter a int:");
                    int numberInt = int.Parse(Console.ReadLine());
                    numberInt = numberInt + 1;
                    Console.WriteLine(numberInt);
                    break;
                case 2:
                    Console.WriteLine("Please enter a double:");
                    double numberDouble = double.Parse(Console.ReadLine());
                    numberDouble = numberDouble + 1d;
                    Console.WriteLine(numberDouble);
                    break;
                case 3:
                    Console.WriteLine("Please enter a string:");
                    string numberStr = Console.ReadLine();
                    Console.WriteLine(numberStr + "*");
                    break;
                default:
                    break;
            }

        }
    }
}
