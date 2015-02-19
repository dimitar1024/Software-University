using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.ExchangeVariableValues
{
    class ExchangeVariableValues
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 9.	Exchange Variable Values");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic. Print the variable values before and after the exchange.");
            Console.WriteLine(new string('=', 80));

            int a = 5;
            int b = 10;
            int rotation;

            rotation = b;
            b = a;
            a = rotation;

            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
        }
    }
}
