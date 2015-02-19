using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 6.	Four-Digit Number");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits (in our example 2+0+1+1 = 4).
•	Prints on the console the number in reversed order: dcba (in our example 1102).
•	Puts the last digit in the first position: dabc (in our example 1201).
•	Exchanges the second and the third digits: acbd (in our example 2101).
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter your number");
            int number = int.Parse(Console.ReadLine());
            int a = number / 1000;
            int b = (number / 100) % 10;
            int c = (number / 10) % 10;
            int d = number % 10;
            int sum = a + b + c + d;
            int reverse = d * 1000 + c * 100 + b * 10 + a;
            int dabc = d * 1000 + a * 100 + b * 10 + c;
            int acbd = a * 1000 + c * 100 + b * 10 + d;

            Console.WriteLine("SUM of digit on your number is: " + sum);
            Console.WriteLine("Reverse on your number is: " + reverse);
            Console.WriteLine("format \"dabc\" in your format is: " + dabc);
            Console.WriteLine("Format \"acbd\" in your format is: " + acbd);
        }
    }
}
