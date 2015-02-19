using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int could = 0;
            int inside = 0;
            char sym = 'A';
            string couldStr = "";
            string insideStr = "";
            for (int i = 0; i < n / 2; i++)
            {
                
                could = i;
                inside = n - 2 * i - 2;
                couldStr = new string('~', could);
                insideStr = new string('#', inside);
                Console.Write(couldStr);
                Console.Write(sym);
                if (sym == 'Z')
                {
                    sym = 'A';
                }
                else
                {
                    sym++;
                }
                
                Console.Write(insideStr);
                Console.Write(sym);
                if (sym == 'Z')
                {
                    sym = 'A';
                }
                else
                {
                    sym++;
                }
                
                Console.WriteLine(couldStr);
            }
            could = n / 2;
            couldStr = new string('~', could);

            Console.Write(couldStr);
            Console.Write(sym);
            Console.WriteLine(couldStr);
            if (sym == 'Z')
            {
                sym = 'A';
            }
            else
            {
                sym++;
            }


            could = 0;
            inside = 0;
            for (int i = n/2-1; i >= 0; i++)
            {
                could = n-1-i;
                inside = n - 2 * (n - 1 - i) - 2;
                couldStr = new string('~', could);
                insideStr = new string('#', inside);
                Console.Write(couldStr);
                Console.Write(sym);
                if (sym == 'Z')
                {
                    sym = 'A';
                }
                else
                {
                    sym++;
                }

                Console.Write(insideStr);
                Console.Write(sym);
                if (sym == 'Z')
                {
                    sym = 'A';
                }
                else
                {
                    sym++;
                }

                Console.WriteLine(couldStr);
            }
        }
    }

