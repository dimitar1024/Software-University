namespace BankOfKurtovoKonare.Data
{
    using System;
    using System.Collections.Generic;
    using BankOfKurtovoKonare.Interfaces;
    abstract class BaseCustomer : ICustomer
    {
        private string firstName;
        private string lastName;
        private string address;
        private string phone;
        private string homePhone;
        private string email;
        private string officeAddress;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string HomePhone
        {
            get { return homePhone; }
            set { homePhone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string OfficeAddress
        {
            get { return officeAddress; }
            set { officeAddress = value; }
        }


        public BaseCustomer(string firstName, string lastName, string address, string phone, string homePhone, string email,string officeAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.Phone = phone;
            this.HomePhone = homePhone;
            this.Email = email;
            this.OfficeAddress = officeAddress;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} Email: {2} ", this.FirstName, this.LastName, this.Email);
        }
    }
}
