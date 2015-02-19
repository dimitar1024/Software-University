using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ProgrammerDNA
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            char printChar = char.Parse(Console.ReadLine());

            char space = '.';

            int width = 7;
            int middle = width / 2;
            int diff = 0;
            int diffCount = 0;

            for (int row = 0; row < length; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (col >= middle - diff && col <= middle+diff)
                    {
                        Console.Write(printChar);
                        if (printChar =='G')
                        {
                            printChar = 'A';
                        }
                        else
                        {
                            printChar++;
                        }
                    }
                    else
                    {
                        Console.Write(space);
                    }
                }

                if (diffCount >= middle)
                {
                    diff--;
                }
                else
                {
                    diff++;
                }

                diffCount++;

                if (diffCount == width)
                {
                    diffCount = 0;
                    diff++;
                }
                Console.WriteLine();
            }
        }
    }

