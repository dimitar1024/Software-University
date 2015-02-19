namespace Problem03_Animals
{
    using System;
    using System.Media;
    public class Frog : Animal, ISound
    {
        public Frog(string name, int age, string gender)
            : base(name, age, gender) { }

        public void ProduceSound()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer("../../Sounds/Frogs.wav"))
                {
                    Console.WriteLine("Frog sound...");
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
