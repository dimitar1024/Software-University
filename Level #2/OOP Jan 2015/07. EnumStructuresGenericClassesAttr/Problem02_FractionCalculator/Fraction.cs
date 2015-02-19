namespace Problem02_FractionCalculator
{
    using System;
    using System.Collections.Generic;

    class Fraction
    {
        private decimal numerator;
        private decimal denominator;

        public Fraction(decimal numerator, decimal denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }
        public decimal Numerator
        {
            get { return numerator; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Numerator must be positive number");
                    }

                    numerator = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public decimal Denominator
        {
            get { return denominator; }
            set
            {
                try
                {
                    if (value < 1)
                    {
                        throw new ArgumentOutOfRangeException("Denominator must be positive number or zero");
                    }

                    denominator = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            decimal r1 = (decimal)f1.numerator * f2.denominator + (decimal)f2.numerator * f1.denominator;
            decimal r2 = (decimal)f1.denominator * f2.denominator;
            return new Fraction(r1, r2);
        }

        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            decimal r1 = (decimal)f1.numerator * f2.denominator - (decimal)f2.numerator * f1.denominator;
            decimal r2 = (decimal)f1.denominator * f2.denominator;
            return new Fraction(r1, r2);
        }

        public override string ToString()
        {
            decimal result = this.Numerator / this.Denominator;
            return string.Format("{0}", result);
        }
    }
}
