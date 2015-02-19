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
        int allBooks = 0;
        decimal totalPrice = 0;

        for (int i = 0; i < n; i++)
        {
            
            int packet = int.Parse(Console.ReadLine());
            int booksPerPacket = int.Parse(Console.ReadLine());
            decimal price = decimal.Parse(Console.ReadLine());

            if (packet >= 10 && packet < 20)
            {
                price = price - (price * (5/100m));
            }
            if (packet >= 20 && packet < 30)
            {
                price = price - (price * (6 / 100m));
            }
            if (packet >= 30 && packet < 40)
            {
                price = price - (price * (7 / 100m));
            }
            if (packet >= 40 && packet < 50)
            {
                price = price - (price * (8 / 100m));
            }
            if (packet >= 50 && packet < 60)
            {
                price = price - (price * (9 / 100m));
            }
            if (packet >= 60 && packet < 70)
            {
                price = price - (price * (10 / 100m));
            }
            if (packet >= 70 && packet < 80)
            {
                price = price - (price * (11 / 100m));
            }
            if (packet >= 80 && packet < 90)
            {
                price = price - (price * (12 / 100m));
            }
            if (packet >= 90 && packet < 100)
            {
                price = price - (price * (13 / 100m));
            }
            if (packet >= 100 && packet < 110)
            {
                price = price - (price * (14 / 100m));
            }
            
            if (packet >= 110)
            {
                price = price - (price * (15 / 100m));
            }

            


            int books = packet * booksPerPacket;
            decimal endPrice = books * price;
            allBooks +=books;
            totalPrice += endPrice;
            
        }

        Console.WriteLine(allBooks);
        Console.WriteLine("{0:f2}", totalPrice);
    }
}
