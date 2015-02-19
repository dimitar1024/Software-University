using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main()
        {
            ulong box1 = ulong.Parse(Console.ReadLine());
            ulong box2 = ulong.Parse(Console.ReadLine());
            ulong box3 = ulong.Parse(Console.ReadLine());
            ulong box4 = ulong.Parse(Console.ReadLine());
            ulong tableTops = ulong.Parse(Console.ReadLine());
            ulong madeTable = ulong.Parse(Console.ReadLine());
            
            
            ulong legs = (1 * box1) + (2 * box2) + (3 * box3) + (4 * box4);
            // table 4 legs + 1 top1;

            ulong needlegs = madeTable*4;
            

            ulong topLeft = tableTops - madeTable;
            ulong LegsLeft = legs - (madeTable * 4);

            

            if (tableTops == madeTable && legs >= needlegs)
            {
                Console.WriteLine("Just enough tables made: {0}",madeTable);
            }

            if (tableTops < madeTable && legs >= needlegs)
            {
                Console.WriteLine("less: -{0}",madeTable-tableTops);
                Console.WriteLine("tops needed: {0}, legs needed: 0", madeTable - tableTops);
            }

            if (tableTops >= madeTable && legs < needlegs)
            {
                Console.WriteLine("less: -{0}", madeTable - tableTops);
                Console.WriteLine("tops needed: 0, legs needed: {0}", needlegs-legs);
            }
            
            
            
            if (tableTops > madeTable && legs >= needlegs)
            {
                Console.WriteLine("more: {0}",topLeft);
                Console.WriteLine("tops left: {0}, legs left: {1}",topLeft,LegsLeft);

            }

        }
    }

