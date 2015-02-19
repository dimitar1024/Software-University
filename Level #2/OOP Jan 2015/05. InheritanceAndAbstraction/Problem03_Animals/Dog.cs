using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Problem03_Animals
{
    public class Dog : Animal, ISound
    {
        public Dog(string name, int age, string gender) : base(name,age,gender)
        {

        }

        public void ProduceSound()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer("../../Sounds/Dogs.wav"))
                {
                    Console.WriteLine("Dog sound...");
                    player.PlaySync();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
