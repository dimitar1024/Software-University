using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class NakovsMatching
    {
        static void Main(string[] args)
        {
            string firstStr = Console.ReadLine().ToLower().Replace(" ","");
            string secondStr = Console.ReadLine().ToLower().Replace(" ", "");
            int d = int.Parse(Console.ReadLine());
            bool found = false;

            for (int firstindex = 1; firstindex <= firstStr.Length-1; firstindex++)
            {
                string leftstrA = firstStr.Substring(0,firstindex);
                string rightstrA = firstStr.Substring(firstindex);
                string leftstrB = "";
                string rightstrB = "";
                int leftStrA = 0;
                int rightStrA = 0;
                

                foreach (char ch in leftstrA)
                {
                    leftStrA += (int)ch;
                }

                foreach (char c in rightstrA)
                {
                    rightStrA += (int)c;
                }


                for (int secondindex = 1; secondindex <= secondStr.Length - 1; secondindex++)
                {
                    leftstrB = secondStr.Substring(0, secondindex);
                    rightstrB = secondStr.Substring(secondindex);
                    int leftStrB = 0;
                    int rightStrB = 0;

                    foreach (char ach in leftstrB)
                    {
                        leftStrB += (int)ach;
                    }

                    foreach (char bch in rightstrB)
                    {
                        rightStrB += (int)bch;
                    }

                    int sum = Math.Abs((leftStrA * rightStrB) - (rightStrA * leftStrB));
                    if (sum <= d)
                    {
                        found = true;
                        Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs", leftstrA, rightstrA, leftstrB, rightstrB,sum);
                    }
                }

                
            }
            

            
        }
    }

