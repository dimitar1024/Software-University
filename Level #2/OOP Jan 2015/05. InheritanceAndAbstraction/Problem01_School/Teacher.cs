using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem01_School
{
    public class Teacher : Person
    {
        private List<Discipline> disciplines = new List<Discipline>();

        //constructors
        public Teacher(string name)
            : base(name)
        {

        }

        public Teacher(string name, string lastName, int age, string phone, string email)
            : base(name, lastName, age, phone, email)
        {

        }

        //methods
        public void AddDiscipline(Discipline discipline) 
        {
            disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            disciplines.Remove(discipline);
        }

        public string PrintDiscipline()
        {
            var allDiscipline = new StringBuilder();

            foreach (var discipline in disciplines)
            {
                allDiscipline.AppendFormat(discipline.ToString() + "\n");
            }

            return allDiscipline.ToString();
        }
        
        public override string ToString()
        {
            return string.Format("name: {0} {1} age: {2} phone: {3} email: {4}", this.FirstName, this.LastName, this.Age, this.Phone, this.Email).ToString();
        }
    }
}
