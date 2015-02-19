using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Animals
{
    public abstract class Animal
    {
        private string name;
        private int age;
        private string gender;

        public string Name
        {
            get { return name; }
            set
            {
                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentNullException("Name is Empty");
                    }
                    else
                    {
                        name = value;
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

        public string Gender
        {
            get { return gender; }
            set
            {
                try
                {
                    if (!(value == "Male" || value == "male" || value == "female" || value == "Female"))
                    {
                        throw new ArgumentNullException("Invalid gender. Please enter \"male\" of \"female\"");
                    }
                    else
                    {
                        gender = value;
                    }
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Animal(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
    }
}
