using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.OddEvenElements
{
    class OddEvenElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] nums = input.Split(' ');
            double[] numbers = new double[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                numbers[i] = double.Parse(nums[i]);
            }

            double oddSum = 0;
            double oddMin = 0;
            double oddMax = 0;
            double evenSum = 0;
            double evenMin = 0;
            double evenMax = 0;
            double counterOdd = 0;
            double counterEven = 0;

            for (int j = 0; j < numbers.Length; j++)
            {
                if (j % 2 == 0)
                {
                    if (j == 0)
                    {
                        oddMin = numbers[0];
                        oddMax = numbers[0];
                    }
                    oddSum += numbers[j];
                    if (numbers[j] > oddMax)
                    {
                        oddMax = numbers[j];
                    }
                    if (numbers[j] < oddMin)
                    {
                        oddMin = numbers[j];
                    }
                    counterOdd++;
                }
                else
                {
                    if (j == 1)
                    {
                        evenMin = numbers[1];
                        evenMax = numbers[1];

                    }
                    evenSum += numbers[j];
                    if (numbers[j] > evenMax)
                    {
                        evenMax = numbers[j];
                    }
                    if (numbers[j] < evenMin)
                    {
                        evenMin = numbers[j];
                    }
                    counterEven++;
                }
            }

            if (counterEven != 0)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum={3}, EvenMin={4}, EvenMax={5}", oddSum, oddMin, oddMax, evenSum, evenMin, evenMax);
            }
            if (counterEven == 0)
            {
                Console.WriteLine("OddSum={0}, OddMin={1}, OddMax={2}, EvenSum=No, EvenMin=No, EvenMax=No", oddSum, oddMin, oddMax);

            }
        }
    }
}
