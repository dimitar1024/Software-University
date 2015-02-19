using System;
using System.Linq;

namespace Methods
{
    class Methods
    {
        /// <summary>
        ///     This method calculate Triangle area
        /// </summary>
        /// <param name="sideA">"Enter side A"</param>
        /// <param name="sideB">"Enter side B"</param>
        /// <param name="sideC">"Enter side C"</param>
        /// <returns>Triangle area</returns>
        static double CalculateTriangleArea(double sideA, double sideB, double sideC)
        {
            try
            {
                if (sideA <= 0 || sideB <= 0 || sideC <= 0)
                {
                    throw new ArgumentOutOfRangeException("Sides should be positive.");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

            double semiRerimeter = (sideA + sideB + sideC) / 2;
            double area = Math.Sqrt(semiRerimeter * (semiRerimeter - sideA) * (semiRerimeter - sideB) * (semiRerimeter - sideC));

            return area;
        }

        /// <summary>
        ///     This method return number to text
        /// </summary>
        /// <param name="number"> Enter number of type integer</param>
        /// <returns>Number to text</returns>
        static string NumberToText(int number)
        {
            try
            {
                switch (number)
                {
                    case 0: return "zero";
                    case 1: return "one";
                    case 2: return "two";
                    case 3: return "three";
                    case 4: return "four";
                    case 5: return "five";
                    case 6: return "six";
                    case 7: return "seven";
                    case 8: return "eight";
                    case 9: return "nine";
                    default: throw new ArgumentOutOfRangeException("Invalid number!");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                return ex.Message;
            }
        }

        /// <summary>
        ///     This method return max number form given array
        /// </summary>
        /// <param name="elements"> Enter array of integers</param>
        /// <returns>Max number</returns>
        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("Array of elements is empty");
            }

            int max = int.MinValue;

            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                {
                    max = elements[i];
                }
            }

            return max;
        }

        /// <summary>
        ///  This method print number in given format
        /// </summary>
        /// <param name="number"> Number for print</param>
        /// <param name="format"> Format to print (f,%,r)</param>
        static void PrintAsNumber(object number, string format)
        {
            try
            {
                format = format.ToLower();
                string[] formates = new string[3] { "f", "%", "r" };

                if (formates.Any(format.Contains))
                {
                    if (format == "f")
                    {
                        Console.WriteLine("{0:f2}", number);
                    }
                    if (format == "%")
                    {
                        Console.WriteLine("{0:p0}", number);
                    }
                    if (format == "r")
                    {
                        Console.WriteLine("{0,8}", number);
                    }
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Pleace enter valid format to convert your number");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {

                Console.WriteLine(ex.Message);
            }

        }

        /// <summary>
        ///  This method calculate distance on two points
        /// </summary>
        /// <param name="x1"> Coordinate x on first point</param>
        /// <param name="y1"> Coordinate y on first point</param>
        /// <param name="x2"> Coordinate x on second point</param>
        /// <param name="y2"> Coordinate y on second point</param>
        /// <param name="isHorizontal"> Variable for horizontal check</param>
        /// <param name="isVertical">  Variable for vertical check</param>
        /// <returns></returns>
        static double CalculateDistance(double x1, double y1, double x2, double y2,
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = (y1 == y2);
            isVertical = (x1 == x2);

            if (isHorizontal == false && isVertical == false)
            {
                throw new ArgumentOutOfRangeException("Pleace enter coordinates on valid point");
            }

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        static void Main()
        {
            Console.WriteLine(CalculateTriangleArea(3, 4, 5));

            Console.WriteLine(NumberToText(5));

            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));

            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
