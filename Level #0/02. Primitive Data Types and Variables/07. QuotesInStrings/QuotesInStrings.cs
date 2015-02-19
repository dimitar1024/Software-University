using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 7.	Quotes in Strings");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Declare two string variables and assign them with following value: ""The ""use"" of quotations causes difficulties. "" Do the above in two different ways: with and without using quoted strings. Print the variables to ensure that their value was correctly defined.
");
            Console.WriteLine(new string('=', 80));

            string first = "The \"use\" of quotations causes difficulties.";
            string second = @"The ""use"" of quotations causes difficulties.";

            Console.WriteLine(first);
            Console.WriteLine("Print with quoted strings: "+ second);
        }
    }
}
