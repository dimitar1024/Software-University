namespace BankOfKurtovoKonare.Interfaces
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Data;

    interface IAccount
    {
        ICustomer Customer { get; set; }

        decimal Balance { get; set; }

        double InterestRate  { get; set; }

        void Deposit(decimal depositPrice);

        void CalculateInterestForGivenPeriod(int month);
    }
}
