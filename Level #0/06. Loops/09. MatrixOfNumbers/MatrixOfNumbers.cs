using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.MatrixOfNumbers
{
    class MatrixOfNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numNow = 0;

            if (n<=20)
            {
                // forа с променлива row отговаря за броя редове.
                for (int row = 0; row < n; row++)
                {
                    // фора с променлива col отговаря за числата на реда и понеже в примера матрицата започва от 1 следователно трябва да започне цикъла от 1;
                    for (int col = 1; col <= n; col++)
                    {
                        numNow = col + row;
                        Console.Write("{0,-3}",numNow);
                    }
                    Console.WriteLine();
                }

            }
        }
    }
}
