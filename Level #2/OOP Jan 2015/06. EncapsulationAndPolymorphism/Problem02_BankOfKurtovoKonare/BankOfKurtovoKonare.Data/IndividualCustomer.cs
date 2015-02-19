namespace BankOfKurtovoKonare.Data
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Interfaces;

    class IndividualCustomer : BaseCustomer
    {
        public IndividualCustomer(string firstName, string lastName, string address, string phone, string homePhone, string email, string officeAddress)
            : base(firstName, lastName, address, phone, homePhone, email, officeAddress)
        {

        }
    }
}
