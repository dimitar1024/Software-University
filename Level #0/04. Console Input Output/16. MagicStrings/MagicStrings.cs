using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.MagicStrings
{
    class MagicStrings
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 16.	** – Magic Strings");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 3 of C# Basics exam from 11-04-2014 Morning.  You can test your solution here .
You are given a number diff. Write a program to generate all sequences of 8 laetters, each from the set { 's', 'n', 'k', 'p' }, such that the weight of the first 4 letters differs from the weight of the second 4 letters exactly by diff. These sequences are called “magic strings”. Print them in alphabetical order.
The weight of a single letter is calculated as follows:  weight('s') = 3; weight('n') = 4;  weight('k') = 1;  weight('p') = 5. The weight of a sequence of 4 letters is the calculated as sum of the weights of these 4 individual letters.
");
            Console.WriteLine(new string('=', 80));

            Console.WriteLine("Enter diff:");
            int diff = int.Parse(Console.ReadLine());
            char[] symbols = {'k', 'n', 'p', 's'};
            int results = 0;

            for (int d1 = 0; d1 < symbols.Length; d1++)
			{
                for (int d2 = 0; d2 < symbols.Length; d2++)
                {
                    for (int d3 = 0; d3 < symbols.Length; d3++)
                    {
                        for (int d4 = 0; d4 < symbols.Length; d4++)
                        {
                            string left = "" + symbols[d1] + symbols[d2] + symbols[d3] + symbols[d4];
                            int weightLeft = Calculator(left);
                            
                            for (int d5 = 0; d5 < symbols.Length; d5++)
                            {
                                for (int d6 = 0; d6 < symbols.Length; d6++)
                                {
                                    for (int d7 = 0; d7 < symbols.Length; d7++)
                                    {
                                        for (int d8 = 0; d8 < symbols.Length; d8++)
                                        {
                                            string right = "" + symbols[d5] + symbols[d6] + symbols[d7] + symbols[d8];
                                            int weigtRight = Calculator(right);
                                            if (Math.Abs(weightLeft - weigtRight) == diff)
                                            {
                                                Console.WriteLine(left + right);
                                                results++;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
			}
            if (results == 0)
            {
                Console.WriteLine("No");
            }
        }
        private static int Calculator(string str)
        {
            int weight = 0;
            foreach (var ch in str)
            {
                switch (ch)
                {
                    case 'k': weight += 1; 
                        break;
                    case 's': weight += 3;
                        break;
                    case 'n': weight += 4;
                        break;
                    case 'p': weight += 5;
                        break;
                }
            }
            return weight;
        }
    }
}
