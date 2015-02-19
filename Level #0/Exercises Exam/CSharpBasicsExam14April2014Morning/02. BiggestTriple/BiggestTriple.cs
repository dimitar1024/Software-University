using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BiggestTriple
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] separators = { ' ' };
            string[] numbers = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            int index = 0;
            int maxSum = Int32.MinValue;
            int start = 0;

            while (index < numbers.Length)
            {
                int num1 = int.Parse(numbers[index]);
                int num2 = 0;
                if (index+1 < numbers.Length)
                {
                    num2 = int.Parse(numbers[index + 1]);
                }
                int num3 = 0;
                if (index + 2 < numbers.Length)
                {
                    num3 = int.Parse(numbers[index + 2]);
                }

                int sum = num1 + num2 + num3;
                if (sum > maxSum)
                {
                    maxSum = sum;
                    start = index;
                }
                index = index + 3;
            }

            while (maxSum !=0)
            {
                Console.Write(numbers[start] + " ");
                maxSum = maxSum - int.Parse(numbers[start]);
                start++;

                
            }


            
            
        }
    }

