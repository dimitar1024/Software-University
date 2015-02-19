using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SumOfElements
{
    class SumOfElements
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] arr = input.Split(' ');
            int[] numbers = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                numbers[i] = int.Parse(arr[i]); 
            }

            int max = numbers.Max();
            int sum = 0;

            for (int k = 0; k < arr.Length; k++)
            {
                sum += numbers[k];
            }

            sum = sum - max;

            if (sum == max)
            {
                Console.WriteLine("Yes,sum={0}",sum);
            }
            else
            {
                int diff =Math.Abs(max-sum);
                Console.WriteLine("No,diff={0}",diff);
            }
        }
    }
}
