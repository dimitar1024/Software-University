using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    public class Student : Person
    {
        //props
        private int classNumber;

        public int ClassNumber
        {
            get { return classNumber; }
            set
            {
                try
                {
                    if (value < 0 && value > 30)
                    {
                        throw new ArgumentOutOfRangeException("Invalid class number");
                    }
                    else
                    {
                        classNumber = value;
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        //constructor

        public Student(string name, int classNumber)
            : base(name)
        {
            this.ClassNumber = classNumber;
        }

        public Student(int classNumber,string name, string lastName, int age, string phone, string email)
            : base(name, lastName, age, phone, email)
        {
            this.ClassNumber = classNumber;
        }

        public override string ToString()
        {
            return string.Format("class number: {0} name: {1} {2} age: {3} phone: {4} email: {5}", this.ClassNumber, this.FirstName, this.LastName, this.Age, this.Phone, this.Email).ToString();
        }
    }
}
