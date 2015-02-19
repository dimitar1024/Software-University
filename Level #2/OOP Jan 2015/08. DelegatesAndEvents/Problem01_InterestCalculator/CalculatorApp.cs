using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_InterestCalculator
{
    public delegate decimal CalculateInterest(decimal sum, decimal interest, int years);

    class CalculatorApp
    {
        private decimal money;
        private decimal interes;
        private CalculateInterest type;
        private int years;

        public CalculatorApp(decimal money, decimal interes, int years, CalculateInterest type)
        {
        this.years = years;
        this.type = type;
        this.interes = interes;
        this.money = money;
        }

        public override string ToString()
        {
            Console.WriteLine("|Money     |Interest  |Years     |Result    |");
            return string.Format("|{0,-10}|{1,-10}|{2,-10}|{3,-10:F4}|",this.money,this.interes,this.years, this.type(this.money, this.interes, this.years));
        }
    }
}
