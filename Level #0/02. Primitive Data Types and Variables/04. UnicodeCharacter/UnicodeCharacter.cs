using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.UnicodeCharacter
{
    class UnicodeCharacter
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 4.	Unicode Character");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the '\u00XX' syntax, and then print it. Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be “*”.");
            Console.WriteLine(new string('=', 80));

            char first = '\u002A';
            Console.WriteLine("Print character: {0}", first);
            
        }
    }
}
