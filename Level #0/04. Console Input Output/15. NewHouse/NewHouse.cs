using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.NewHouse
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Problem 15.	* – New House");
            Console.WriteLine(new string('=', 80));
            Console.WriteLine(@"This problem is from Variant 4 of C# Basics exam from 11-04-2014 Evening.  You can test your solution here .
Little Joro likes to build huts. After he built all the huts in his whole village, he decided to go to the big city and start building houses. But his knowledge of how to do this is limited. Help Joro to design the façade of a beautiful house by printing it to the console. The house must have a roof and one floor. The roof must contains only the symbols ‘*’ and ‘-’ and the floor must contains the symbols ‘*’ and ‘|’ (see the examples below).
");
            Console.WriteLine(new string('=', 80));

            int n = int.Parse(Console.ReadLine());

            string line = new string('|', 1);
            int wallInt = n - 2;
            string wall = new string('*', wallInt);

            for (int i = 0; i < n; i+=2)
            {
                int roof = i+1;
                int could = (n - roof)/2;
                string roofStr = new string('*', roof);
                string couldStr = new string('-', could);
                if (i == 0)
                {
                    Console.Write(new string('-', n/2));
                    Console.Write("*");
                    Console.WriteLine(new string('-', n / 2));
                }
                if (i != 0)
                {
                    Console.Write(couldStr);
                    Console.Write(roofStr);
                    Console.WriteLine(couldStr);
                }
             }
            for (int i = 0; i < n; i++)
            {
                Console.Write(line);
                Console.Write(wall);
                Console.WriteLine(line);
            }
            
        }
    }
}
