﻿namespace Problem01_GalacticGPS
{
    using System;
    using System.Collections.Generic;

    class StartConsoleApp
    {
        static void Main(string[] args)
        {
            Location home = new Location(18.037986, 28.870097, Planet.Earth);
            Console.WriteLine(home);
        }
    }
}
