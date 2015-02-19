using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Problem05_BitArray
{
    class BitArray
    {
        //methods
        private bool[] bits;

        public BitArray(int size)
        {
            try
            {
                if (size < 1 || size > 100000)
                {
                    throw new ArgumentOutOfRangeException("Bit array size must be between [1...100000]");
                }
                else
                {
                    this.bits = new bool[size];
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

        public int this[int index] 
        {
            get { return this.bits[index] == true ? 1 : 0; }
            set
            {
                try
                {
                    if (value < 0 && value > 1)
                    {
                        throw new ArgumentOutOfRangeException("Bit must be 0 or 1");
                    }
                    if (index < 0 && index > this.bits.Length-1)
                    {
                        throw new ArgumentOutOfRangeException(string.Format("Invalid index! Please enter index between [0...{0}]",this.bits.Length-1));
                    }

                    this.bits[index] = value == 1 ? true : false;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
        }

        private BigInteger GetPow(int index)
        {
            if (this[index] == 0)
            {
                return new BigInteger(0);
            }
            var range = Enumerable.Range(0, index);
            var result = range.AsParallel().Aggregate(new BigInteger(1), (x, y) => x * 2);
            return result * this[index];
        }

        // Read More for AsParallel https://msdn.microsoft.com/en-us/library/dd997393%28v=vs.110%29.aspx
        // For Aggregate http://stackoverflow.com/questions/7105505/linq-aggregate-algorithm-explained
        public override string ToString()
        {
            var range = Enumerable.Range(0, this.bits.Length);
            var resultNumbers = from i in range.AsParallel()
                                select GetPow(i);
            return resultNumbers.AsParallel().Aggregate((x, z) => x + z).ToString();
        }
    }
}
