using System;

namespace Problem01_Persons
{
    class Person
    {
        private string name;
        private int age;
        private string email;
        public string Name
        {
            get { return name; }
            set
            {

                try
                {
                    if (string.IsNullOrEmpty(value.Trim()))
                    {
                        throw new ArgumentNullException("Property name is empty");
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
                        throw new ArgumentOutOfRangeException("Age is interval [0...100]");
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

        public string Email
        {
            get { return email; }
            set {
                try
                {
                    if (value == null)
                    {
                        email = value;
                    }
                    else if (value.Contains("@"))
                    {
                        email = value;
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Email.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name, int age, string email)
            : this(name, age)
        {
            this.Email = email;
        }


        public override string ToString()
        {
            if (this.Email == null)
            {
                return "Name: " + this.Name + " Age:" + this.Age;
            }
            else
            {
                return "Name: " + this.Name + " Age:" + this.Age + " Email:" + this.Email;
            }
            
        }
    }
}
