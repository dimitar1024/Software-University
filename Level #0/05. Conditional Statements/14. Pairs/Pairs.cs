using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Pairs
{
    class Pairs
    {
        static void Main()
        {
            Console.WriteLine("Problem 14.	* – Pairs");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"You are given 2*N elements (even number of integer numbers). The first and the second element form a pair, the third and the fourth element form a pair as well, etc. Each pair has a value, calculated as the sum of its two elements. Your task is to write a program to check whether all pairs have the same value or print the max difference between two consecutive values.");
            Console.WriteLine(new string('=', 80));

            string input = Console.ReadLine().Trim();
            char[] separators = new char[] { '\r', '\n',',',' ',':'};
            string[] inputToArr = input.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[inputToArr.Length];
            for (int i = 0; i < inputToArr.Length; i++)
            {
                numbers[i] = int.Parse(inputToArr[i]);
            }
            int maxDiff = 0;
            bool equal = true;

            int pair = numbers[0] + numbers[1];

            for (int j = 0; j < numbers.Length -1; j+=2)
            {
                if (numbers[j]+numbers[j+1]!=pair)
                {
                    equal = false;
                    int diff = Math.Abs((numbers[j] + numbers[j + 1]) - pair);
                    if (diff > maxDiff)
                    {
                        maxDiff = diff;
                    }
                    pair = numbers[j] + numbers[j + 1];
                }
            }

            if (equal)
            {
                Console.WriteLine("Yes, value={0}",pair);
            }
            else
            {
                Console.WriteLine("No, maxdiff={0}",maxDiff);
            }

            


        }
    }
}
