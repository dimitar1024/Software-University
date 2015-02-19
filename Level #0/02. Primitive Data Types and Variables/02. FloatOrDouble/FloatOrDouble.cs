using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.FloatOrDouble
{
    class FloatOrDouble
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 2.	Float or Double?");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091? Write a program to assign the numbers in variables and print them to ensure no precision is lost.");
            Console.WriteLine(new string('=', 80));

            double firstNum = 34.567839023d; 
            float secondNum = 12.345f;
            double thirdNum = 8923.1234857d; 
            float fourthNum = 3456.091f;

            Console.WriteLine("The numbers are:");
            Console.WriteLine("double: {0} \r\n float: {1} \r\ndouble: {2} \r\n float: {3}",firstNum,secondNum,thirdNum,fourthNum);
        }
    }
}
