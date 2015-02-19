using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 14.	* Print the ASCII Table");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Find online more information about ASCII (American Standard Code for Information Interchange) and write a program to prints the entire ASCII table of characters at the console (characters from 0 to 255). Note that some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently. You may need to use for-loops (learn in Internet how).");
            Console.WriteLine(new string('=', 80));

            for (int i = 0; i <= 255; i++)
            {
                char sym = (char)i;
                Console.WriteLine("The symbol in position {0} is:  {1}",i,sym);
            }
        }
    }
}
