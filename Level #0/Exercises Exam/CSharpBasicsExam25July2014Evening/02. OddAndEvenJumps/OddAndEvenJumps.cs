using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class OddAndEvenJumps
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower().Replace(" ","");
            int OddJump = int.Parse(Console.ReadLine());
            int EvenJump = int.Parse(Console.ReadLine());
            ulong oddsum = 0;
            ulong evensum = 0;
            int oddCounter = 0;
            int evenCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (i%2==0)
                {
                    oddCounter++;
                    if (oddCounter % OddJump==0)
                    {
                        oddsum *= input[i];
                    }
                    else
                    {
                        oddsum += input[i];
                    }
                }

            }

            Console.WriteLine("Odd: {0:X}",oddsum);


            for (int i = 0; i < input.Length; i++)
            {
                if (i % 2 != 0)
                {
                    evenCounter++;
                    if (evenCounter % EvenJump == 0)
                    {
                        evensum *= input[i];
                    }
                    else
                    {
                        evensum += input[i];
                    }
                }

            }

            Console.WriteLine("Even: {0:X}", evensum);

        }
    }

