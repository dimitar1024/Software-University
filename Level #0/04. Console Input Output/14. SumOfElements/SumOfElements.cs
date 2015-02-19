using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.SumOfElements
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 14.	**– Sum of Elements");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
You are given n numbers. Find an element that is equal to the sum of all of the other elements.
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter sequence of integers stays (numbers separated one from another by a space)");
            string numStr = Console.ReadLine();
            string[] numbersArr = numStr.Split(' ');
            int greater = int.Parse(numbersArr[0]); 
            int sum = 0;
            for (int i = 0; i < numbersArr.Length; i++)
			{
			    if (greater < int.Parse(numbersArr[i]))
	            {
		            greater = int.Parse(numbersArr[i]);
	            }
			}
            for (int i = 0; i < numbersArr.Length; i++)
            {

                sum += int.Parse(numbersArr[i]);
            }
            sum -= greater;
            if (greater == sum)
            {
                Console.WriteLine("Yes, sum={0}",sum);
            }
            else
            {
                int diff = greater - sum;
                Console.WriteLine("No, diff{0}",diff);
            }
        }
    }
}
