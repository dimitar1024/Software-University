using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_VariableInHexadecimalFormat
{
    class VariableInHexadecimalFormat
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 3.	Variable in Hexadecimal Format");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##). Use Windows Calculator to find its hexadecimal representation. Print the variable and ensure that the result is “254”.");
            Console.WriteLine(new string('=', 80));

            int number = 254;
            Console.WriteLine("Number in Hexadecimal format is: 0x{0:x}",number);
            Console.WriteLine("Enter your number: ");
            int enterNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Your number in Hexadecimal format is: 0x{0:x}", enterNumber);
        }
    }
}
