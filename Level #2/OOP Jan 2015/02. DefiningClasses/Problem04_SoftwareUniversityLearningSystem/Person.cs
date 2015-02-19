using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_SoftwareUniversityLearningSystem;

namespace Problem04_SoftwareUniversityLearningSystem
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName
        {
            get { return firstName; }
            set {
                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("First name is empty");
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
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("First name is empty");
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
            set {
                try
                {
                    if (value < 0 && value > 100)
                    {
                        throw new ArgumentOutOfRangeException("Invalid Age. Age is interval [0..100]");
                    }
                    else
                    {
                        age = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Person( string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }
        
    }
}
