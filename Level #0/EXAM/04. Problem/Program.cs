using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    //FATAL ERROR
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        char[] latters= {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};

        for (int row1 = 0; row1 < n; row1++)
        {
            for (int col1 = 0; col1 < n; col1++)
            {
                for (int row2 = 0; row2 < n; row2++)
                {
                    for (int col2 = 0; col2 < n; col2++)
                    {
                        double distance = Math.Sqrt(Math.Pow((row2 - row1), 2) + Math.Pow((col2 - col1), 2));
                        if (distance == d + 1) 
                        {
                            int num1 = col1;
                            num1++;
                            int num2 = col2;
                            num2++;

                            Console.WriteLine("" + latters[row1] + num1 + " - " + latters[row2] + num2);
                        }
                        
                    }
                }
            }
        }
    }
}
