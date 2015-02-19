using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FruitMarket
    
    {
        static void Main()
        {
            string day = Console.ReadLine();
            double kgOf1product = double.Parse(Console.ReadLine());
            string name1product = Console.ReadLine();
            double kgOf2product = double.Parse(Console.ReadLine());
            string name2product = Console.ReadLine();
            double kgOf3product = double.Parse(Console.ReadLine());
            string name3product = Console.ReadLine();
            double sum = 0;

            double banana = 1.80d;
            double cucumber = 2.75d;
            double tomato = 3.20d;
            double orange = 1.60d;
            double apple = 0.86d;

            switch (day)
            {
                case "Friday" :
                    banana = banana * 0.9d;
                    cucumber = cucumber * 0.9d;
                    tomato = tomato * 0.9d;
                    orange = orange * 0.9d;
                    apple = apple * 0.9d;
                    break;
                case "Sunday":
                    banana = banana * 0.95d;
                    cucumber = cucumber * 0.95d;
                    tomato = tomato * 0.95d;
                    orange = orange * 0.95d;
                    apple = apple * 0.95d;
                    break;
                case "Tuesday":
                    banana = banana * 0.8d;
                    orange = orange * 0.8d;
                    apple = apple * 0.8d;
                    break;

                case "Wednesday":
                    cucumber = cucumber * 0.9d;
                    tomato = tomato * 0.9d;
                    break;

                case "Thursday":
                    banana = banana * 0.7d;
                    break;

                    
            }
            if (name1product == "banana")
            {
                sum += (banana * kgOf1product);
            }
            if (name1product == "cucumber")
            {
                sum += (cucumber * kgOf1product);
            }
            if (name1product == "tomato")
            {
                sum += (tomato * kgOf1product);
            }
            if (name1product == "orange")
            {
                sum += (orange * kgOf1product);
            }
            if (name1product == "apple")
            {
                sum += (apple * kgOf1product);
            }

            if (name2product == "banana")
            {
                sum += (banana * kgOf2product);
            }
            if (name2product == "cucumber")
            {
                sum += (cucumber * kgOf2product);
            }
            if (name2product == "tomato")
            {
                sum += (tomato * kgOf2product);
            }
            if (name2product == "orange")
            {
                sum += (orange * kgOf2product);
            }
            if (name2product == "apple")
            {
                sum += (apple * kgOf2product);
            }


            if (name3product == "banana")
            {
                sum += (banana * kgOf3product);
            }
            if (name3product == "cucumber")
            {
                sum += (cucumber * kgOf3product);
            }
            if (name3product == "tomato")
            {
                sum += (tomato * kgOf3product);
            }
            if (name3product == "orange")
            {
                sum += (orange * kgOf3product);
            }
            if (name3product == "apple")
            {
                sum += (apple * kgOf3product);
            }

            Console.WriteLine("{0:f2}", sum);
        }
    }

