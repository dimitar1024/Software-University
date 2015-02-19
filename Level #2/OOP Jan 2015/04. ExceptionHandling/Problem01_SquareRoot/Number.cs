using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_SquareRoot
{
    public class Number
    {
        public static void GetSquareRoot(double number) 
        {
            try
            {
                if (number < 0)
                {
                    throw new ArgumentOutOfRangeException("The input number is negative. Try again!");
                }

                double sqrt = Math.Sqrt(number);
                Console.WriteLine(string.Format("{0:f2}",sqrt));
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                Console.WriteLine("Good Bye");
            }     
        }
    }
}
