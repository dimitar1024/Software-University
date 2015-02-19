using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    public class Person
    {
        //props
        private string firstName;
        private string lastName;
        private int age;
        private string phone;
        private string email;

        public string FirstName
        {
            get { return firstName; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("First name is Empty");
                    }
                    else
                    {
                        firstName = value;
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
                        throw new ArgumentNullException("Last name is Empty");
                    }
                    else
                    {
                        lastName = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                try
                {
                    if (value < 0 && value > 100)
                    {
                        throw new ArgumentOutOfRangeException("Invalid Age");
                    }
                    else
                    {
                        age = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public string Phone
        {
            get { return phone; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Phone is Empty");
                    }
                    else
                    {
                        phone = value;
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
            set {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Email is Empty");
                    }
                    if (!value.Contains("@"))
                    {
                        throw new ArgumentException("Please enter valid email");
                    }
                    
                        email = value;
                    
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //constructors

        public Person(string name)
        {
            this.FirstName = name;
        }

        public Person(string name, string lastName, int age, string phone, string email)
        {
            this.FirstName = name;
            this.LastName = lastName;
            this.Age = age;
            this.Phone = phone;
            this.Email = email;
        }
    }
}
