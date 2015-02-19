using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.MagicStrings
{
    class MagicStrings
    {
        static void Main(string[] args)
        {
            int diff = int.Parse(Console.ReadLine());
            char[] latters = {'k','s','n','p'};
            int[] numbers = {1,3,4,5};
            for (int a1 =0; a1 < 4; a1++)
            {
                for (int a2 =0; a2 < 4; a2++)
                {
                    for (int a3 =0; a3 < 4; a3++)
                    {
                        for (int a4 =0; a4 < 4; a4++)
                        {
                            for (int a5 =0; a5 < 4; a5++)
                            {
                                for (int a6 =0; a6 < 4; a6++)
                                {
                                    for (int a7 =0; a7 < 4; a7++)
                                    {
                                        for (int a8 =0; a8 < 4; a8++)
                                        {

                                             int left = numbers[a1] + 
                                                        numbers[a2] + 
                                                        numbers[a3] + 
                                                        numbers[a4];
                                            int right = numbers[a5] + 
                                                        numbers[a6] + 
                                                        numbers[a7] + 
                                                        numbers[a8];
                                            if (Math.Abs(left-right)==diff)
                                            {
                                                string result ="" +
                                                      latters[a1] +
                                                      latters[a2] + 
                                                      latters[a3] +
                                                      latters[a4] + 
                                                      latters[a5] + 
                                                      latters[a6] + 
                                                      latters[a7] + 
                                                      latters[a8];
                                                
                                                Console.WriteLine(result);
	                                            
                                                
                                            }
                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
