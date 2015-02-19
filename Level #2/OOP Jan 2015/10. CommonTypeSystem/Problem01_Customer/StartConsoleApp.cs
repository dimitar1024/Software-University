using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_Customer
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            Customer nakov = new Customer("Svetlin",
                "Nakov",
                "Nakov",
                "0041101045",
                "Tintqva 15",
                "0877777777",
                "nakov@gmail.com",
                CustomerType.Diamond);

            Customer ivan = new Customer("Ivan",
                "Vankov",
                "Vankov",
                "8011000045",
                "Tri Ushi 2122",
                "0875455565",
                "gatakka@gmail.com",
                CustomerType.Golden);

            
            Payment laptop = new Payment("Acer", 2300);
            nakov.AddPayment(laptop);

            Console.WriteLine(nakov);
            Console.WriteLine(ivan);

        }
    }
}
