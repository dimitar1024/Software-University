using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Illuminati
{
    class Illuminati
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            int sum = 0;
            int count = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A')
                {
                    sum += 65;
                    count++;
                }
                if (input[i] == 'E')
                {
                    sum += 69;
                    count++;
                }
                if (input[i] == 'I')
                {
                    sum += 73;
                    count++;
                }
                if (input[i] == 'O')
                {
                    sum += 79;
                    count++;
                }
                if (input[i] == 'U')
                {
                    sum += 85;
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.WriteLine(sum);
        }
    }
}
