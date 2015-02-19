using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.LongestAlphabeticalWord
{
    class LongestAlphabeticalWord
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string words = "" + word + word + word + word;
            int n = int.Parse(Console.ReadLine());
            int maxValue = n*n;

            char[,] matrix = new char[n, n];
            char[] abc = words.ToCharArray();
            int row = 0;
            int col = 0;
            string direction = "right";

            for (int i = 0; i < maxValue; i++)
            {
                if (direction == "right" && (col > n-1))
                {
                    direction = "right";
                    row++;
                    col = col - n; 
                }
                matrix[row, col] = abc[i];

                if (direction == "right")
                {
                    col++;
                }
            }

            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    Console.Write("{0,4}", matrix[r, c]);
                }
                Console.WriteLine();
            }



        }
    }
}
