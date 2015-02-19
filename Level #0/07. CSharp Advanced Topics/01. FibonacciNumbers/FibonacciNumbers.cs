using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main(string[] args)
        {
            string input = ""; // заради Scope-а
            while (!(input == "exit"))            //while цикъла го използвам за да може да изпробвате многократно програмата :)
            // За изход от програмата моля напишете exit в конзолата. Затова и съм разделил стринга и парсването към инт.
            // вместо да ползвам int x = int.Parse(Console.ReadLine());
            {
                Console.WriteLine("Enter n:");
                input = Console.ReadLine();
                if (input == "exit")
                {
                    Console.WriteLine();
                    Console.WriteLine("Bye-bye");
                    Console.WriteLine();
                    break;
                }
                int num = int.Parse(input);
                Fib(num);

            }
        }

        static void Fib(int n)
        {

            int firstNumber = 1;
            int secondNumber = 1;
            int nextNumber = firstNumber + secondNumber;
            if (n == 0)
            {
                Console.WriteLine(0);
            }
            if (n == 1)
            {
                Console.WriteLine(firstNumber);
            }
            if (n == 2)
            {
                Console.WriteLine(secondNumber);
            }
            if (n == 3)
            {
                Console.WriteLine(nextNumber);
            }
            if (n > 3)
            {
                for (int i = 3; i <= n; i++)
                {

                    firstNumber = secondNumber;
                    secondNumber = nextNumber;
                    nextNumber = firstNumber + secondNumber;

                }
                Console.WriteLine(nextNumber);
            }
        }
    }
}

