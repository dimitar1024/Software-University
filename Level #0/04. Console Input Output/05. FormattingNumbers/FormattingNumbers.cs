using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.FormattingNumbers
{
    class FormattingNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 5.	Formatting Numbers");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that reads 3 numbers: an integer a (0 ≤ a ≤ 500), a floating-point b and a floating-point c and prints them in 4 virtual columns on the console. Each column should have a width of 10 characters. The number a should be printed in hexadecimal, left aligned; then the number a should be printed in binary form, padded with zeroes, then the number b should be printed with 2 digits after the decimal point, right aligned; the number c should be printed with 3 digits after the decimal point, left aligned. ");
            Console.WriteLine(new string('=', 80));
            
            Console.WriteLine("Enter a:");
            int a = int.Parse(Console.ReadLine().PadRight(10, ' '));
            string aStrBinary = Convert.ToString(a, 2).PadLeft(10, '0');
            Console.WriteLine("Enter b:");
            double b = double.Parse(Console.ReadLine().PadRight(10, ' '));

            Console.WriteLine("Enter c:");
            double c = double.Parse(Console.ReadLine().PadRight(10, ' '));
            Console.WriteLine("{0,-10:X}|{1}|{2,10:f2}|{3,-10:f3}|", a, aStrBinary, b, c);
        }
    }
}
