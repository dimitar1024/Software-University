

namespace BankOfKurtovoKonare.Data
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Interfaces;

    abstract class BaseAccount
    {
        private ICustomer customer;
        private decimal balance;
        private double interestRate;

        public ICustomer Customer
        {
            get { return customer; }
            set { customer = value; }
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public BaseAccount(ICustomer customer, decimal balance, double interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate/12/100;
        }

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        public virtual void Deposit(decimal depositPrice)
        {
            this.Balance += depositPrice;
        }

        /*
         * First formula in the home is very wrong. Can not bring in 1000 lev and earn 32,000 over 
         * a period of 12 years at an interest rate of 4%.
           Secondly I found the true formula for compound interest,
         * but could not find compound interest monthly.
         * Third changed field months in field for years.
         */
        public virtual void CalculateInterestForGivenPeriod(int months)
        {
            //decimal result = this.Balance * (decimal)(Math.Pow((1 +(this.InterestRate/100)),(1/(12/years))));
            decimal result = this.Balance * (decimal)this.InterestRate * months;
            Console.WriteLine("Interest on account of {0} for period {1} months is: {2:f2}", this.Customer.FirstName, months, result);
        }

        public override string ToString()
        {
            return string.Format("{0}\nBalance: {1:f2} BGN Interest rate: {2:f2} %",this.Customer.ToString(), this.Balance, this.InterestRate);

        }
    }
}
