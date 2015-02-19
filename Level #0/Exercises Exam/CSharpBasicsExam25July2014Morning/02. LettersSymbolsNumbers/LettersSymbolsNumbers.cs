using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class LettersSymbolsNumbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumNum = 0;
            int sumSymbol = 0;
            int sumChar = 0;
            for (int start = 0; start < n; start++)
            {


                string input = Console.ReadLine().ToUpper().Trim();
                List<char> r = input.ToList<char>();
                r.RemoveAll(c => c == ' ');
                input = new string(r.ToArray());
                char[] stringArr = input.ToCharArray();


                for (int i = 0; i < stringArr.Length; i++)
                {
                    char charNow = stringArr[i];

                    if (charNow >= 48 && charNow <= 57)
                    {
                        int num = charNow - 48;
                        sumNum += num * 20;
                    }
                    if (charNow >= 65 && charNow <= 90)
                    {
                        int abc = charNow - 64;
                        sumSymbol += abc * 10;
                    }
                    if (!(charNow >= 48 && charNow <= 57) && !(charNow >= 65 && charNow <= 90))
                    {
                        sumChar += 200;
                    }

                }
            }
            Console.WriteLine(sumSymbol);
            Console.WriteLine(sumNum);
            Console.WriteLine(sumChar);
        }
    }

