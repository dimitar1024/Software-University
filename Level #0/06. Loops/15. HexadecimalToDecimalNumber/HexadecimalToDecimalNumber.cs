using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.HexadecimalToDecimalNumber
{
    class HexadecimalToDecimalNumber
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();// за да може всички букви в стринга да са големи. :)
            long decNumber = 0;
            long power = 1;
            for (int i = input.Length-1; i >= 0; i--)
            {
                int num;
                // switch-a е за заместване на буквите с числа 
                switch (input[i])
                {
                    case 'A': num = 10; break;
                    case 'B': num = 11; break;
                    case 'C': num = 12; break;
                    case 'D': num = 13; break;
                    case 'E': num = 14; break;
                    case 'F': num = 15; break;
                    default: num = (int)input[i] - 48;
                        break;
                }
                // в decNumber се събират числата от алгоритъма за преминаване от 16-на към 10-на система.
                // index0 x 16^0 + index1 x 16^1 + index2 x 16^2 + index3 x 16^3 + index4 x 16^4 и така нататък :)
                decNumber = decNumber + (num * power);
                // променливата power в началото на цикъла е със стойност 1, защото което и да е число на нулева степен е единица.
                // но за следващото завъртане на цикъла е необходимо числото да се променя 
                // 16^1 = 16 16^2 = 256 и т.н затова се присвоява умножение с 16 на всяко ново завъртане.
                power = power * 16;
            }
            Console.WriteLine(decNumber);
        }
    }
}
