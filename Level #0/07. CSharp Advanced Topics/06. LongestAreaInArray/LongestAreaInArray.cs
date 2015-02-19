using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.LongestAreaInArray
{
    class LongestAreaInArray
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            string[] array = new string[n];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Console.ReadLine();
            }

            int length = 0;
            string value = null;

            for (int i = 0; i < array.Length; i++)
            {
                int count = 0;

                for (int j = i; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (length < count)
                {
                    length = count;
                    value = array[i];
                }
            }
            Console.WriteLine(length);
            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(value);
            }
        }
    }
}
