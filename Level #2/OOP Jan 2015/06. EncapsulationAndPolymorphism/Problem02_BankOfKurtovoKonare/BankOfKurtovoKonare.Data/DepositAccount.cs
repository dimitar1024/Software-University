namespace BankOfKurtovoKonare.Data
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Interfaces;

    class DepositAccount : BaseAccount
    {
        public DepositAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void CalculateInterestForGivenPeriod(int months)
        {
            if (this.Balance < 1000)
            {
                Console.WriteLine("Your money for period {0} months is: {1:f2}", months, this.Balance);
            }
            else
            {

                base.CalculateInterestForGivenPeriod(months);
            }
        }

    }
}
