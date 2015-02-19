using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_InterestCalculator
{
    class CalculatorMethods
    {
        public static decimal GetSimpleInterest(decimal sum, decimal interest, int years)
        {
            return sum * (1 + (interest / 100) * years);
        }

        public static decimal GetCompoundInterest(decimal sum, decimal interest, int years)
        {
            return sum * (decimal)Math.Pow((double)(1 + (interest / 100) / 12), 12 * years);
        }
    }
}
