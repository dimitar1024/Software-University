namespace BankOfKurtovoKonare.Data
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Interfaces;

    class LoanAccount : BaseAccount
    {
        public LoanAccount(ICustomer customer, decimal balance, double interestRate)
            : base(customer, balance, interestRate)
        {
        }

        public override void CalculateInterestForGivenPeriod(int months)
        {
            if (this.Customer.GetType().Name == "IndividualCustomer")
            {
                base.CalculateInterestForGivenPeriod(months-3);
            }
            else
            {
                base.CalculateInterestForGivenPeriod(months-2);
            }
            
        }
    }
}
