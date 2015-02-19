namespace CompanyHierarchy.ConsoleApp
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using CompanyHierarchy.Interface;

    public class Person : IPerson
    {
        private string firstName;
        private string lastName;
        private int id;

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

        public int ID
        {
            get { return id; }
            set
            {
                try
                {
                    if (value < 0 && value > 10000)
                    {
                        throw new ArgumentOutOfRangeException("Invalid ID");
                    }
                    else
                    {
                        id = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Person(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.ID = id;
        }

        public override string ToString()
        {
            return string.Format("Name: {0} {1} ID: {2}",this.FirstName,this.LastName,this.ID);
        }
    }
}
