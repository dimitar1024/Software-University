using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_EnterNumbers
{
    class Number
    {
        public static int ReadNumber(int start, int end)
        {
            int number = 0;
            try
            {
                Console.WriteLine("Enter number between [{0}...{1}]: ", start, end);
                number = int.Parse(Console.ReadLine());
                if (!(start < number && number < end))
                {
                    while (!(start < number && number < end))
                    {
                        Console.WriteLine("Your number is not in range [{0}...{1}] !", start, end);
                        Console.WriteLine("Enter number between [{0}...{1}]: ", start, end);
                        number = int.Parse(Console.ReadLine());
                    }
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid Number!");
            }
            return number;
        }
            
    }

}
