using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Animals
{
    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            List<Tomcat> tomcats = new List<Tomcat>();
            List<Dog> dogs = new List<Dog>();
            List<Frog> frogs = new List<Frog>();

            Tomcat tom = new Tomcat("Tom", 2);
            tomcats.Add(tom);
            Tomcat jo = new Tomcat("Jo", 4);
            tomcats.Add(jo);
            Tomcat kircor = new Tomcat("Kircor", 1);
            tomcats.Add(kircor);
            Tomcat garabet = new Tomcat("Garabet", 5);
            tomcats.Add(garabet);
            Tomcat chernyo = new Tomcat("Chernyo", 5);
            tomcats.Add(chernyo);

            double ageAverageTomcats = tomcats.Average(a => a.Age);

            Console.WriteLine("Average age on tomcats is: {0}", ageAverageTomcats);
            tom.ProduceSound();

            Dog joro = new Dog("Joro", 3, "male");
            dogs.Add(joro);
            Dog murdjo = new Dog("Murdjo", 7, "male");
            dogs.Add(murdjo);
            Dog djesaSvirkata = new Dog("Djesa Svirkata", 8, "female");
            dogs.Add(djesaSvirkata);
            Dog dupeblizka = new Dog("Dupeblizka", 14, "female");
            dogs.Add(dupeblizka);
            Dog zara = new Dog("Zara", 1, "male");
            dogs.Add(zara);

            double ageAverageDogs = dogs.Average(a => a.Age);

            Console.WriteLine("Average age on tomcats is: {0}", ageAverageDogs);
            joro.ProduceSound();

            Frog smukacha = new Frog("Smukacha", 3, "male");
            frogs.Add(smukacha);
            Frog shturcho = new Frog("Shturcho", 5, "male");
            frogs.Add(shturcho);
            Frog flick = new Frog("Flick", 1, "female");
            frogs.Add(flick);
            Frog franklin = new Frog("Franklin", 5, "female");
            frogs.Add(franklin);
            Frog crazyFrog = new Frog("CrazyFrog", 15, "female");
            frogs.Add(crazyFrog);

            double ageAverageFrogs = frogs.Average(a => a.Age);

            Console.WriteLine("Average age on tomcats is: {0}", ageAverageFrogs);
            crazyFrog.ProduceSound();
        }
    }
}
