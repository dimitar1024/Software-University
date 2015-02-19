using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Animals
{
    public class Kitten : Cat, ISound
    {
        public Kitten(string name, int age)
            : base(name,age)
        {
            this.Gender = "female";
        }
    }
}
