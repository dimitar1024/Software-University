using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 12.	Null Values Arithmetic");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Create a program that assigns null values to an integer and to a double variable. Try to print these variables at the console. Try to add some number or the null literal to these variables and print the result.");
            Console.WriteLine(new string('=', 80));

            int? number1 = 123;
            double? number2 = null;
            int? number3 = 546;
            double? number4 = 43.22344;
            int? number5 = null;
            double? number6 = null;
            int? number7 = 24;
            double? number8 = 57346.35764334;
            int? number9 = null;
            double? number10 = 744.76763;
            
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}",number1,number2,number3,number4,number5,number6,number7,number8,number9,number10);

        }
    }
}
