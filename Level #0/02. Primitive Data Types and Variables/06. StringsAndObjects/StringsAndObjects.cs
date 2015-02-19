using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringsAndObjects
{
    class StringsAndObjects
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 6.	Strings and Objects");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Declare two string variables and assign them with “Hello” and “World”. Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between). Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).");
            Console.WriteLine(new string('=', 80));

            string hello = "Hello ";
            string world = "World";
            object helloWorld = hello + world;

            Console.WriteLine("Print: {0}",helloWorld);
        }
    }
}
