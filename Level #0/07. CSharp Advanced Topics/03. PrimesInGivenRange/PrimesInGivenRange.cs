using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.PrimesInGivenRange
{
    class PrimesInGivenRange
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            List<int> range = FindPrimesInRange(num1, num2);
            
            foreach (var numbs in range)
            {
                Console.Write("{0} ", numbs);
            }
            if (range.Count == 0)
            {
                Console.WriteLine("(empty list)");
            }
            
            
        }

        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
           
            List<int> primeNumbers = new List<int>();
            for (int i = startNum; i <= endNum; i++)
            {
                if (i == 1)
                {
                    continue;
                }
                if ((i % 2 != 0) && (i % 3 != 0) && (i % 5 != 0) && (i % 7 != 0) || (i == 1) || (i == 2) || (i == 3) || (i == 5) || (i == 7))
                {
                    primeNumbers.Add(i);
                    
                }
            }
            

            return primeNumbers;
        }
    }
}
