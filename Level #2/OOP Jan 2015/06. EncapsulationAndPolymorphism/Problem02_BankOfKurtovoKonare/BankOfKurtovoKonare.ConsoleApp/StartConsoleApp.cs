namespace BankOfKurtovoKonare.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Data;
    using BankOfKurtovoKonare.Interfaces;

    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            IndividualCustomer ivan = new IndividualCustomer("Ivan", "Rosenov", "ul. Stapil Dobrivdjbrite No:7", "8945613216", "02145789", "baiivan@baabv.bg", "Pri Gencho Mastikata na agala do DSK");
            
            CompaniesCustomer nakov = new CompaniesCustomer("Svetlin", "Nakov", "Tinttqva 15", "1234567890", "028765434", "nakov@nakov.com", "Tintqva 15", "000066456546", "06103053151");

            Console.WriteLine("Loan");
            Console.WriteLine(new string('*',80));
            LoanAccount ivanLoanAccount = new LoanAccount(ivan, 10000,4);
            ivanLoanAccount.CalculateInterestForGivenPeriod(12);
            LoanAccount nakovLoanAccount = new LoanAccount(nakov, 10000, 4);
            nakovLoanAccount.CalculateInterestForGivenPeriod(12);
            Console.WriteLine();

            Console.WriteLine("Deposit");
            Console.WriteLine(new string('*', 80));
            DepositAccount ivanDepositAccount = new DepositAccount(ivan, 10000, 4);
            ivanDepositAccount.CalculateInterestForGivenPeriod(12);
            DepositAccount nakovDepositAccount = new DepositAccount(nakov, 1000000, 4);
            nakovDepositAccount.CalculateInterestForGivenPeriod(12);
            Console.WriteLine();

            Console.WriteLine("Mortgage");
            Console.WriteLine(new string('*', 80));
            MortgageAccount ivanMortgageAccount = new MortgageAccount(ivan, 10000, 4);
            ivanMortgageAccount.CalculateInterestForGivenPeriod(12);
            MortgageAccount nakovMortgageAccount = new MortgageAccount(nakov, 12000, 14);
            nakovMortgageAccount.CalculateInterestForGivenPeriod(12);

        }
    }
}
