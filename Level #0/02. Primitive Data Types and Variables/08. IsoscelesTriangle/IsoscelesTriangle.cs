using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 8.	Isosceles Triangle");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
                   ©
                  © ©
                 ©   ©
                © © © ©
Note that the © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console. Note also, that under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.
");
            Console.WriteLine(new string('=', 80));

            char symbol = '\u00A9';
            char interval = ' ';

            Console.WriteLine("{0}{0}{0}{1}{0}{0}{0}", interval,symbol);
            Console.WriteLine("{0}{0}{1}{0}{1}{0}{0}", interval, symbol);
            Console.WriteLine("{0}{1}{0}{0}{0}{1}{0}", interval, symbol);
            Console.WriteLine("{1}{0}{1}{0}{1}{0}{1}", interval, symbol);
        }
    }
}
