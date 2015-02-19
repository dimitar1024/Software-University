namespace BankOfKurtovoKonare.Data
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Interfaces;

    class MortgageAccount : BaseAccount
    {
        public MortgageAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer,balance,interestRate)
        {
        }

        public override void CalculateInterestForGivenPeriod(int months)
        {
            var halfInterestMonths = 0;
            switch (this.Customer.GetType().Name)
            {
                case "IndividualCustomer":
                    halfInterestMonths = 6;
                    break;
                case "CompanyCustomer":
                    halfInterestMonths = 12;
                    break;
            }

            var fullInterestMonths = months - halfInterestMonths;

            if (fullInterestMonths <= 0)
            {

                decimal result = (this.Balance * (decimal)this.InterestRate * halfInterestMonths)/2;
                Console.WriteLine("Interest on account of {0} for period {1} months is: {2:f2}", this.Customer.FirstName, months, result);
            }


            decimal totalResult = (this.Balance * (decimal)this.InterestRate * halfInterestMonths) + (this.Balance * (decimal)this.InterestRate * fullInterestMonths);
            Console.WriteLine("Interest on account of {0} for period {1} months is: {2:f2}", this.Customer.FirstName, months, totalResult);
        }
    }
}
