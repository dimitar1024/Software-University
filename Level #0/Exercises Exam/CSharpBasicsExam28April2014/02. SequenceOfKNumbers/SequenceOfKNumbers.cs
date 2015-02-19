using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.SequenceOfKNumbers
{
    class SequenceOfKNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int k = int.Parse(Console.ReadLine());

            string[] num = input.Split(' ');
            int[] numbers = new int[num.Length];
            int count = 0;

            for (int i = 0; i < num.Length; i++)
            {
                numbers[i] = int.Parse(num[i]);
            }

            for (int j= 0; j < numbers.Length; j++)
            {

            }


 
        }
    }
}
