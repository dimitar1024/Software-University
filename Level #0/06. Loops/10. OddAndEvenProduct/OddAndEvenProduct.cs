using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.OddAndEvenProduct
{
    class OddAndEvenProduct
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] separators = { ' ' }; 
            string[] nums = input.Split(separators,StringSplitOptions.RemoveEmptyEntries);
            int[] numbers = new int[nums.Length];

            for (int convert = 0; convert < nums.Length; convert++)
            {
                numbers[convert] = int.Parse(nums[convert]);
            }
            
            int productOdd = 1;
            int productEven = 1;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i%2==0)
                {
                    productOdd *= numbers[i];
                }
                if (!(i%2==0))
                {
                    productEven *= numbers[i];
                }
            }


            if (productEven == productOdd)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = {0}",productOdd);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd product = {0}",productOdd);
                Console.WriteLine("even product = {0}",productEven);
            }
            
        }
    }
}
