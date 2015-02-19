using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_InterestCalculator
{
    class StartCalculator
    {
        public static void Main() 
        {
            var baiIvanInvest = new CalculatorApp(500m, 4.3m, 20, CalculatorMethods.GetSimpleInterest);
            Console.WriteLine(baiIvanInvest);

            var nakovCompany = new CalculatorApp(2000m, 5m,50, CalculatorMethods.GetCompoundInterest);
            Console.WriteLine(nakovCompany);
        }
    }
}
