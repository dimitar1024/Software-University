using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.NineDigitMagicNumbers
{
    class NineDigitMagicNumbers
    {
        static void Main(string[] args)
        {

            //VERY SLOWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWWW :D :D :D
            Console.WriteLine("Enter sum number:");
            int sum = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter diff number:");
            int diff = int.Parse(Console.ReadLine());


            for (int i = 111111111; i < 777777777; i++)
            {
                int hundsMillon = i / 100000000;
                int tensMillion = (i / 10000000) % 10;
                int million = (i / 1000000) % 10;
                int hundsThousend = (i / 100000) % 10;
                int tensThousand = (i / 10000) % 10;
                int thousand = (i / 1000) % 10;
                int hundred = (i / 100) % 10;
                int tens = (i / 10) % 10;
                int ones = i % 10;
                bool oness = ones >=1&& ones <=7;
                bool tenss = tens >=1&& tens <=7;
                bool hundreds = hundred >=1&& hundred <=7;
                bool ths = thousand >= 1 && thousand <= 7;
                bool tenThs = tensThousand >=1&& tensThousand <=7;
                bool hundsThs = hundsThousend >=1&& hundsThousend <=7;
                bool millions = million >=1&& million <=7;
                bool tensMs = tensMillion >=1&& tensMillion <=7;
                bool hundsMs = hundsMillon >=1&& hundsMillon <=7;
                if (oness && tenss && hundreds && ths &&tenThs && hundsThs && millions && tensMs && hundsMs)
                {

                    int fisrstThree = hundsMillon * 100 + tensMillion * 10 + million;
                    int secondThree = hundsThousend * 100 + tensThousand * 10 + thousand;
                    int thirdThree = hundred * 100 + tens * 10 + ones;
                    bool fexp = (ones + tens + hundred + thousand + tensThousand + hundsThousend + million + tensMillion + hundsMillon) == sum;
                    bool sexp = (thirdThree - secondThree) == diff;
                    bool texp = (secondThree - fisrstThree) == diff;
                    int count = 0;
                    if (fexp && sexp && texp)
                    {
                        
                        if (oness && tenss && hundreds && tenThs && hundsThs && millions && tensMs && hundsMs)
                        {
                            Console.WriteLine(i);
                        }
                        
                    }
                    if ((fexp = false))
                    {
                        count++;
                    }
                    if ((sexp = false))
                    {
                        count++;
                    }
                    if ((texp = false))
                    {
                        count++;
                    }
                    if (count != 0)
                    {
                        Console.WriteLine("No");
                    }
                }
                
            }
        }
    }
}
