using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.SortingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            for (int i = 0; i < n; i++)
            {
                string num = Console.ReadLine();
                numbers[i] = int.Parse(num);
            }


            
             int[] sort = SortNumbers(numbers);
             foreach (var el in sort)
             {
                 Console.WriteLine(el);
             }
        }

        static int[] SortNumbers(int[] numbersArr)
        { 
            List<int> nums = numbersArr.ToList();
            nums.Sort();
            int[] exit = nums.ToArray();
            
            return exit;
        }
    }
}

