namespace BankOfKurtovoKonare.Data
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Interfaces;

    class CompaniesCustomer : BaseCustomer, ICustomer
    {
        private string bulstat;
        private string eik;

        public string Bulstat
        {
            get { return bulstat; }
            set { bulstat = value; }
        }

        public string Eik
        {
            get { return eik; }
            set { eik = value; }
        }
        
        
        public CompaniesCustomer(string firstName, string lastName, string address, string phone, string homePhone, string email, string officeAddress,string bulstat, string eik)
            : base(firstName, lastName, address, phone, homePhone, email, officeAddress)
        {
            this.Bulstat = bulstat;
            this.Eik = eik;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} Email: {2} Bulstat {3} EIK {4}", this.FirstName, this.LastName, this.Email,this.Bulstat,this.Eik);
        }
    }
}
