using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02_EnterNumbers
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(Number.ReadNumber(0, 1000));
            }

            Console.WriteLine(String.Join(" ",numbers));
        }
    }
}
