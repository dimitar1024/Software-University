using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int leftDiagonal = 0;
        int center = 0;
        int rightDiagonal = 0;
        int leftcount = 0;
        int centercount = 0;
        int rightcount = 0;

        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        for (int k = 0; k < n-1; k++)
        {
            int num1 = numbers[k];
            int num2 = numbers[k + 1];


            center = num1 & num2;
            

            leftDiagonal = num1 & num2 << 1;


            rightDiagonal = num1 & num2 >>1;

            while (center > 0)
            {
                centercount += (center & 1);
                center >>= 1;
            }
            while (leftDiagonal > 0)
            {
                leftcount += (leftDiagonal & 1);
                leftDiagonal >>= 1;
            }
            while (rightDiagonal > 0)
            {
                rightcount += (rightDiagonal & 1);
                rightDiagonal >>= 1;
            }

            leftDiagonal = 0;
            rightDiagonal = 0;
            center=0;

        }
       
        Console.WriteLine(leftcount);
        Console.WriteLine(rightcount);
        Console.WriteLine(centercount);
    }
}
