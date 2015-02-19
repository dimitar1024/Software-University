using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.FiveSpecialLetters
{
    class FiveSpecialLetters
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            char[] latters = { 'a', 'b', 'c', 'd', 'e' };
            int[] numbers = { 5, -12, 47, 7, -32 };
            List<char> stringNow = new List<char>();
            string output = "";
            int count = 0;

            for (int a1 = 0; a1 < latters.Length; a1++)
            {
                for (int a2 = 0; a2 < latters.Length; a2++)
                {
                    for (int a3 = 0; a3 < latters.Length; a3++)
                    {
                        for (int a4 = 0; a4 < latters.Length; a4++)
                        {
                            for (int a5 = 0; a5 < latters.Length; a5++)
                            {
                                int weight = 0;
                                stringNow.Add(latters[a1]);
                                stringNow.Add(latters[a2]);
                                stringNow.Add(latters[a3]);
                                stringNow.Add(latters[a4]);
                                stringNow.Add(latters[a5]);
                                stringNow = stringNow.Distinct().ToList();

                                for (int i = 0; i < stringNow.Count; i++)
                                {
                                    switch (stringNow[i])
                                    {
                                        case 'a': weight += (i + 1) * numbers[0]; break;
                                        case 'b': weight += (i + 1) * numbers[1]; break;
                                        case 'c': weight += (i + 1) * numbers[2]; break;
                                        case 'd': weight += (i + 1) * numbers[3]; break;
                                        case 'e': weight += (i + 1) * numbers[4]; break;

                                    }
                                }

                                if (weight >= start && weight <= end)
                                {
                                    output += "" + latters[a1] + latters[a2] + latters[a3] + latters[a4] + latters[a5] + " ";
                                    count++;
                                }
                                stringNow.Clear();
                            }
                        }
                    }
                }
            }
            if (count==0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine(output);
            }

        }
    }
}
