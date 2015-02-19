using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DeclareVariables
{
    class DeclareVariables
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1.   Declare Variables");
            Console.WriteLine(new string('=',80));
            Console.WriteLine(@"Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong to represent the following values: 52130, -115, 4825932, 97, -10000. Choose a large enough type for each number to ensure it will fit in it. Try to compile the code. Submit the source code of your Visual Studio project as part of your homework submission.
            ");
            Console.WriteLine(new string('=', 80));
            int firstNum = 52130;
            sbyte secondNum = -115;
            int thirdNum = 4825932;
            byte fourthNum =  97;
            short fivethNum = -10000;

            Console.WriteLine("Print numbers:" );
            Console.WriteLine("int " + firstNum);
            Console.WriteLine("sbyte " + secondNum);
            Console.WriteLine("int " + thirdNum);
            Console.WriteLine("byte " + fourthNum);
            Console.WriteLine("short " + fivethNum);

        }
    }
}
