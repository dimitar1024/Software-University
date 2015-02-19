namespace Problem01_GalacticGPS
{
    using System;
    using System.Collections.Generic;

    struct Location
    {
        // var
        private double latitude;
        private double longitude;
        private Planet planet;

        // constructors
        public Location(double latitude, double longitude, Planet planet):this()
        {
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.Planet = planet;
        }

        
        // props
        public double Latitude
        {
            get { return latitude; }
            set {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Latitude must be positive number");
                    }

                    latitude = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine( ex.Message);
                }
            }
        }

        public double Longitude
        {
            get { return longitude; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException("Longitude must be positive number");
                    }

                    longitude = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public Planet Planet
        {
            get { return planet; }
            set { planet = value; }
        }
        
        //methods

        public override string ToString()
        {
            return string.Format("{0}, {1} - {2}",this.Latitude,this.Longitude,this.Planet);
        }

        
    }
}
