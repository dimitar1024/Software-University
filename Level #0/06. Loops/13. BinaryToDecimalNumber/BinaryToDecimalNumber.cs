using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.BinaryToDecimalNumber
{
    class BinaryToDecimalNumber
    {
        static void Main(string[] args)
        {
            string inputBits = Console.ReadLine();
            long newNumber = 0;

            for (int i = 0; i < inputBits.Length; i++)
            {
                // това с дължината на стринга минус брояча и минус 1 е за да се направи reverse на стринга.
                if (inputBits[inputBits.Length-i-1] == '0')
                {
                    continue;
                }

                newNumber += (long)Math.Pow(2,i);
            }

            Console.WriteLine(newNumber);
            
        }
    }
}
