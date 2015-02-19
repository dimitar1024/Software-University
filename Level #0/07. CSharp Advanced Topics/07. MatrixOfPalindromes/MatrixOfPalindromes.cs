using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main(string[] args)
        {
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            char[] latters = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            for (int row = 0; row < r; row++)
            {
                for (int col = 0; col < c; col++)
                {
                    int middleAlfaBet = row + col;
                    string now = "" + latters[row] + latters[middleAlfaBet] + latters[row];
                    Console.Write("{0} ",now);
                }
                Console.WriteLine();
            }
        }
    }
}
