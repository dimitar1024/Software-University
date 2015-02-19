namespace Problem01_Customer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /*Problem 1.	Customer
        Define a class Customer, which contains data about a customer – first name, middle name and last name, ID (EGN), permanent address, mobile phone, e-mail, list of payments and customer type. 
        •	Define a class Payment which holds a product name and price.
        •	Define an enumeration for the customer type, holding the following types of customers: One-time , Regular, Golden, Diamond.
        •	Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
        •	Implement the ICloneable interface. The Clone() method should make a deep copy of all object fields into a new object of type Customer.
        •	Implement the IComparable<Customer> interface to compare customers by full name (as first criteria, in lexicographic order) and by ID (as second criteria, in ascending order).
*/
    public class Customer : IComparable<Customer>, ICloneable
    {
        private string firstName;
        private string middleName;
        private string lastName;
        private string egn;
        private string permanentAddress;
        private string mobilePhone;
        private string email;
        
        private List<Payment> payments = new List<Payment>();
        private CustomerType customerType;

        public Customer(string firstName, string middleName, string lastName, string egn, string permanentAddress, string mobilePhone, string email, CustomerType customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.EGN = egn;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.customerType = customerType;
        }

        public string FirstName
        {
            get { return firstName; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("First name is Empty! ");
                    }
                    else
                    {
                        this.firstName = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string MiddleName
        {
            get { return middleName; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Middle name is Empty! ");
                    }
                    else
                    {
                        this.middleName = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string LastName
        {
            get { return lastName; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Last name is Empty! ");
                    }
                    else
                    {
                        this.lastName = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string EGN
        {
            get { return egn; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("EGN is Empty! ");
                    }

                    if (value.Length < 10 && value.Length > 10)
                    {
                        throw new ArgumentOutOfRangeException("EGN must be 10 digits");
                    }
                    this.egn = value;

                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string PermanentAddress
        {
            get { return permanentAddress; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Address is Empty! ");
                    }
                    else
                    {
                        this.permanentAddress = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string MobilePhone
        {
            get { return mobilePhone; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Mobile phone is Empty! ");
                    }
                    else
                    {
                        this.mobilePhone = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Email is Empty! ");
                    }
                    else
                    {
                        this.email = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public void AddPayment(Payment payment)
        {
            this.payments.Add(payment);
        }

        public void RemovePayment(Payment payment)
        {
            this.payments.Remove(payment);
        }

        public override bool Equals(object param)
        {
            Customer customer = param as Customer;

            if (customer == null)
            {
                return false;
            }

            if (!Object.Equals(this.FirstName, customer.FirstName))
            {
                return false;
            }

            if (!Object.Equals(this.MiddleName, customer.MiddleName))
            {
                return false;
            }

            if (!Object.Equals(this.LastName, customer.LastName))
            {
                return false;
            }

            if (!Object.Equals(this.PermanentAddress, customer.PermanentAddress))
            {
                return false;
            }

            if (!Object.Equals(this.MobilePhone, customer.MobilePhone))
            {
                return false;
            }

            if (!Object.Equals(this.Email, customer.Email))
            {
                return false;
            }

            if (this.EGN != customer.EGN)
            {
                return false;
            }

            return true;
        }

        public static bool operator ==(Customer customer1, Customer customer2)
        {
            return Customer.Equals(customer1, customer2);
        }

        public static bool operator !=(Customer customer1, Customer customer2)
        {
            return !(Customer.Equals(customer1, customer2));
        }

        public override int GetHashCode()
        {
            return this.FirstName.GetHashCode() ^ this.LastName.GetHashCode() ^
                this.EGN.GetHashCode() ^ this.PermanentAddress.GetHashCode() ^ this.MobilePhone.GetHashCode() ^
                this.Email.GetHashCode() ^ this.payments.GetHashCode() ^ this.customerType.GetHashCode();
        }

        public override string ToString()
        {
            return String.Format(
                "Student(Name: {0} {1} {2}, EGN: {3} Address: {4})",
                this.FirstName, this.MiddleName, this.LastName, this.EGN, this.PermanentAddress);
        }

        public int CompareTo(Customer otherCustomer)
        {
            string fullName = this.FirstName + this.MiddleName + this.LastName;
            string otherFullName = otherCustomer.FirstName + otherCustomer.MiddleName + otherCustomer.LastName;
            if (fullName.CompareTo(otherFullName) == 0)
            {
                return this.EGN.CompareTo(otherCustomer.EGN);
            }
            else
            {
                return fullName.CompareTo(otherFullName);
            }
        }

        object ICloneable.Clone()
        {
            var copy = this.MemberwiseClone();
            (copy as Customer).payments = new List<Payment>();
            foreach (var payment in this.payments)
            {
                var copyPaiment = new Payment(payment.ProductName, payment.Price);
                (copy as Customer).payments.Add(copyPaiment);
            }
            return copy;
        }
    }
}
