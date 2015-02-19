using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problem04_SoftwareUniversityLearningSystem;

namespace Problem04_SoftwareUniversityLearningSystem
{
    class SULSTest
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            OnlineStudent dimitar = new OnlineStudent("Dimitar", "Georgiev", 19, "05555555531", 5.47d, "OOP");
            persons.Add(dimitar);
            OnlineStudent pesho = new OnlineStudent("Pesho", "Georgiev", 19, "05545345531", 5.12d, "HQC");
            persons.Add(pesho);
            OnlineStudent ivan = new OnlineStudent("Angel", "Tenchev", 19, "2141424234", 5.47d, "PHP");
            persons.Add(ivan);

            OnsiteStudent kancho = new OnsiteStudent("Gergi", "Ivanov", 32, "34452442364", 5.32, "Java", 4);
            persons.Add(kancho);
            OnsiteStudent marian = new OnsiteStudent("Marian", "Stoimenov", 34, "34452442364", 4.12, "CSS", 1);
            persons.Add(marian);
            OnsiteStudent tereza = new OnsiteStudent("Tereza", "Todorova", 22, "34452442364", 3.75, "HTML", 3);
            persons.Add(tereza);

            var query = persons.Where(o => o.Age > 18 && o.Age < 23);

            foreach (var item in query)
            {
                Console.WriteLine(item.FirstName +" "+ item.LastName+" age: "+ item.Age);
            }


            // I think that these examples are enough to show the inheritance of classes
        }
    }
}
